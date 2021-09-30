

using Repository.ModelBase;

namespace Service.Data
{
    public interface IRepositoryReadOnly<T> : IReadRepository<T> where T : Entity
    {
       
    }
}