using DataTransferObject;
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
        public DevExpress.XtraReports.UI.XtraReport Report { get; set; }
        public BindingList<TesteeDTO> Testees { get; set; }

        public ReportViewModel()
        {
            Testees = new BindingList<TesteeDTO>();
        }

        public void GenerateReport(ReportType type)
        {
            if (type == ReportType.Genaral)
            {
                var data = ServicesHolder.ServiceClient.GetAllTesteesForReport(FromDate, ToDate).ToList();
                Report = new GeneralReport();
                foreach (var testee in data)
                    Testees.Add(testee);

                Report.DataSource = Testees;
            }
            else if (type == ReportType.ByLogin && !String.IsNullOrEmpty(TesteeLogin))
            {
                Testees.Add(ServicesHolder.ServiceClient.FindByLogin(TesteeLogin));
                Report = new TesteeReport();
                Report.DataSource = Testees;
            }
        }
    }
}
