using Simple_Shop.Domain.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace Simple_Shop.Domain.Repositories
{
    public interface IReadOnlyRepository
    {
        Task<T> FindSingleAsync<T>(Expression<Func<T, bool>> predicate, CancellationToken token = default) where T : BaseDTO;
        IAsyncEnumerable<T> FindByAsync<T>(Expression<Func<T, bool>> predicate, CancellationToken token = default) where T : BaseDTO;
        IQueryable<T> GetAll<T>() where T : BaseDTO;
        int Count<T>() where T : BaseDTO;
    }
}
