using System.Linq.Expressions;

namespace InventorySystemAPI.Repositories.IRepositories;

public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
{
    
    
    public IQueryable<T> FindAll(bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public void Create(T entity)
    {
        throw new NotImplementedException();
    }

    public void Update(T entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(T entity)
    {
        throw new NotImplementedException();
    }
}