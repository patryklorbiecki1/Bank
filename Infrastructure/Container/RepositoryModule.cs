using Autofac;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Infrastructure.Container
{
    public class RepositoryModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var assembly = typeof(RepositoryModule).GetTypeInfo().Assembly;
            builder.RegisterAssemblyTypes(assembly).Where(x => x.IsAssignableTo<IRepository>()).AsImplementedInterfaces().InstancePerLifetimeScope();
        }
    }
}
