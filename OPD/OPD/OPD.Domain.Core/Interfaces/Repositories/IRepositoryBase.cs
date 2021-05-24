using System.Collections.Generic;

namespace OPD.Domain.Core.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Create(TEntity obj);
        
        void Update(TEntity obj);
        
        void Delete(TEntity obj);

        IEnumerable<TEntity> GetAll();
        
        TEntity GetById(int id);
    }
}
