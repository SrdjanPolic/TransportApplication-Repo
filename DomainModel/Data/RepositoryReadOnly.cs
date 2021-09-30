using Microsoft.EntityFrameworkCore;
using Repository.ModelBase;

namespace Service.Data
{
    public class RepositoryReadOnly<T> : BaseRepository<T>, IRepositoryReadOnly<T> where T : Entity
    {
        public RepositoryReadOnly(DbContext context) : base(context)
        {
        }
    }
}