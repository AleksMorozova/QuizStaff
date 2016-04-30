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

        public void OpenChildForm(System.Windows.Forms.Form formToOpen, string text)
        {
            formToOpen.MdiParent = Program.ApplicationMainForm;
            formToOpen.Text = text;
            formToOpen.Show();
            formToOpen.Activate();
        }
    }
}
