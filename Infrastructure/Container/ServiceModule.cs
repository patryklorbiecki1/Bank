using Autofac;
using Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Container
{
    public class ServiceModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var assembly = typeof(ServiceModule).GetType().Assembly;
            builder.RegisterAssemblyTypes(assembly).Where(x => x.IsAssignableTo<IService>())
                .AsImplementedInterfaces().InstancePerLifetimeScope();

        }
    }
}
