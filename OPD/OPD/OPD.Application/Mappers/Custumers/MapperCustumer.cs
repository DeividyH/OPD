using OPD.Application.Dtos.Custumers;
using OPD.Application.Interfaces.Mappers.Custumers;
using OPD.Domain.Entities.Custumers;
using System.Collections.Generic;
using System.Linq;

namespace OPD.Application.Mappers.Custumers
{
    public class MapperCustumer : IMapperCustumer
    {
        public Custumer MapperDtoToEntity(CustumerDto custumerDto)
        {
            return new Custumer()
            {
                Id = custumerDto.Id,
                Name = custumerDto.Name,
                Surname = custumerDto.Surname,
                Email = custumerDto.Email,
                Birthdate = custumerDto.Birthdate,
                IsActive = custumerDto.IsActive
            };
        }

        public CustumerDto MapperEntityToDto(Custumer custumer)
        {
            return new CustumerDto()
            {
                Id = custumer.Id,
                Name = custumer.Name,
                Surname = custumer.Surname,
                Email = custumer.Email,
                Birthdate = custumer.Birthdate,
                IsActive = custumer.IsActive
            };
        }

        public IEnumerable<CustumerDto> MapperListCustumerDto(IEnumerable<Custumer> custumers)
        {

            var dto = custumers.Select(x => new CustumerDto
            {
                Id = x.Id,
                Name = x.Name,
                Surname = x.Surname,
                Email = x.Email,
                Birthdate = x.Birthdate,
                IsActive = x.IsActive
            });

            return dto;
        }
    }
}
