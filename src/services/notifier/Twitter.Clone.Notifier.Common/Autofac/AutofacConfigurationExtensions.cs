using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Twitter.Clone.Notifier.Common.Autofac
{
    public static class AutofacConfigurationExtensions
    {
        public static void AddAutofacDependencyServices(this ContainerBuilder containerBuilder)
        {
            var currentAssembly = Assembly.GetCallingAssembly();
            var assemblyFolder =Path.GetDirectoryName( currentAssembly.Location);
            var smsAssembly = Assembly.LoadFrom(assemblyFolder + "\\Twitter.Clone.Notifier.Features.Sms.dll");
            var emailAssembly = Assembly.LoadFrom(assemblyFolder + "\\Twitter.Clone.Notifier.Features.Email.dll");
          
            containerBuilder.RegisterAssemblyTypes(new[] { smsAssembly, emailAssembly })
                            .AssignableTo<IScopedDependency>()
                            .AsImplementedInterfaces()
                            .InstancePerLifetimeScope();
            containerBuilder.RegisterAssemblyTypes(new[] { smsAssembly, emailAssembly })
                            .AssignableTo<ITransientDependency>()
                            .AsImplementedInterfaces()
                            .InstancePerDependency();
            containerBuilder.RegisterAssemblyTypes(new[] { smsAssembly, emailAssembly })
                            .AssignableTo<ISingletonDependency>()
                            .AsImplementedInterfaces()
                            .SingleInstance();

        }

    }
}
