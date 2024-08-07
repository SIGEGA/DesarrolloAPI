using Microsoft.VisualBasic;

namespace DesarrolloAPI.Recurso
{
	public class Articulo
	{
		public int IdArticulo { get; init; }
		public string Descripcion { get; set; }
		public string sku {  get; set; }
		public double Precio { get; set; }
		public DateTime FechaCreacion { get; set; }
		public bool habilitado { get; set; }
	}
}
