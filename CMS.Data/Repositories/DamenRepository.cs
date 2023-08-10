using CMS.Data.Commons;
using CMS.Data.DbContexts;
using CMS.Data.IRepositories;
using CMS.Domain.Entities.Domains;

namespace CMS.Data.Repositories;

public class DamenRepository : Repository<Damen>, IDamenRepository
{
    public DamenRepository(AppDbContext appDbContext) : base(appDbContext)
    {

    }
}