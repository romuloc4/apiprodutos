using System.ComponentModel.DataAnnotations;

namespace ApiProdutos.Services.Requests
{
    /// <summary>
    /// Modelo de dados para o servico de cadastro de produto
    /// </summary>
    public class ProdutoPostRequest
    {
        [Required(ErrorMessage = "Campo brigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo brigatório.")]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "Campo brigatório.")]
        public int Quantidade { get; set; }
    }
}
