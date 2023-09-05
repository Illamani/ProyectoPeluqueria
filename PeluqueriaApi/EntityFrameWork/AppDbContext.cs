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
		public DbSet<Turnos> Turnos { get; set; }
	}
}
