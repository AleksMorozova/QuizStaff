using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Globalization;

namespace AdminApplication.Reports
{
    public partial class ReportsForm : DevExpress.XtraEditors.XtraForm, ILocalized
    {
        ReportViewModel model;

        public ReportsForm()
        {
            InitializeComponent();
            mvvmContextForReports.ViewModelType = typeof(ReportViewModel);
            model = mvvmContextForReports.GetViewModel<ReportViewModel>();
            mvvmContextForReports.SetViewModel(typeof(ReportViewModel), model);
            model.FromDate = DateTime.Now.AddDays(-7);
            model.ToDate = DateTime.Now;
            model.SetUpViewModel();
            BindToViewModel();
            SetUpComboBoxes();
        }

        private void BindToViewModel()
        {
            mvvmContextForReports.SetBinding(loginTextEdit, login => login.EditValue, "TesteeLogin");
            mvvmContextForReports.SetBinding(fromDateEdit, from => from.EditValue, "FromDate");
            mvvmContextForReports.SetBinding(toDateEdit, to => to.EditValue, "ToDate");
            mvvmContextForReports.SetBinding(companyComboBoxEdit, to => to.EditValue, "Company");
            mvvmContextForReports.SetBinding(officeLocComboBox, to => to.EditValue, "OfficeLoc");
            mvvmContextForReports.SetBinding(sectorComboBox, to => to.EditValue, "Sector");
            mvvmContextForReports.SetBinding(depertmentComboBox, to => to.EditValue, "Department");
            mvvmContextForReports.SetBinding(divisionComboBox, to => to.EditValue, "Division");
            mvvmContextForReports.SetBinding(positionComboBox, to => to.EditValue, "Position");
        }

        private void SetUpComboBoxes()
        {
            companyComboBoxEdit.Properties.Items.AddRange(model.CompanyList);
            officeLocComboBox.Properties.Items.AddRange(model.OfficeLocList);
            sectorComboBox.Properties.Items.AddRange(model.SectorList);
            depertmentComboBox.Properties.Items.AddRange(model.DepartmentList);
            divisionComboBox.Properties.Items.AddRange(model.DivisionList);
            positionComboBox.Properties.Items.AddRange(model.PositionList);
        }

        private ReportType ReportType = ReportType.None;

        private void reportTypeRadioGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = reportTypeRadioGroup.Properties.Items[reportTypeRadioGroup.SelectedIndex].Value;
            if (selected.ToString() == "General")
            {
                ReportType = ReportType.Genaral;
                companyLayoutControlItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                officeLocationLayoutControlItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                divisionLayoutControlItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                sectorLayoutControlItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                departmentLayoutControlItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                positionLayoutControlItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
            else if (selected.ToString() == "ByLogin")
            {
                ReportType = ReportType.ByLogin;
                companyLayoutControlItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                officeLocationLayoutControlItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                divisionLayoutControlItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                sectorLayoutControlItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                departmentLayoutControlItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                positionLayoutControlItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
        }

        private void previewButton_Click(object sender, EventArgs e)
        {
            if (ReportType == ReportType.Genaral || (ReportType == ReportType.ByLogin && !String.IsNullOrEmpty(model.TesteeLogin)))
            {
                model.GenerateReport(ReportType);
                model.Report.CreateDocument();
               // previewReportDocument.DocumentSource = model.Report;
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (ReportType == ReportType.Genaral || (ReportType == ReportType.ByLogin && !String.IsNullOrEmpty(model.TesteeLogin)))
            {
                model.GenerateReport(ReportType);
                var tool = new DevExpress.XtraReports.UI.ReportPrintTool(model.Report);
                tool.AutoShowParametersPanel = false;
                tool.ShowPreview();
            }
        }

        public void Localized(string language)
        {
            var resources = new ComponentResourceManager(typeof(ReportsForm));
            CultureInfo newCultureInfo = new CultureInfo(language);
            resources.ApplyResources(dateRangeLabelControl, "dateRangeLabelControl", newCultureInfo);
            resources.ApplyResources(endDateLabelControl, "endDateLabelControl", newCultureInfo);
            resources.ApplyResources(startDateLabelControl, "startDateLabelControl", newCultureInfo);
            resources.ApplyResources(loginLayoutControlItem, "loginLayoutControlItem", newCultureInfo);
            resources.ApplyResources(companyLayoutControlItem, "companyLayoutControlItem", newCultureInfo);
            resources.ApplyResources(officeLocationLayoutControlItem, "officeLocationLayoutControlItem", newCultureInfo);
            resources.ApplyResources(divisionLayoutControlItem, "divisionLayoutControlItem", newCultureInfo);
            resources.ApplyResources(sectorLayoutControlItem, "sectorLayoutControlItem", newCultureInfo);
            resources.ApplyResources(departmentLayoutControlItem, "departmentLayoutControlItem", newCultureInfo);
            resources.ApplyResources(positionLayoutControlItem, "positionLayoutControlItem", newCultureInfo);
            resources.ApplyResources(reportParameterLayoutGroup, "reportParameterLayoutGroup", newCultureInfo);
            resources.ApplyResources(additionalParametersLayoutGroup, "additionalParametersLayoutGroup", newCultureInfo);
            resources.ApplyResources(reportTypeRadioGroupLayoutControlItem, "reportTypeRadioGroupLayoutControlItem", newCultureInfo);
            resources.ApplyResources(createButton, "createButton", newCultureInfo);

            this.Text = !String.IsNullOrEmpty(resources.GetString("Title", newCultureInfo))
                     ? resources.GetString("Title", newCultureInfo) : "Reports";
        }
    }
}