using CoffeeMaker.DataAccess.Interfaces;
using CoffeeMaker.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoffeeMaker.DataAccess.Repositories
{
    public class BaseRepository<TEntity, TContext> : IBaseRepository<TEntity>
        where TEntity : BaseModel
        where TContext : DbContext
    {
        private readonly TContext _context;
        public BaseRepository(TContext context)
        {
            _context = context?? throw new ArgumentNullException(nameof(context)); ;
        }
        public async Task<TEntity> Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> Delete(int id)
        {
            var entity = await _context.Set<TEntity>().FindAsync(id);
            if (entity == null)
            {
                return entity;
            }

            _context.Set<TEntity>().Remove(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<TEntity> Get(int id) => 
            await _context.Set<TEntity>().FindAsync(id);

        public async Task<List<TEntity>> GetAll() 
            => await _context.Set<TEntity>().ToListAsync();

        public async Task<TEntity> Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
