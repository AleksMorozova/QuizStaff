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
using System.Timers;

namespace ApplicationServer
{
    class Program
    {
        private static Timer timer = new Timer();
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
            StartTimer();
            applicationServiceHost.Close();
        }

        private static void StartTimer()
        {
            timer.Interval = 100;
            timer.Elapsed += new ElapsedEventHandler(timer_Tick);
            timer.Start();
        }

        private static void timer_Tick(object sender, ElapsedEventArgs e)
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Thursday && (DateTime.Now.Hour == 20 || DateTime.Now.Hour == 8))
                ApplicationServer.UpdateInformation();
        }
    }
}
