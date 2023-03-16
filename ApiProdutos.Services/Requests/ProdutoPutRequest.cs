using System.ComponentModel.DataAnnotations;

namespace ApiProdutos.Services.Requests
{
    /// <summary>
    /// Modelo de dados para servico de edição de dados
    /// </summary>
    public class ProdutoPutRequest
    {
        [Required(ErrorMessage = "Campo brigatório.")]
        public Guid IdProduto { get; set; }

        [Required(ErrorMessage = "Campo brigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo brigatório.")]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "Campo brigatório.")]
        public int Quantidade { get; set; }

    }
}
