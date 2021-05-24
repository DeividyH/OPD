using OPD.Application.Dtos.Custumers;
using System.Collections;

namespace OPD.Application.Interfaces.Custumers
{
    public interface IApplicationServiceCustumer
    {
        void Create(CustumerDto custumerDto);

        void Update(CustumerDto custumerDto);
        
        void Delete(CustumerDto custumerDto);
        
        IEnumerable GetAll();

        CustumerDto GetById(int id);
    }
}
