using DesarrolloAPI.Recurso;
using DesarrolloAPI.Repositorio;
using Microsoft.AspNetCore.Http.HttpResults;

//using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace DesarrolloAPI.Controllers
{
	//[ApiController]
	[Route("Articulo")]
	public class ArticuloController : ControllerBase
	{
		public List<Articulo> Lista = ArticulosRepositorio.Lista;
		[HttpGet]
		public IEnumerable<Articulo> ObtenerArticulo()
		{ 
			return Lista;
        }
        [HttpGet("criterio")]
        public IEnumerable<Articulo> BuscarArticulo([FromQuery] string criterio)
        {
            var ListaBusqueda = Lista
				.Where(a => a.Descripcion.Contains(criterio)).ToArray();
            return ListaBusqueda;
        }
        [HttpPost]
        public ActionResult<Articulo> AgregarArticulo(Articulo NvoArticulo)
		{
			if (NvoArticulo == null)
			{
				return BadRequest("Articulo no acepta nulos.");
			}
			Lista.Add(NvoArticulo);

			return NoContent();
		}
		[HttpDelete]
		public ActionResult EliminarArticulo(int id)
		{
			if(id > 0)
			{
				var item = Lista.FirstOrDefault(a => a.IdArticulo == id);
				if (item == null)
				{
					return NotFound();
				}
				Lista.Remove(item);
				return NoContent();
			}
			return NoContent();
		}
		[HttpPatch]
		public ActionResult ModificarArticulo(Articulo Item)
		{
			if (Item == null) return BadRequest();
            var articulo = Lista.FirstOrDefault(a => a.IdArticulo == Item.IdArticulo);
			if (articulo == null) return NotFound();

			return NoContent(); 
		}
    }

}
