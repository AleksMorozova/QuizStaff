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

namespace AdminApplication.Reports
{
    public partial class ReportsForm : DevExpress.XtraEditors.XtraForm
    {
        ReportViewModel model;

        public ReportsForm()
        {
            InitializeComponent();
            mvvmContextForReports.ViewModelType = typeof(ReportViewModel);
            model = mvvmContextForReports.GetViewModel<ReportViewModel>();
            mvvmContextForReports.SetViewModel(typeof(ReportViewModel), model);
            BindToViewModel();
        }

        private void BindToViewModel()
        {
            mvvmContextForReports.SetBinding(loginTextEdit, login => login.EditValue, "TesteeLogin");
            mvvmContextForReports.SetBinding(fromDateEdit, from => from.EditValue, "FromDate");
            mvvmContextForReports.SetBinding(toDateEdit, to => to.EditValue, "ToDate");
        }

        private ReportType ReportType = ReportType.None;

        private void reportTypeRadioGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = reportTypeRadioGroup.Properties.Items[reportTypeRadioGroup.SelectedIndex].Value;
            if (selected.ToString() == "General")
            {
                loginLayoutControlItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                ReportType = ReportType.Genaral;
            }
            else if (selected.ToString() == "ByLogin")
            {
                loginLayoutControlItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                ReportType = ReportType.ByLogin;
            }
        }

        private void previewButton_Click(object sender, EventArgs e)
        {
            if (ReportType == ReportType.Genaral || (ReportType == ReportType.ByLogin && !String.IsNullOrEmpty(model.TesteeLogin)))
            {
                model.GenerateReport(ReportType);
                model.Report.CreateDocument();
                previewReportDocument.DocumentSource = model.Report;
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
    }
}