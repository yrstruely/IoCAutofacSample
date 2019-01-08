using Autofac;
using IoCAutofacSample;

namespace DateApp
{
    class Program
    {
        private static IContainer Container { get; set; }

        static void Main(string[] args)
        {
            var containerBuilder = new ContainerBuilder();

            containerBuilder.RegisterType<ConsoleOutput>().As<IOutput>();
            containerBuilder.RegisterType<TodayWriter>().As<IDateWriter>();

            Container = containerBuilder.Build();

            WriteDate();
        }

        public static void WriteDate()
        {
            using (var scope = Container.BeginLifetimeScope())
            {
                var dateWriter = scope.Resolve<IDateWriter>();

                dateWriter.WriteDate();
            }
        }
    }
}
