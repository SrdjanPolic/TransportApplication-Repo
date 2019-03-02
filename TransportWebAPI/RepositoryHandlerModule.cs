using Autofac;
using DBLayerPOC.Infrastructure;
using Service.Data;

namespace TransportWebAPI
{
    public class RepositoryHandlerModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //builder.RegisterType <Repository<T>>()
            //    .As<IRepository<T>>()
            //    .InstancePerLifetimeScope()  where T : class;
            builder.RegisterGeneric(typeof(Repository<>))
                    .As(typeof(IRepository<>)).InstancePerLifetimeScope();

            builder.RegisterGeneric(typeof(UnitOfWork<>))
                    .As(typeof(IUnitOfWork<>)).InstancePerLifetimeScope();
        }
    }
}
