using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PeluqueriaApi.EntityFrameWork;
using PeluqueriaApi.Interfaces;
using PeluqueriaApi.Modelos;
using PeluqueriaApi.Modelos.DTO;
using PeluqueriaApi.Modelos.DTO.Input;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PeluqueriaApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ClienteController : ControllerBase
	{
		private readonly IClientesService _clienteService;
		private readonly MapperlyMapper _mapperly = new();
		public ClienteController(IClientesService clientesService)
        {
			_clienteService = clientesService;
        }

		[HttpPost("insert-cliente")]
		public async Task InsertCliente(ClienteDto clienteDto)
		{
			var cliente = _mapperly.Map(clienteDto);
			await _clienteService.InsertCliente(cliente);
		}

		[HttpGet("get-first-cliente")]
		public async Task<ClienteDto> GetFirstTurno()
		{
			var turno = await _clienteService.GetFirstCliente();
			var ClienteDto = _mapperly.Map(turno);
			return ClienteDto;
		}

		[HttpGet("get-cliente")]
		public async Task<List<ClienteDto>> GetCliente()
		{
			var turno = await _clienteService.GetClientes();
			var ClienteDto = _mapperly.Map(turno);
			return ClienteDto;
		}

		[HttpGet("get-cliente-by-name")]
		public async Task<List<ClienteDto>> GetTurnoByName(string nombre)
		{
			var turno = await _clienteService.GetClienteByName(nombre);
			var ClienteDto = _mapperly.Map(turno);
			return ClienteDto;
		}

		[HttpGet("update-cliente")]
		public async Task UpdateTurno(int id, ClienteDto turnoDto)
		{
			var turno = _mapperly.Map(turnoDto);
			await _clienteService.UpdateCliente(id, turno);
		}

		[HttpDelete("delete-cliente")]
		public async Task DeleteTurno(int id)
		{
			await _clienteService.DeleteCliente(id);
		}
	}
}
