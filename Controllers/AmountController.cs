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
    public class AmountController : ControllerBase
    {
        private readonly HstvDbContext _context;

        public AmountController(HstvDbContext context)
        {
            _context = context;
        }

        // GET: api/Amount
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Amount>>> GetAmounts()
        {
          if (_context.Amounts == null)
          {
              return NotFound();
          }
            return await _context.Amounts.ToListAsync();
        }

        // GET: api/Amount/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Amount>> GetAmount(int id)
        {
          if (_context.Amounts == null)
          {
              return NotFound();
          }
            var amount = await _context.Amounts.FindAsync(id);

            if (amount == null)
            {
                return NotFound();
            }

            return amount;
        }

        // PUT: api/Amount/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAmount(int id, Amount amount)
        {
            if (id != amount.AmountId)
            {
                return BadRequest();
            }

            _context.Entry(amount).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AmountExists(id))
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

        // POST: api/Amount
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Amount>> PostAmount(Amount amount)
        {
          if (_context.Amounts == null)
          {
              return Problem("Entity set 'HstvDbContext.Amounts'  is null.");
          }
            _context.Amounts.Add(amount);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAmount", new { id = amount.AmountId }, amount);
        }

        // DELETE: api/Amount/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAmount(int id)
        {
            if (_context.Amounts == null)
            {
                return NotFound();
            }
            var amount = await _context.Amounts.FindAsync(id);
            if (amount == null)
            {
                return NotFound();
            }

            _context.Amounts.Remove(amount);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AmountExists(int id)
        {
            return (_context.Amounts?.Any(e => e.AmountId == id)).GetValueOrDefault();
        }
    }
}
