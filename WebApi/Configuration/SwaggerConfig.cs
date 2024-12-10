using Microsoft.OpenApi.Models;

namespace WebApi.Configuration
{
    public static class SwaggerConfig
    {
        public static void AddSwaggerConfiguration(this IServiceCollection Services)
        {
            Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                new OpenApiInfo
                {
                    Title = "Book Store",
                    Version = "v1",
                    Description = "Api da BookStore",
                    Contact = new OpenApiContact
                    {
                        Name = "Adriano Batista",
                        Email = "adraino.batista@outlook.com"
                    }
                });
            });
        }

        public static void UseSwaggerConfiguration(this IApplicationBuilder App)
        {
            App.UseSwagger();
            App.UseSwaggerUI(c => 
            {
                c.RoutePrefix = string.Empty;
                c.SwaggerEndpoint("./swagger/v1/swagger.json", "CL V1");
            });
        }
    }
}
