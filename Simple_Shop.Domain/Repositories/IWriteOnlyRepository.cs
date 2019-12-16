using Simple_Shop.Domain.DataModels;
using System.Threading.Tasks;

namespace Simple_Shop.Domain.Repositories
{
    public interface IWriteOnlyRepository
    {
        Task InsertAsync<T>(T entity) where T : BaseDTO;
    }
}
