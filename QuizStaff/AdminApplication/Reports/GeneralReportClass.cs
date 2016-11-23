using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminApplication.Reports
{
    public class GeneralReportClass
    {
        public string Company { get; set; }
        public string Office { get; set; }
        public string Location { get; set; }
        public string Login { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Sectore { get; set; }
        public string Devision { get; set; }
        public string Department { get; set; }
        public string Profession { get; set; }
        public string Title { get; set; }
        public string Position { get; set; }
        public string Role { get; set; }
        public string Manager { get; set; }
        public string HireDate { get; set; }
        public string ComercialExp { get; set; }
        public string ISDExp { get; set; }

        public int QuestionAmount { get; set; }
        public int Correct { get; set; }
        public int Wrong { get; set; }
    }
}
