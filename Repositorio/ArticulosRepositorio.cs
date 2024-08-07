using DesarrolloAPI.Recurso;

namespace DesarrolloAPI.Repositorio
{
	public static class ArticulosRepositorio
	{
		public static List<Articulo> Lista = new List<Articulo>
		{            
			new Articulo
			{
				IdArticulo = 1,
				Descripcion = "COCA COLA 5 L",
				sku = "23",
				Precio = 200.00,
				FechaCreacion = DateTime.Now,
				habilitado = true
			},
			new Articulo
			{
				IdArticulo = 2,
				Descripcion = "SABRITONES 700 GRS",
				sku = "24",
				Precio = 300.00,
				FechaCreacion = DateTime.Now,
				habilitado = true
			},
			new Articulo
			{
				IdArticulo = 3,
				Descripcion = "ARRACHERA",
				sku = "25",
				Precio = 100.00,
				FechaCreacion = DateTime.Now,
				habilitado = true
			}
		};
	}
}
