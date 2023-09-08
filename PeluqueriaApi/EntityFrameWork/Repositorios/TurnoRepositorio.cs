using Microsoft.EntityFrameworkCore;
using PeluqueriaApi.Interfaces;
using PeluqueriaApi.Modelos.Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeluqueriaApi.EntityFrameWork.Repositorios
{
    public class TurnoRepositorio : ITurnoRepositorio
    {
        private readonly AppDbContext _appDbContext;

        public TurnoRepositorio(AppDbContext dbContext)
        {
            _appDbContext = dbContext;
        }

        public async Task<Turnos> GetFirstTurno()
        {
            return await _appDbContext.Turnos.FirstOrDefaultAsync();
        }

        public async Task<List<Turnos>> GetTurnos()
        {
            return await _appDbContext.Turnos.ToListAsync();
        }

        public async Task DeleteTurno(int id)
        {
            var turno = await _appDbContext.Turnos.FindAsync(id);
            if (turno != null)
            {
                _appDbContext.Turnos.Remove(turno);
                await _appDbContext.SaveChangesAsync();
            }
        }

        public async Task UpdateTurno(int id, Turnos turno)
        {
            var turnoDb = await _appDbContext.Turnos.FindAsync(id);
            if(turnoDb != null)
            {
                turnoDb.Nombre = turno.Nombre;
                turnoDb.TipoPeinado = turno.TipoPeinado;
                turnoDb.Apellido = turno.Apellido;
                await _appDbContext.SaveChangesAsync();
            }
        }

        public async Task<List<Turnos>> GetTurnoByName(string nombre)
        {
            return await _appDbContext.Turnos.Where(x => x.Nombre == nombre).ToListAsync();
        }

        public async Task InsertTurno(Turnos Turno)
        {
            await _appDbContext.Turnos.AddAsync(Turno);
            await _appDbContext.SaveChangesAsync();
        }
    }
}
