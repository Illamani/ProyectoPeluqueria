using System;

namespace PeluqueriaApi.Modelos.DTO
{
	public class TurnosDto
	{
		public int Id { get; set; }
		public DateTime Fecha { get; set; }

		public string Nombre { get; set; }

		public string Apellido { get; set; }

		public string TipoPeinado { get; set; }
	}
}
