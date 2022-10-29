using IFoodApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.InMemory;


namespace IFoodApi.Data
{
    public class DataContext :  DbContext
    {
        public DataContext(DbContextOptions<DataContext> opcao) : base(opcao)
        {

        }

        public DbSet<Restaurante> Restaurantes { get; set; }
    }
}
