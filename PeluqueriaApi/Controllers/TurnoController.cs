using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PeluqueriaApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TurnoController : ControllerBase
	{
		[HttpGet("get-turno")]
		public string GetTurnos()
		{
			return "Turno 1 devuelto";
		}
	}
}
