using BackAgosto.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackAgosto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventarioControler : ControllerBase

    {
        private readonly AplicationDbContext context; 
        public InventarioControler(AplicationDbContext contextConstructor) {
            
        this.context = contextConstructor;
        }
        [HttpGet]
        public async Task<ActionResult<List<Inventario>>> ListaGetInventario() {
            return await context.Inventarios.ToListAsync();
        //    return new List<Inventario>() {
        //new Inventario(){Id=1,nombreInventario="Inventario de material de escritorio", tipoInventario="Activos fijos" },
        //new Inventario(){Id=2,nombreInventario="Inventario de maquinaria y equipos", tipoInventario="Activos fijos" },

        //};
        }


        [HttpPost]
        public async Task<ActionResult> Post(Inventario inventario) {
            context.Add(inventario);
            //guardar cambios
            await context.SaveChangesAsync();
            return Ok();
        }
        //El Id tiene que tener el mismo nombre de a ruta en este caso id 
        [HttpPut("{id:int}")] //api/inventario/1
        public async Task<ActionResult> PutInventario(Inventario inventario,int id)
        {
            if (inventario.Id != id) {
                return BadRequest("El id del autor no coincide con el id de la URL");
            }
            var existe = await context.Inventarios.AnyAsync(x => x.Id == id);
            if (!existe)
            {
                return NotFound();
            }
            //Aqui decimos que la actualizaremos
            context.Update(inventario);
            //guardar cambios
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete ("{id:int}")]
        public async Task<ActionResult> EliminarInventario(int id)
        {
           var existe  = await context.Inventarios.AnyAsync(x=>x.Id ==id);
            if (!existe)
            {
                return NotFound();
            }
            context.Remove(new Inventario() { Id = id });
            await context.SaveChangesAsync();
            return Ok();
        }

    }
}
