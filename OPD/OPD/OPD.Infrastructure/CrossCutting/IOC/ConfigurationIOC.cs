using Autofac;
using OPD.Application.Applications.Custumers;
using OPD.Application.Applications.Products;
using OPD.Application.Interfaces.Custumers;
using OPD.Application.Interfaces.Mappers.Custumers;
using OPD.Application.Interfaces.Mappers.Products;
using OPD.Application.Interfaces.Products;
using OPD.Application.Mappers.Custumers;
using OPD.Application.Mappers.Products;
using OPD.Domain.Core.Interfaces.Repositories.Custumers;
using OPD.Domain.Core.Interfaces.Repositories.Products;
using OPD.Domain.Core.Interfaces.Services.Custumers;
using OPD.Domain.Core.Interfaces.Services.Products;
using OPD.Domain.Services.Custumers;
using OPD.Domain.Services.Products;
using OPD.Infrastructure.Data.Repositories.Custumers;
using OPD.Infrastructure.Data.Repositories.Products;

namespace OPD.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder build)
        {
            #region IOC 

            build.RegisterType<ApplicationServiceCustumer>().As<IApplicationServiceCustumer>();
            build.RegisterType<ApplicationServiceProduct>().As<IApplicationServiceProduct>();
            
            build.RegisterType<MapperCustumer>().As<IMapperCustumer>();
            build.RegisterType<MapperProduct>().As<IMapperProduct>();

            build.RegisterType<ServiceCustumer>().As<IServiceCustumer>();
            build.RegisterType<ServiceProduct>().As<IServiceProduct>();

            build.RegisterType<RepositoryCustumer>().As<IRepositoryCustumer>();
            build.RegisterType<RepositoryProduct>().As<IRepositoryProduct>();

            #endregion
        }
    }
}
