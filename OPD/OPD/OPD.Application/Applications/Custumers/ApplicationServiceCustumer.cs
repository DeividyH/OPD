using OPD.Application.Dtos.Custumers;
using OPD.Application.Interfaces.Custumers;
using OPD.Application.Interfaces.Mappers.Custumers;
using OPD.Domain.Core.Interfaces.Services.Custumers;
using System.Collections;

namespace OPD.Application.Applications.Custumers
{
    public class ApplicationServiceCustumer : IApplicationServiceCustumer
    {
        private readonly IServiceCustumer _serviceCustumer;
        private readonly IMapperCustumer _mapperCustumer;

        public ApplicationServiceCustumer(IServiceCustumer serviceCustumer,
                                          IMapperCustumer mapperCustumer)
        {
            _serviceCustumer = serviceCustumer;
            _mapperCustumer = mapperCustumer;
        }

        public void Create(CustumerDto custumerDto)
        {
            var custumer = _mapperCustumer.MapperDtoToEntity(custumerDto);
            _serviceCustumer.Create(custumer);
        }
      
        public void Update(CustumerDto custumerDto)
        {
            var custumer = _mapperCustumer.MapperDtoToEntity(custumerDto);
            _serviceCustumer.Update(custumer);
        }

        public void Delete(CustumerDto custumerDto)
        {
            var custumer = _mapperCustumer.MapperDtoToEntity(custumerDto);
            _serviceCustumer.Delete(custumer);
        }

        public IEnumerable GetAll()
        {
            var custumers = _serviceCustumer.GetAll();

            return _mapperCustumer.MapperListCustumerDto(custumers);
        }

        public CustumerDto GetById(int id)
        {
            var custumer = _serviceCustumer.GetById(id);

            return _mapperCustumer.MapperEntityToDto(custumer);
        }

    }
}
