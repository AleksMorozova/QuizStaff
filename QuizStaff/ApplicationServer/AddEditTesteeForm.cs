using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DomainModel;

namespace ApplicationServer
{
    public partial class AddEditTesteeForm : Form
    {
        private Testee currentUser;
        public AddEditTesteeForm(Testee currentTestee)
        {
            InitializeComponent();
            this.currentUser = currentTestee; 
        }
    }
}
