using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Entities;
using WebApi.Helpers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]    
    public class AvailableController : ControllerBase
    {
        private readonly AbstractDatabaseContext _context;

        public AvailableController(AbstractDatabaseContext context)
        {
            _context = context;
        }

        // GET: /Availables        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Available>>> GetAvailables()
        {
            return await _context.Availables.ToListAsync();
        }

      
        [HttpGet("{id}")]
        public async Task<ActionResult<Available>> GetAvailable(int id)
        {
            var available = await _context.Availables.FindAsync(id);

            if (available == null)
            {
                return NotFound();
            }

            return available;
        }

        [Authorize(Roles = Role.Admin)]
        [HttpPost]
        public async Task<ActionResult<Available>> PostAvailable(Available available)
        {
            _context.Availables.Add(available);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAvailable", new { id = available.availableId }, available);
        }

        [Authorize(Roles = Role.Admin)]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAvailable(int id, Available available)
        {
            if (id != available.availableId)
            {
                return BadRequest();
            }

            _context.Entry(available).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AvailableExists(id))
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

        // DELETE
        [Authorize(Roles = Role.Admin)]
        [HttpDelete("{id}")]
        public async Task<ActionResult<Available>> DeleteAvailable(int id)
        {
            var available = await _context.Availables.FindAsync(id);
            if (available == null)
            {
                return NotFound();
            }

            _context.Availables.Remove(available);
            await _context.SaveChangesAsync();

            return available;
        }

        private bool AvailableExists(int id)
        {
            return _context.Availables.Any(e => e.availableId == id);
        }
    }
}
