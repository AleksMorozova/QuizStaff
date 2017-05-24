using DAL;
using Services.Contracts;
using Services.Implementation;
using System;
using System.Collections.Generic;
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
        public static QuizDBContext dbContext;
        static string connection = @"Data Source = ihrbot.isd.dp.ua, 5000; Initial Catalog = DAL.QuizDBContext; Integrated Security = True; MultipleActiveResultSets=True";
        static void Main(string[] args)
        {
            if (applicationServiceHost != null)
            {
                applicationServiceHost.Close();
            }
            applicationServiceHost = new ServiceHost(typeof(ApplicationServer));
            applicationServiceHost.Open();

            dbContext = new QuizDBContext(connection);

            Console.WriteLine("Press <Enter> to stop the service.");
            Console.ReadLine();


            applicationServiceHost.Close();
        }

        public static void WriteInf(string message)
        {
            Console.WriteLine(message);
        }

    }
}
