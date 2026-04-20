using AppDiscografica.Clases;
using Microsoft.EntityFrameworkCore;

namespace AppDiscografica.Datos
{
    internal class AppDbContext : DbContext
    {

        // Mapeo entre la clase C# y la tabla de SQL Server
        public DbSet<Evento> Eventos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Conexión al servidor local (.\SQLEXPRESS) con seguridad integrada
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=EventosDiscograficaDB;Trusted_Connection=True;TrustServerCertificate=True;");
            //optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=EventosDiscograficaDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }

    } // class
} // namespace
