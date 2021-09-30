

using Repository.ModelBase;

namespace Service.Data
{
    public interface IRepositoryFactory
    {
        IRepository<T> GetRepository<T>() where T : Entity;
        //IRepositoryAsync<T> GetRepositoryAsync<T>() where T : class;
        IRepositoryReadOnly<T> GetReadOnlyRepository<T>() where T : Entity;
    }
}