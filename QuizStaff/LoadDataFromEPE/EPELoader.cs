using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadDataFromEPE
{
    public static class EPELoader
    {
        public static List<Testee> LoadTesteeFromEPE()
        {
            List<Testee> loadedTesteess = new List<Testee>();
            var service = new EPEServiceReference.IsdDataWebServiceSoapClient();
            var testees = service.GetIsdEmployeeOfficeData();

            for (int i = 0; i < testees.Tables[0].Rows.Count; i++)
            {
                Testee newTestee = new Testee();
                newTestee.Attribute1 = testees.Tables[0].Rows[i]["Company"].ToString();
                newTestee.Attribute2 = testees.Tables[0].Rows[i]["OfficeLoc"].ToString();
                newTestee.Login = testees.Tables[0].Rows[i]["Login"].ToString();
                newTestee.LastName = testees.Tables[0].Rows[i]["LastName"].ToString();
                newTestee.FirstName = testees.Tables[0].Rows[i]["FirstName"].ToString();
                newTestee.Attribute3 = testees.Tables[0].Rows[i]["Sector"].ToString();
                newTestee.Attribute4 = testees.Tables[0].Rows[i]["Division"].ToString();
                newTestee.Attribute5 = testees.Tables[0].Rows[i]["Department"].ToString();
                newTestee.Attribute6 = testees.Tables[0].Rows[i]["Profession"].ToString();
                newTestee.Attribute7 = testees.Tables[0].Rows[i]["Title"].ToString();
                newTestee.Attribute8 = testees.Tables[0].Rows[i]["Position"].ToString();
                newTestee.Attribute9 = testees.Tables[0].Rows[i]["Role"].ToString();
                newTestee.Attribute10 = testees.Tables[0].Rows[i]["Manager"].ToString();
                newTestee.Attribute11 = testees.Tables[0].Rows[i]["HireDate"].ToString();
                newTestee.Attribute12 = testees.Tables[0].Rows[i]["Com_Exp"].ToString();
                newTestee.Attribute13 = testees.Tables[0].Rows[i]["ISD_Exp"].ToString();

                loadedTesteess.Add(newTestee);
            }

            return loadedTesteess;
        }
    }
}
