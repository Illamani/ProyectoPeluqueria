using PeluqueriaApi.Modelos.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PeluqueriaApi.Interfaces
{
	public interface IClienteRepositorio
	{
		Task DeleteCliente(int id);
		Task<Clientes> GetFirstCliente();
		Task<List<Clientes>> GetClienteByName(string nombre);
		Task<List<Clientes>> GetClientes();
		Task InsertCliente(Clientes Cliente);
		Task UpdateCliente(int id, Clientes Cliente);
	}
}
