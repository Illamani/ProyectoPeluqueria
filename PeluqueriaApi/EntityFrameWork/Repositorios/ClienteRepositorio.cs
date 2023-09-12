using Microsoft.EntityFrameworkCore;
using PeluqueriaApi.Interfaces;
using PeluqueriaApi.Modelos.Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeluqueriaApi.EntityFrameWork.Repositorios
{
	public class ClienteRepositorio : IClienteRepositorio
	{
		private readonly AppDbContext _DbContext;
        public ClienteRepositorio(AppDbContext appDbContext)
        {
            _DbContext = appDbContext;
        }
        public async Task DeleteCliente(int id)
		{
			var cliente = await _DbContext.Clientes.FindAsync(id);
			if (cliente != null) {
				_DbContext.Clientes.Remove(cliente);
				await _DbContext.SaveChangesAsync();
			}
		}

		public async Task<List<Clientes>> GetClienteByName(string nombre)
		{
			return await _DbContext.Clientes.Where(x => x.Nombre == nombre).ToListAsync();
		}

		public async Task<List<Clientes>> GetClientes()
		{
			return await _DbContext.Clientes.ToListAsync();
		}

		public async Task<Clientes> GetFirstCliente()
		{
			return await _DbContext.Clientes.FirstOrDefaultAsync();
		}

		public async Task InsertCliente(Clientes Cliente)
		{
			await _DbContext.Clientes.AddAsync(Cliente);
			await _DbContext.SaveChangesAsync();
		}

		public async Task UpdateCliente(int id, Clientes Cliente)
		{
			var clienteDb = await _DbContext.Clientes.FindAsync(id);
			if (clienteDb != null)
			{
				clienteDb.Nombre = Cliente.Nombre;
				clienteDb.FechaNacimiento = Cliente.FechaNacimiento;
				clienteDb.Apellido = Cliente.Apellido;
				await _DbContext.SaveChangesAsync();
			}
		}
	}
}
