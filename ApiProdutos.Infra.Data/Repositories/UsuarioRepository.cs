using ApiProdutos.Infra.Data.Contexts;
using ApiProdutos.Infra.Data.Entities;
using ApiProdutos.Infra.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProdutos.Infra.Data.Repositories
{
    public class UsuarioRepository : BaseRepository<Produto>, IUsuarioRepository
    {
        //atributo
        private readonly SqlServerContext _sqlServerContext;

        //construtor para inicializar o atributo
        public UsuarioRepository(SqlServerContext sqlServerContext)
            : base(sqlServerContext)
        {
            _sqlServerContext = sqlServerContext;
        }

        public void Add(Usuario entity)
        {
            _sqlServerContext.Usuario.Add(entity);
            _sqlServerContext.SaveChanges();
        }

        public void Update(Usuario entity)
        {
            _sqlServerContext.Entry(entity).State = EntityState.Modified;
            _sqlServerContext.SaveChanges();
        }

        public void Delete(Usuario entity)
        {
            _sqlServerContext.Usuario.Remove(entity);
            _sqlServerContext.SaveChanges();
        }

        public List<Usuario> GetAll()
        {
            return _sqlServerContext.Usuario.ToList();
        }

        public Usuario Get(Guid id)
        {
            return _sqlServerContext.Usuario.Find(id);
        }

        public Usuario Get(string login, string senha)
        {
            return _sqlServerContext.Usuario
                 .FirstOrDefault(u => u.Login.Equals(login)
                                     && u.Senha.Equals(senha));
        }
    }
}
