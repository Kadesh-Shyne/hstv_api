using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HSTV_Api.Data;
using HSTV_Api.Models;

namespace HSTV_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribersController : ControllerBase
    {
        private readonly HstvDbContext _context;

        public SubscribersController(HstvDbContext context)
        {
            _context = context;
        }

        // GET: api/Subscribers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Subscribers>>> GetSubscribers()
        {
          if (_context.Subscribers == null)
          {
              return NotFound();
          }
            return await _context.Subscribers.ToListAsync();
        }

        // GET: api/Subscribers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Subscribers>> GetSubscribers(int id)
        {
          if (_context.Subscribers == null)
          {
              return NotFound();
          }
            var subscribers = await _context.Subscribers.FindAsync(id);

            if (subscribers == null)
            {
                return NotFound();
            }

            return subscribers;
        }

        // PUT: api/Subscribers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSubscribers(int id, Subscribers subscribers)
        {
            if (id != subscribers.SubscriberId)
            {
                return BadRequest();
            }

            _context.Entry(subscribers).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SubscribersExists(id))
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

        // POST: api/Subscribers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Subscribers>> PostSubscribers(Subscribers subscribers)
        {
          if (_context.Subscribers == null)
          {
              return Problem("Entity set 'HstvDbContext.Subscribers'  is null.");
          }
            _context.Subscribers.Add(subscribers);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSubscribers", new { id = subscribers.SubscriberId }, subscribers);
        }

        // DELETE: api/Subscribers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSubscribers(int id)
        {
            if (_context.Subscribers == null)
            {
                return NotFound();
            }
            var subscribers = await _context.Subscribers.FindAsync(id);
            if (subscribers == null)
            {
                return NotFound();
            }

            _context.Subscribers.Remove(subscribers);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SubscribersExists(int id)
        {
            return (_context.Subscribers?.Any(e => e.SubscriberId == id)).GetValueOrDefault();
        }
    }
}
