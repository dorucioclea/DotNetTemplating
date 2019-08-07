using System.IO;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

namespace MicroService.Infrastructure.Swagger
{
  public static class SwaggerStartup
  {
    public static IServiceCollection ConfigureSwagger(this IServiceCollection services)
    {
      return services.AddSwaggerGen(c =>
      {
        c.SwaggerDoc("v1", new Info
        {
          Title = "API",
          Version = "v1",
          Description = "Service",
          Contact = new Contact
          {
            Name = "GitHub Repo",
            Email = "",
            Url = "https://github.com/archre2/ProgramRepository",
          }
        });
        var filePath = Path.Combine(System.AppContext.BaseDirectory, "ProgramRepository.API.xml");
        c.IncludeXmlComments(filePath);
        c.DescribeAllEnumsAsStrings();
      });
    }
  }
}