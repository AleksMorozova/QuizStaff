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

        static void Main(string[] args)
        {
            if (applicationServiceHost != null)
            {
                applicationServiceHost.Close();
            }
            applicationServiceHost = new ServiceHost(typeof(ApplicationServer));
            applicationServiceHost.Open();

            dbContext = new QuizDBContext();

            Console.WriteLine("Press <Enter> to stop the service.");
            Console.ReadLine();


            applicationServiceHost.Close();
        }
    }
}
