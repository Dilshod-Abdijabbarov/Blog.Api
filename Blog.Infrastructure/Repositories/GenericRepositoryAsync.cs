using Blog.Domain;
using Blog.Infrastructure.Context;
using Blog.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Infrastructure.Repositories
{
    public class GenericRepositoryAsync<T> : IGenericRepositoryAsync<T> where T:class
    {
        private readonly ApplicationDbContext _context;

        public GenericRepositoryAsync(ApplicationDbContext context)
        {
            _context = context;
        }

        public virtual async  Task<T> AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);

            await SaveChangesAsync();

            return entity;
        }

        public virtual async  Task DeleteAsync(int id)
        {
            var user= await _context.Set<T>().FindAsync(id);

            _context.Set<T>().Remove(user);

            await SaveChangesAsync();

        }

        public virtual async  Task<IReadOnlyList<T>> GetAllAsync()
        {

           return  await _context.Set<T>().ToListAsync();

        }

        public virtual async  Task<T> GetByidAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public virtual async  Task<IReadOnlyList<T>> GetPagedListAsync(int pageNuber, int pageSize)
        {
            return await _context.Set<T>()
                .Skip((pageNuber - 1) * pageSize)
                .Take(pageSize)
                .AsNoTracking()
                .ToListAsync();
        }

        public virtual async  Task<T> UpdateAsync(T entity)
        {
            

            _context.Entry(entity).State = EntityState.Modified;

            await SaveChangesAsync();

            return entity;
         
        }


        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() >= 0;
        }
    }
}
