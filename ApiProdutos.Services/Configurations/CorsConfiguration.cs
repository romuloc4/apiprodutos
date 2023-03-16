namespace ApiProdutos.Services.Configurations
{
    /// <summary>
    /// Classe de configuração do CORS no AspNet
    /// </summary>
    public class CorsConfiguration
    {
        public static void AddCors(WebApplicationBuilder builder)
        {
            builder.Services.AddCors(s => s.AddPolicy("DefaultPolicy",
                builder =>
                {
                    builder
                        .AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader();
                }));
        }

        public static void UserCors(WebApplication app)
        {
            app.UseCors("DefaultPolicy");
        }
    }
}
