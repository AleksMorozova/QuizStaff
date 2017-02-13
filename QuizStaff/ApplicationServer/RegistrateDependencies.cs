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

        public static IRoleService RoleService
        {
            get
            {
                return container.Resolve<IRoleService>();
            }
        }

        public static ILoaderService LoaderService
        {
            get
            {
                return container.Resolve<ILoaderService>();
            }
        }

        public static ITesteeSettingsService TesteeSettingsService
        {
            get
            {
                return container.Resolve<ITesteeSettingsService>();
            }
        }

        public static IHistoryService HistoryService
        {
            get
            {
                return container.Resolve<IHistoryService>();
            }
        }

        public static ITesteeTrainingService TesteeTrainingService
        {
            get
            {
                return container.Resolve<ITesteeTrainingService>();
            }
        }

        static void Registrate()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<TrainingService>().As<ITrainingService>();
            builder.RegisterType<TesteeService>().As<ITesteeService>();
            builder.RegisterType<QuestionService>().As<IQuestionService>();
            builder.RegisterType<RoleService>().As<IRoleService>();
            builder.RegisterType<LoaderService>().As<ILoaderService>();
            builder.RegisterType<TesteeSettingsService>().As<ITesteeSettingsService>();
            builder.RegisterType<HistoryService>().As<IHistoryService>();
            builder.RegisterType<TesteeTrainingService>().As<ITesteeTrainingService>();
            builder.RegisterType<ApplicationSettingsService>().As<IApplicationSettingsService>();

            container = builder.Build();
        }
    }
}
