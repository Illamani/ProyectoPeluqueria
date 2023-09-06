using PeluqueriaApi.Modelos.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PeluqueriaApi.Interfaces
{
	public interface ITurnoRepositorio
	{
		Task<List<Turnos>> GetTurnos();
	}
}
