using PeluqueriaApi.Modelos.DTO;
using PeluqueriaApi.Modelos.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PeluqueriaApi.Interfaces
{
	public interface ITurnoService
	{
        Task DeleteTurno(int id);
		Task<Turnos> GetFirstTurno();
		Task<List<Turnos>> GetTurnoByName(string nombre);
		Task<List<Turnos>> GetTurnos();
		Task InsertTurno(Turnos turno);
        Task UpdateTurno(int id, Turnos turno);
    }
}
