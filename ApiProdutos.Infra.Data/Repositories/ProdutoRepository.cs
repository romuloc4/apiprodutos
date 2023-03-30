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
    /// <summary>
    /// Classe de repositorio pra produto
    /// </summary>
    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {
        //atributo
        private readonly SqlServerContext _sqlServerContext;

        //contrutor pra inicializar o atibuto
        public ProdutoRepository(SqlServerContext sqlServerContext)
            : base (sqlServerContext)
        {
            _sqlServerContext = sqlServerContext;
        }
    }
}
