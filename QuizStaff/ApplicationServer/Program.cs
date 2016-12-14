using ApplicationServer.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServer
{
    class Program
    {
        internal static ServiceHost applicationServiceHost = null;
        static void Main(string[] args)
        {
            if (applicationServiceHost != null)
            {
                applicationServiceHost.Close();
            }
            applicationServiceHost = new ServiceHost(typeof(ApplicationServer));
            applicationServiceHost.Open();
            //using (var db = new QuizDBContext())
            //{
            //    // Display all Blogs from the database 
            //    var query = from b in db.Testees
            //                orderby b.Login
            //                select b;
            //}
           // System.Data.Entity.Database.SetInitializer(new DropCreateDatabaseIfModelChanges<QuizDBContext>());
            using (var context = new QuizDBContext())
            {
                context.Database.Initialize(force: true);
                //    var query = from b in db.Testees
                //                orderby b.Login
                //                select b;
            }

            Console.WriteLine("Press <Enter> to stop the service.");
            Console.ReadLine();

            

            applicationServiceHost.Close();
        }
    }
}
