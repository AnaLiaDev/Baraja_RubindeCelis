using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Baraja_RubindeCelis.Data;
using Baraja_RubindeCelis.Models;

namespace Baraja_RubindeCelis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BarajasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public BarajasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Barajas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Baraja>>> GetBaraja()
        {
            return await _context.Baraja.ToListAsync();
        }

        // GET: api/Barajas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Baraja>> GetBaraja(string id)
        {
            var baraja = await _context.Baraja.FindAsync(id);

            if (baraja == null)
            {
                return NotFound();
            }

            return baraja;
        }

        // PUT: api/Barajas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBaraja(string id, Baraja baraja)
        {
            if (id != baraja.IdNaipe)
            {
                return BadRequest();
            }

            _context.Entry(baraja).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BarajaExists(id))
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

        // POST: api/Barajas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Baraja>> PostBaraja(Baraja baraja)
        {
            _context.Baraja.Add(baraja);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (BarajaExists(baraja.IdNaipe))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetBaraja", new { id = baraja.IdNaipe }, baraja);
        }

        // DELETE: api/Barajas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBaraja(string id)
        {
            var baraja = await _context.Baraja.FindAsync(id);
            if (baraja == null)
            {
                return NotFound();
            }

            _context.Baraja.Remove(baraja);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BarajaExists(string id)
        {
            return _context.Baraja.Any(e => e.IdNaipe == id);
        }
    }
}
