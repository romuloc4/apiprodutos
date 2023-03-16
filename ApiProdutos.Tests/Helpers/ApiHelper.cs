using ApiProdutos.Services.Mappings;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProdutos.Tests.Helpers
{
    public class ApiHelper
    {
        /// <summary>
        /// Retorna o dendereço do servidor de testes da API
        /// </summary>
        public static string Endpoint
        {
            get => "http://apiprodutosro-001-site1.ftempurl.com/api";
        }

        /// <summary>
        /// Criando um conteúdo JSON para envio na requisição da API
        /// </summary>
        /// <param name="request">Objeto que srá enviado na requisição</param>
        /// <returns>Conteúdo da requisição em JSON</returns>
        public static StringContent CreateContent<TRequest>(TRequest request)
           where TRequest : class
        {
            return new StringContent(JsonConvert.SerializeObject(request),
                Encoding.UTF8, "application/json");
        }

        public static TResponse CreateResponse<TResponse>(HttpResponseMessage message)
            where TResponse : class
        {
            return JsonConvert.DeserializeObject<TResponse>
                (message.Content.ReadAsStringAsync().Result);
        }
    }
}
