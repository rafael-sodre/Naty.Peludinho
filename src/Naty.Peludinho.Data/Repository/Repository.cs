using Microsoft.EntityFrameworkCore;
using Naty.Peludinho.Business.Interfaces;
using Naty.Peludinho.Business.Models;
using Naty.Peludinho.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Naty.Peludinho.Data.Repository
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity, new() 
    {

        protected readonly NatyPeludinhoDbContext Db;
        protected readonly DbSet<TEntity> DbSet;

        public Repository(NatyPeludinhoDbContext db)
        {
            Db = db;
            DbSet = db.Set<TEntity>();

        }
        
        public async Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return await DbSet.AsNoTracking().Where(predicate).ToListAsync();
        }

        public virtual async Task<TEntity> GetById(Guid id)
        {
            return await DbSet.FindAsync(id);
        }

        public virtual async Task<List<TEntity>> GetAll()
        {
            return await DbSet.ToListAsync();
        }

        public virtual async Task Add(TEntity entity)
        {
            DbSet.Add(entity);
            await SaveChanges();
        }
        public virtual async Task Update(TEntity T)
        {
            DbSet.Update(T);
            await SaveChanges();
               
        }

        public virtual async Task Remove(Guid id)
        {
            DbSet.Remove(new TEntity { Id = id });
            await SaveChanges();
        }

        public async Task<int> SaveChanges()
        {
            return await Db.SaveChangesAsync();
        }

        public virtual async void Dispose()
        {
            Db?.Dispose();
        }
    }
}
