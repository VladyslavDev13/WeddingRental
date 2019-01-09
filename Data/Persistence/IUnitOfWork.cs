using System.Collections.Generic;
using System.Threading.Tasks;
using Data.Repositories;

namespace Data.Persistence
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository { get; }
        Task<int> CompleteAsync();

        Task<List<T>> QueryAsync<T>(string sql, object param = null);
        Task<T> QueryFirstAsync<T>(string sql, object param = null);
        Task<List<T>> StoredProcedureAsync<T>(string name, object param = null);
        Task<T> StoredProcedureFirstAsync<T>(string name, object param = null);
    }
}