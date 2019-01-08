using Autofac;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IoCAutofacSample
{
    [TestClass]
    public class DateAppTests
    {
        private static IContainer Container { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            var containerBuilder = new ContainerBuilder();

            containerBuilder.RegisterType<ConsoleOutput>().As<IOutput>();
            containerBuilder.RegisterType<TodayWriter>().As<IDateWriter>();

            Container = containerBuilder.Build();
        }

        [TestMethod]
        public void IDateWriterComponent_Should_WriteTodaysDate()
        {
            using (var scope = Container.BeginLifetimeScope())
            {
                var dateWriter = scope.Resolve<IDateWriter>();
                dateWriter.WriteDate();
            }
        }
    }
}
