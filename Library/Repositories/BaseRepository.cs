using Library.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Library.Repositories
{
    public class BaseRepository<T>
         where T : BaseEntity
    {
        protected LibraryDbContext Context;
        protected DbSet<T> Items;

        public BaseRepository(LibraryDbContext context)
        {
            Context = context;
            Items = Context.Set<T>();
        }

        public void Save(T item)
        {
            if (item.Id != Guid.Empty)
                Items.Update(item);
            else
                Items.Add(item);

            Context.SaveChanges();
        }

        public void Delete(T item)
        {
            Items.Remove(item);
            Context.SaveChanges();
        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> filter = null)
        {
            IQueryable<T> query = Items;

            if (filter != null)
                query = query.Where(filter);

            return query.FirstOrDefault();
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter = null, Expression<Func<T, object>> orderBy = null, int page = 1, int itemsPerPage = Int32.MaxValue)
        {
            IQueryable<T> query = Items;

            if (filter != null)
                query = query.Where(filter);

            if (orderBy != null)
                query = query.OrderByDescending(orderBy);

            return query
                .Skip(itemsPerPage * (page - 1))
                .Take(itemsPerPage)
                .ToList();
        }

        public int Count(Expression<Func<T, bool>> filter = null)
        {
            IQueryable<T> query = Items;

            if (filter != null)
                query = query.Where(filter);

            return query.Count();
        }
    }
}
