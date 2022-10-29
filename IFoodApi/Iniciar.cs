using IFoodApi.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.InMemory;


namespace IFoodApi
{
    public class Iniciar
    {

        public IConfiguration Configuracao { get; }

        public Iniciar(IConfiguration configuracao)
        {
            Configuracao = configuracao;
        }

        public void ConfigureServices(IServiceCollection servico) 
        {
            servico.AddDbContext<DataContext>(opc => opc.UseInMemoryDatabase("Database"));
            servico.AddScoped<DataContext>();
            servico.AddControllers();
        }


        public void Configurar(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
