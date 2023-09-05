using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PeluqueriaApi.EntityFrameWork;
using PeluqueriaApi.Modelos.Entidades;
using System.Linq;
using System.Threading.Tasks;

namespace PeluqueriaApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TurnoController : ControllerBase
	{
		private readonly AppDbContext _appDbContext;

		public TurnoController(AppDbContext dbContext)
		{
			_appDbContext = dbContext;
		}

		[HttpGet("get-turno")]
		public Turnos GetTurnos()
		{
			var prueba = _appDbContext.Turnos.FirstOrDefault();
			return prueba;
		}

		[HttpPost("insert-turno")]
		public async Task InsertTurno(Turnos turnos)
		{
			_appDbContext.Turnos.Add(turnos);
			await _appDbContext.SaveChangesAsync();
		}
	}
}
