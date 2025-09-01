using Microsoft.EntityFrameworkCore;
using SharpPontoWeb.Models;

namespace SharpPontoWeb.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Registro> Registros { get; set; }
    }
}