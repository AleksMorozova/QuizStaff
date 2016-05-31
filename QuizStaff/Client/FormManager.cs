using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class FormManager
    {
        public static FormManager Instance { get { return new FormManager();}}


        public FormManager() 
        {
            if (childForms == null)
            childForms = new List<System.Windows.Forms.Form>();
        }

        public static List<System.Windows.Forms.Form> childForms;
        public void OpenChildForm(System.Windows.Forms.Form formToOpen, string text)
        {
            formToOpen.MdiParent = Program.ApplicationMainForm;
            formToOpen.Text = text;
            formToOpen.Show();
            formToOpen.Activate();
        }

        public void LocalizedForms(string language) 
        {
            foreach (ILocalized form in childForms)
            {
                form.Localized(language);
            }
        }
    }
}
