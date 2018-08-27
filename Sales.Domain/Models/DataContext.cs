
namespace Sales.Domain.Models
{
    using System.Data.Entity;
    using Sales.Common.Models;

    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {
        }
        //Esta linea mapea la clase products en la base de datos
        public DbSet<Product> Products { get; set; }
    }
}
