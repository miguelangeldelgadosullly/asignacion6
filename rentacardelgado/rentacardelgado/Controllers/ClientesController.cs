using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using rentacardelgado.Data;
using rentacardelgado.Models;

namespace rentacardelgado.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly ClienteContexto _context;

        public ClientesController(ClienteContexto contexto)
        {

            _context = contexto;


        }
        //get
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cliente>>> GetClienteItems() {
            return await _context.ClienteItems.ToListAsync();



        }
        //peticion get
        [HttpGet("{id}")]
        public async Task<ActionResult<Cliente>> GetClienteItem(int id) {


            var clienteitem = await _context.ClienteItems.FindAsync(id);
            if (clienteitem == null) {
                return NotFound();
            }

            return clienteitem;



        }

        //post
        [HttpPost]
        public async Task<ActionResult<Cliente>> PostClienteItem(Cliente item) {



            _context.ClienteItems.Add(item);

            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetClienteItem), new { id = item.Id}, item  );
        
        }








    }
}