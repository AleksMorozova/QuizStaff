using Autofac;
using Services.Contracts;
using Services.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizServer
{
    static class RegistrateDependencies
    {
        static IContainer container;

        static RegistrateDependencies()
        {
            Registrate();
        }

        public static ITrainingService TrainingService
        {
            get
            {
                return container.Resolve<ITrainingService>();
            }
        }

        public static ITesteeService TesteeService
        {
            get
            {
                return container.Resolve<ITesteeService>();
            }
        }

        public static IQuestionService QuestionService
        {
            get
            {
                return container.Resolve<IQuestionService>();
            }
        }

        public static IApplicationSettingsService ApplicationSettingsService
        {
            get
            {
                return container.Resolve<IApplicationSettingsService>();
            }
        }

        static void Registrate()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<TrainingService>().As<ITrainingService>();
            builder.RegisterType<TesteeService>().As<ITesteeService>();
            builder.RegisterType<QuestionService>().As<IQuestionService>();
            builder.RegisterType<ApplicationSettingsService>().As<IApplicationSettingsService>();

            container = builder.Build();
        }
    }
}
