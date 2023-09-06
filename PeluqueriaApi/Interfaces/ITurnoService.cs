using PeluqueriaApi.Modelos.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PeluqueriaApi.Interfaces
{
	public interface ITurnoService
	{
		Task<List<Turnos>> GetTurnos();
	}
}
