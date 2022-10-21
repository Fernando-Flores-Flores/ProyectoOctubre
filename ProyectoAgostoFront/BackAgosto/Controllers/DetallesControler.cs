using BackAgosto.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackAgosto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetallesControler : ControllerBase
    {
        public readonly AplicationDbContext context;
        public DetallesControler(AplicationDbContext contextConstructor) { 
            this.context = contextConstructor;
        }

        //Get de in inventario
        [HttpGet("{id:int}")]
        public async Task<ActionResult<DetalleInventario>> GetInventario(int id) {
            //Firtsordefault trae el primer registro de la tabla
            //Condición de que el Id del contexto sea igual al id que se introdujo
            return await context.DetalleInventario.FirstOrDefaultAsync(x => x.Id == id);
        }
        //Post para crear un DetalleInventario
        [HttpPost]
        public async Task<ActionResult> PostDetalle(DetalleInventario detalleIventario) {
            //verificar que exista un invetario 
            var existeInventario = await context.Inventarios.AnyAsync(x => x.Id == detalleIventario.Id);
            if (existeInventario)
            {
                return BadRequest($"No existe un datlle cn el Usario con Id:{detalleIventario.Id} ");
            }
            context.Add(detalleIventario);
            await context.SaveChangesAsync();
            return Ok();
        }

    }
}
