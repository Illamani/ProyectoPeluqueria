using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PeluqueriaApi.EntityFrameWork;
using PeluqueriaApi.Interfaces;
using PeluqueriaApi.Modelos.Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeluqueriaApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TurnoController : ControllerBase
	{
		private readonly AppDbContext _appDbContext;
		private readonly ITurnoService _turnoService;
		public TurnoController(AppDbContext dbContext, ITurnoService turnoService)
		{
			_appDbContext = dbContext;
			_turnoService = turnoService;
		}

		[HttpGet("get-turno")]
		public async Task<List<Turnos>> GetTurnos()
		{
			return await _turnoService.GetTurnos();
		}

		[HttpPost("insert-turno")]
		public async Task InsertTurno(Turnos turnos)
		{
			_appDbContext.Turnos.Add(turnos);
			await _appDbContext.SaveChangesAsync();
		}
	}
}
