using System.Linq.Expressions;
using InventorySystemAPI.Persistence;
using InventorySystemAPI.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace InventorySystemAPI.Repositories;

public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
{
    private ApplicationDbContext? ApplicationDbContext { get; set; }

    protected RepositoryBase(ApplicationDbContext applicationDbContext)
    {
        ApplicationDbContext = applicationDbContext;
    }

    public IQueryable<T> FindAll(bool trackChanges)
    => !trackChanges
        ? ApplicationDbContext!.Set<T>().AsNoTracking()
        : ApplicationDbContext!.Set<T>();

    public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges)
    => !trackChanges
        ? ApplicationDbContext!.Set<T>().Where(expression).AsNoTracking()
        : ApplicationDbContext!.Set<T>().Where(expression);

    public void Create(T entity)
    {
        ApplicationDbContext!.Set<T>().Add(entity);
    }

    public void Update(T entity)
    => ApplicationDbContext!.Set<T>().Update(entity);

    public void Delete(T entity)
    => ApplicationDbContext!.Set<T>().Remove(entity);
}