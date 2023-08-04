using Domain_Layer.Data;
using Domain_Layer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Layer
{
    public class Repository<T> : IRepository<T> where T : baseEntity
    {
        private readonly MedicalFormDbContext context;
        private readonly DbSet<T> entities;

        public Repository(MedicalFormDbContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }

        public async Task Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            await context.SaveChangesAsync();
        }

        public async Task<T> Get(long id)
        {
            return await entities.SingleOrDefaultAsync(s => s.Id == id);
        }

        public IEnumerable<T> GetAll()
        {
           return entities.AsEnumerable();
        }

        public async Task Insert(T entity)
        {
            if(entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            await context.SaveChangesAsync();
        }

        public void Remove(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
        }

        public Task SaveChanges()
        {
            throw new NotImplementedException();
        }

        public async Task Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            await context.SaveChangesAsync();
        }
    }
}
