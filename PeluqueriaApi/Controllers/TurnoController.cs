using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PeluqueriaApi.EntityFrameWork;
using PeluqueriaApi.Interfaces;
using PeluqueriaApi.Modelos;
using PeluqueriaApi.Modelos.DTO;
using PeluqueriaApi.Modelos.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PeluqueriaApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TurnoController : ControllerBase
	{
		private readonly ITurnoService _turnoService;
		private readonly ILogger<TurnoController> _logger;
		private readonly MapperlyMapper _mapperly = new();
		public TurnoController(ITurnoService turnoService, ILogger<TurnoController> logger)
		{
			_turnoService = turnoService;
			_logger = logger;
		}

		[HttpGet("get-turnos")]
		public async Task<List<TurnosDto>> GetTurnos()
		{
			var turno = await _turnoService.GetTurnos();
			var turnosDto = _mapperly.Map(turno);
			return turnosDto;
		}

		[HttpGet("get-turno")]
		public async Task<List<TurnosDto>> GetTurnoByName(string nombre)
		{
			var turno = await _turnoService.GetTurnoByName(nombre);
			var turnosDto = _mapperly.Map(turno);
			return turnosDto;
		}

		[HttpPost("insert-turno")]
		public async Task InsertTurno(TurnosDto turnoDto)
		{
			var turno = _mapperly.Map(turnoDto);
			await _turnoService.InsertTurno(turno);
		}
	}
}
