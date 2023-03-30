using ApiProdutos.Services.Requests;
using ApiProdutos.Services.Responses;
using ApiProdutos.Tests.Helpers;
using Bogus;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ApiProdutos.Tests.TestCases
{
    public class LoginTest
    {
        private readonly HttpClient _httpClient;

        public LoginTest()
        {
            _httpClient = new HttpClient();
        }

        [Fact]
        public async Task<LoginGetResponse> Post_Login_Returns_Ok()
        {
            #region Criando os dados da requisição

            var request = new LoginPostRequest
            {
                Login = "test2022",
                Senha = "@test2022"
            };

            #endregion

            #region Executando o serviço da API e capturando a resposta

            var result = await _httpClient.PostAsync
                ($"{ApiHelper.Endpoint}/Login", ApiHelper.CreateContent(request));

            var response = ApiHelper.CreateResponse<LoginGetResponse>(result);

            #endregion

            #region Validando o resultado do teste

            result.StatusCode.Should().Be(HttpStatusCode.OK);

            #endregion

            return response;
        }

        [Fact]
        public async Task Post_Login_Unathorized()
        {
            #region Criando os dados da requisição

            var request = new LoginPostRequest
            {
                Login = "testABC",
                Senha = "@testABC"
            };

            #endregion

            #region Executando o serviço da API e capturando a resposta

            var result = await _httpClient.PostAsync
                ($"{ApiHelper.Endpoint}/Login", ApiHelper.CreateContent(request));

            #endregion

            #region Validando o resultado do teste

            result.StatusCode.Should().Be(HttpStatusCode.Unauthorized);

            #endregion

        }
    }
}
