using ApiProdutos.Infra.Data.Contexts;
using ApiProdutos.Infra.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProdutos.Infra.Data.Repositories
{
    /// <summary>
    /// Classe gnérica para implementar o repositorio
    /// </summary>
    public class BaseRepository<TEntity> : IBaseRepository<TEntity>
        where TEntity : class
    {
        private readonly SqlServerContext _sqlServerContext;

        public BaseRepository(SqlServerContext sqlServerContext)
        {
            _sqlServerContext = sqlServerContext;
        }

        public void Add(TEntity entity)
        {
            _sqlServerContext.Entry(entity).State = EntityState.Added;
            _sqlServerContext.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            _sqlServerContext.Entry(entity).State = EntityState.Modified;
            _sqlServerContext.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            _sqlServerContext.Entry(entity).State = EntityState.Deleted;
            _sqlServerContext.SaveChanges();
        }

        public List<TEntity> GetAll()
        {
            return _sqlServerContext.Set<TEntity>().ToList();
        }

        public TEntity Get(Guid id)
        {
            return _sqlServerContext.Set<TEntity>().Find(id);
        }
    }
}
