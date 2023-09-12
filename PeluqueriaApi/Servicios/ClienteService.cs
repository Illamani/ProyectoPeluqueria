using PeluqueriaApi.Interfaces;
using PeluqueriaApi.Modelos.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PeluqueriaApi.Servicios
{
	public class ClienteService : IClientesService
	{
		private readonly IClienteRepositorio _clienteRepositorio;
        public ClienteService(IClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }
        public async Task DeleteCliente(int id)
		{
			await _clienteRepositorio.DeleteCliente(id);
		}

		public async Task<List<Clientes>> GetClienteByName(string nombre)
		{
			return await _clienteRepositorio.GetClienteByName(nombre);
		}

		public async Task<List<Clientes>> GetClientes()
		{
			return await _clienteRepositorio.GetClientes();
		}

		public async Task<Clientes> GetFirstCliente()
		{
			return await _clienteRepositorio.GetFirstCliente();
		}

		public async Task InsertCliente(Clientes Cliente)
		{
			await _clienteRepositorio.InsertCliente(Cliente);
		}

		public async Task UpdateCliente(int id, Clientes Cliente)
		{
			await _clienteRepositorio.UpdateCliente(id, Cliente);
		}
	}
}
