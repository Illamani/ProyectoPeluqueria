using PeluqueriaApi.Interfaces;
using PeluqueriaApi.Modelos.DTO;
using PeluqueriaApi.Modelos.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PeluqueriaApi.Servicios
{
	public class TurnoService : ITurnoService
	{
		private readonly ITurnoRepositorio _turnoRepository;
        public TurnoService(ITurnoRepositorio turnoRepositorio)
        {
            _turnoRepository = turnoRepositorio;
        }

        public async Task<List<Turnos>> GetTurnos()
		{
			return await _turnoRepository.GetTurnos();
		}
	}
}
