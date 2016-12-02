using DataTransferObject;
using DomainModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminApplication.Reports
{
    public class ReportViewModel
    {
        public string TesteeLogin { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }

        public string Company { get; set; }
        public string OfficeLoc { get; set; }
        public string Sector { get; set; }
        public string Division { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }

        public List<string> CompanyList { get; set; }
        public List<string> OfficeLocList { get; set; }
        public List<string> SectorList { get; set; }
        public List<string> DivisionList { get; set; }
        public List<string> DepartmentList { get; set; }
        public List<string> PositionList { get; set; }

        public DevExpress.XtraReports.UI.XtraReport Report { get; set; }
        public BindingList<TesteeDTO> Testees { get; set; }
        public BindingList<GeneralReportClass> AllTestees { get; set; }
        public ReportViewModel()
        {
            Testees = new BindingList<TesteeDTO>();
            AllTestees = new BindingList<GeneralReportClass>();
        }

        public void SetUpViewModel()
        {
            CompanyList = new List<string>();
            OfficeLocList = new List<string>();
            SectorList = new List<string>();
            DivisionList = new List<string>();
            DepartmentList = new List<string>();
            PositionList = new List<string>();

            var data = ServicesHolder.ServiceClient.GetAllTestees();

            var t = data.Select(_ => _.Attribute1);
            CompanyList.AddRange(data.Select(_=>_.Attribute1).Where(s => !String.IsNullOrEmpty(s)).Distinct());
            OfficeLocList.AddRange(data.Select(_ => _.Attribute2).Where(s=>!String.IsNullOrEmpty(s)).Distinct());
            SectorList.AddRange(data.Select(_ => _.Attribute3).Where(s => !String.IsNullOrEmpty(s)).Distinct());
            DivisionList.AddRange(data.Select(_ => _.Attribute4).Where(s => !String.IsNullOrEmpty(s)).Distinct());
            DepartmentList.AddRange(data.Select(_ => _.Attribute5).Where(s => !String.IsNullOrEmpty(s)).Distinct());
            PositionList.AddRange(data.Select(_ => _.Attribute8).Where(s => !String.IsNullOrEmpty(s)).Distinct());
        }

        public void GenerateReport(ReportType type)
        {
            if (type == ReportType.Genaral)
            {
                var data = ServicesHolder.ServiceClient.GetAllTesteesForReport(FromDate, ToDate, 
                    Company,  OfficeLoc,  Sector,  Division, Department, Position).ToList();

                Report = new GeneralXtraReport();
                foreach (var inf in data)
                {
                    GeneralReportClass testee = new GeneralReportClass();
                    testee.Login = inf.Login;
                    testee.FirstName = inf.FirstName;
                    testee.LastName = inf.LastName;
                    testee.Company = inf.Attribute1;
                    testee.Office = inf.Attribute2;
                    testee.Sectore = inf.Attribute3;
                    testee.Devision = inf.Attribute4;
                    testee.Department = inf.Attribute5;
                    testee.Profession = inf.Attribute6;
                    testee.Title = inf.Attribute7;
                    testee.Position = inf.Attribute8;
                    testee.Role = inf.Attribute9;
                    testee.Manager = inf.Attribute10;
                    testee.HireDate = Convert.ToDateTime(inf.Attribute11).ToShortDateString();
                    testee.ComercialExp = inf.Attribute12;
                    testee.ISDExp = inf.Attribute13;
                    testee.Sectore = inf.Attribute3;
                    testee.Wrong = inf.Histories.Where(_ =>!_.IsAnswerCorrect).Count();
                    testee.Correct = inf.Histories.Where(_ => _.IsAnswerCorrect).Count();
                    testee.QuestionAmount = inf.Histories.Count();
                    AllTestees.Add(testee);
                }

                Report.DataSource = AllTestees;
            }
            else if (type == ReportType.ByLogin && !String.IsNullOrEmpty(TesteeLogin))
            {
                var inf = ServicesHolder.ServiceClient.FindByLogin("omor");
                Report = new TesteeReport();
                TesteeDTO testee = new TesteeDTO();
                testee.Login = inf.Login;
                testee.FirstName = inf.FirstName;
                testee.LastName = inf.LastName;
                testee.Attribute1 = inf.Attribute1;
                testee.Attribute2 = inf.Attribute2;
                testee.Attribute3 = inf.Attribute3;
                testee.Attribute4 = inf.Attribute4;
                testee.Attribute5 = inf.Attribute5;
                testee.Attribute6 = inf.Attribute6;
                testee.Attribute7 = inf.Attribute7;
                testee.Attribute8 = inf.Attribute8;
                testee.Attribute9 = inf.Attribute9;
                testee.Attribute10 = inf.Attribute10;
                testee.Attribute11 = Convert.ToDateTime(inf.Attribute11).ToShortDateString();
                testee.Attribute12 = inf.Attribute12;
                testee.Attribute13 = inf.Attribute13;
                List<HistoryDTO> sortedList = inf.Histories.OrderBy(x => x.Question.Training).ToList();
                testee.Histories = new BindingList<HistoryDTO>(sortedList);
                BindingList<TesteeDTO> data = new BindingList<TesteeDTO>();
                data.Add(testee);
                Report.DataSource = data;
            }
        }
    }
}
