using Microsoft.EntityFrameworkCore;
using Simple_Shop.Data.Contexts;
using Simple_Shop.Domain.DataModels;
using Simple_Shop.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Simple_Shop.Data.Repositories
{
    public class Repository : IRepository
    {
        private readonly AppDbContext context;

        public Repository(AppDbContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Returns results based on a given predicate.
        /// Streams the results as a sequence.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public async IAsyncEnumerable<T> FindByAsync<T>(Expression<Func<T, bool>> predicate, [EnumeratorCancellation] CancellationToken token = default) 
            where T : BaseDTO
        {
            var entities = context.Set<T>()
                .Where(predicate)
                .AsAsyncEnumerable()
                .ConfigureAwait(false);

            await foreach (var entity in entities)
            {
                yield return entity;
            }
        }

        /// <summary>
        /// Finds a single entity given some predicate.
        /// Will throw an exception if more than 1 is found.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public async Task<T> FindSingleAsync<T>(Expression<Func<T, bool>> predicate, CancellationToken token = default)
            where T : BaseDTO
        {
            return await context.Set<T>()
                .SingleAsync(predicate)
                .ConfigureAwait(false);
        }

        /// <summary>
        /// Returns a queryable collection of all entities.
        /// Use with care! If .ToList() is called on the set without a filter, 
        /// the entirety of the dataset will be pulled into memory.
        /// </summary>
        /// <returns></returns>
        public IQueryable<T> GetAll<T>()
            where T : BaseDTO
        {
            return context.Set<T>().AsQueryable();
        }

        public async Task InsertAsync<T>(T entity) where T : BaseDTO
        {
            await context.Set<T>().AddAsync(entity).ConfigureAwait(false);
            await context.SaveChangesAsync();
        }

        public int Count<T>()
            where T : BaseDTO
        {
            return context.Set<T>().Count();
        }
    }
}
