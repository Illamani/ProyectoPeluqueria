using PeluqueriaApi.Modelos.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PeluqueriaApi.Interfaces
{
	public interface ITurnoRepositorio
	{
        Task DeleteTurno(int id);
        Task<List<Turnos>> GetTurnoByName(string nombre);
		Task<List<Turnos>> GetTurnos();
		Task InsertTurno(Turnos Turno);
        Task UpdateTurno(int id, Turnos turno);
    }
}
