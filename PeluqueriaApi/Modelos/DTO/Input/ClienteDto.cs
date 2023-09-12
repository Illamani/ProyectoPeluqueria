using System;

namespace PeluqueriaApi.Modelos.DTO.Input
{
	public class ClienteDto
	{
		public int Id { get; set; }
		public string Nombre { get; set; }
		public string Apellido { get; set; }
		public DateTime FechaNacimiento { get; set; }
		public bool Genero { get; set; }
	}
}
