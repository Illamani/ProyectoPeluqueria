using Microsoft.EntityFrameworkCore;
using PeluqueriaApi.Modelos.Entidades;

namespace PeluqueriaApi.EntityFrameWork
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options)
		: base(options)
		{
		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=localhost;Database=Peluqueria;Trusted_Connection=True;Encrypt=False;");
		}
		public DbSet<Turnos> Turnos { get; set; }
		public DbSet<Clientes> Clientes { get; set;}
	}
}
