using Microsoft.OpenApi.Models;

namespace ApiProdutos.Services.Configurations
{
    /// <summary>
    /// Classe de configuração para o swagger
    /// </summary>
    public static class SwaggerConfiguration
    {
        public static void AddSwagger(WebApplicationBuilder builder)
        {
            builder.Services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "API para controle de produtos",
                    Description = "Projeto desenvolvido em NET¨API com EntityFramework sqlServer",
                    Contact = new OpenApiContact
                    {
                        Name = "Romulo Correa",
                        Url = new Uri("http://www.cotiinformatica.com.br"),
                        Email = "romuloc4444@gmail.com"
                    }
                });
            });
        }
    }
}
