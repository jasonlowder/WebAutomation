using Autofac;
using WebAutomationFramework.Interfaces;

namespace Chase
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ChaseBrowserDriver>().As<IBrowserDriver>();
        }
    }
}
