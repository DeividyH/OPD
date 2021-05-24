using OPD.Application.Dtos.Custumers;
using OPD.Domain.Entities.Custumers;
using System.Collections.Generic;

namespace OPD.Application.Interfaces.Mappers.Custumers
{
    public interface IMapperCustumer
    {
        Custumer MapperDtoToEntity(CustumerDto custumerDto);

        IEnumerable<CustumerDto> MapperListCustumerDto(IEnumerable<Custumer> custumers);

        CustumerDto MapperEntityToDto(Custumer custumer);
    }
}
