using PeluqueriaApi.Modelos.DTO;
using PeluqueriaApi.Modelos.DTO.Input;
using PeluqueriaApi.Modelos.Entidades;
using Riok.Mapperly.Abstractions;
using System.Collections.Generic;

namespace PeluqueriaApi.Modelos
{
	[Mapper]
	public partial class MapperlyMapper
	{
		public partial Clientes Map(ClienteDto clienteDto);
		public partial List<Clientes> Map(List<ClienteDto> clientes);
		public partial ClienteDto Map(Clientes clienteDto);
		public partial List<ClienteDto> Map(List<Clientes> clientes);

		public partial Turnos Map(TurnosDto turnoDto);
		public partial List<Turnos> Map(List<TurnosDto> turnosList);
		public partial TurnosDto Map(Turnos turnoDto);
		public partial List<TurnosDto> Map(List<Turnos> turnosList);

	}
}
