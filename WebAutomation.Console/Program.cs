using System;
using Autofac;
using WebAutomationFramework.Broswer;

namespace WebAutomation.Console
{
    class Program
    {
        private IContainer _container;

        static void Main(string[] args)
        {
            new Program().Run();
        }

        public void Run()
        {
            BuildContainer();

            using (var scope = _container.BeginLifetimeScope())
            {
                var chrome = scope.Resolve<Chrome>();
                chrome.GoToUrl();
            }
        }

        private void BuildContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterAssemblyModules(AppDomain.CurrentDomain.GetAssemblies());
            _container = builder.Build();
        }
    }
}
