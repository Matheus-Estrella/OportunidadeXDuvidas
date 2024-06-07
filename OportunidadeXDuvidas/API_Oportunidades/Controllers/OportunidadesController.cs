using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_Oportunidades.Data;
using Models;

namespace API_Oportunidades.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OportunidadesController : ControllerBase
    {
        private readonly API_OportunidadesContext _context;

        public OportunidadesController(API_OportunidadesContext context)
        {
            _context = context;
        }

        // GET: api/Oportunidades
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Oportunidade>>> GetOportunidade()
        {
          if (_context.Oportunidade == null)
          {
              return NotFound();
          }
            return await _context.Oportunidade.ToListAsync();
        }

        // GET: api/Oportunidades/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Oportunidade>> GetOportunidade(int id)
        {
          if (_context.Oportunidade == null)
          {
              return NotFound();
          }
            var oportunidade = await _context.Oportunidade.FindAsync(id);

            if (oportunidade == null)
            {
                return NotFound();
            }

            return oportunidade;
        }

        // PUT: api/Oportunidades/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOportunidade(int id, Oportunidade oportunidade)
        {
            if (id != oportunidade._id)
            {
                return BadRequest();
            }

            _context.Entry(oportunidade).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OportunidadeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Oportunidades
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Oportunidade>> PostOportunidade(Oportunidade oportunidade)
        {
          if (_context.Oportunidade == null)
          {
              return Problem("Entity set 'API_OportunidadesContext.Oportunidade'  is null.");
          }
            _context.Oportunidade.Add(oportunidade);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOportunidade", new { id = oportunidade._id }, oportunidade);
        }

        // DELETE: api/Oportunidades/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOportunidade(int id)
        {
            if (_context.Oportunidade == null)
            {
                return NotFound();
            }
            var oportunidade = await _context.Oportunidade.FindAsync(id);
            if (oportunidade == null)
            {
                return NotFound();
            }

            _context.Oportunidade.Remove(oportunidade);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OportunidadeExists(int id)
        {
            return (_context.Oportunidade?.Any(e => e._id == id)).GetValueOrDefault();
        }
    }
}
