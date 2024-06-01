using Autofac;
using AutofacDemo.DemoLibrary;
using System.Linq;
using System.Reflection;

namespace AutofacDemo
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<BusinessLogic>().As<IBusinessLogic>();
            builder.RegisterAssemblyTypes(Assembly.Load(nameof(AutofacDemo) +"."+nameof(DemoLibrary)))
                .Where(t=>t.Namespace.Contains("Utilities"))
                .As(t=>t.GetInterfaces().FirstOrDefault(i=>i.Name=="I"+t.Name));
            return builder.Build();
        }
    }
}
