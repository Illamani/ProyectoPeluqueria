using System;

namespace PeluqueriaApi.Modelos.DTO.Input
{
	public class GetTurnoInput
	{
		public string Nombre { get; set; }
		public string TipoDePeinado { get; set; }
		public DateTime? FechaDesde { get; set; }
		public DateTime? FechaHasta { get; set; }
	}
}
