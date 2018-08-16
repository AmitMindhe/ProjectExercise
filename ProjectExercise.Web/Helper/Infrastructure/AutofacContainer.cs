using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectExercise.Service;
using System.Reflection;
using System.Web.Mvc;
using Autofac.Integration.Mvc;
using Autofac;
using ProjectExercise.Data;
using Autofac.Integration.WebApi;
using System.Web.Http;
namespace ProjectExercise.Web.Helper.Infrastructure
{
    public static class ApplicationContainer
    {
        public static IContainer Container { get; set; }
    }

    public class AutofacContainer
    {
        public static void RegisterAutofacContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<DataContext>().As<IDbContext>().InstancePerLifetimeScope();

            //Generic repository
            builder.RegisterGeneric(typeof(RepositoryService<>)).As(typeof(IRepository<>));

            //register all other classes
            builder.RegisterType<ContactService>().As<IContactService>().InstancePerLifetimeScope();
            builder.RegisterType<ProjectUserService>().As<IProjectUserService>().InstancePerLifetimeScope();
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            IContainer container = builder.Build();
           DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver =
                 new AutofacWebApiDependencyResolver(container);
            ApplicationContainer.Container = container;
        }
    }
}
