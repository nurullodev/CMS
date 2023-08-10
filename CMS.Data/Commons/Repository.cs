using CMS.Data.DbContexts;
using CMS.Data.ICommons;
using CMS.Domain.Commons;
using Microsoft.EntityFrameworkCore;

namespace CMS.Data.Commons;

public class Repository<T> : IRepository<T> where T : Auditable
{
    private readonly AppDbContext _appDbContext;
    private readonly DbSet<T> dbSet;
    public Repository(AppDbContext appDbContext)
    {
        this._appDbContext = appDbContext;
        this.dbSet = this._appDbContext.Set<T>();
    }

    public async Task AddAsync(T entity)
    {
        await this.dbSet.AddAsync(entity);
    }

    public void Update(T entity)
    {
        this._appDbContext.Entry(entity).State = EntityState.Modified;
    }

    public void Delete(T entity)
    {
        this.dbSet.Remove(entity);
    }

    public async Task<T> SelectByIdAsync(long id)
        => await dbSet.FirstOrDefaultAsync(t => t.Id.Equals(id));

    public IQueryable<T> SelectAll()
         => this.dbSet.AsNoTracking().AsNoTracking().AsQueryable();
}