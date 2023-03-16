namespace ApiProdutos.Services.Configurations
{
    /// <summary>
    /// Classe para configuração do AutoMapper
    /// </summary>
    public static class AutoMapperConfiguration
    {
        ///Método para configuração do uso do AutoMapper
        public static void AddAutoMapper(WebApplicationBuilder builder)
        {
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }
    }
}
