using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using threadShopWebApi.Data;
using threadShopWebApi.DTOs;
using threadShopWebApi.Models;

namespace threadShopWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthentificationsController : ControllerBase
    {
        private readonly DataContext _context;

        public AuthentificationsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Authentifications
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Authentification>>> GetAuthentifications()
        {
          if (_context.Authentifications == null)
          {
              return NotFound();
          }
            return await _context.Authentifications.ToListAsync();
        }

        // GET: api/Authentifications/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Authentification>> GetAuthentification(int id)
        {
          if (_context.Authentifications == null)
          {
              return NotFound();
          }
            var authentification = await _context.Authentifications.FindAsync(id);

            if (authentification == null)
            {
                return NotFound();
            }

            return authentification;
        }

        // PUT: api/Authentifications/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAuthentification(int id, Authentification authentification)
        {
            if (id != authentification.AuthentificationId)
            {
                return BadRequest();
            }

            _context.Entry(authentification).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AuthentificationExists(id))
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

        // POST: api/Authentifications
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Authentification>> PostAuthentification(AuthDto auth)
        {
          if (_context.Authentifications == null)
          {
              return Problem("Entity set 'DataContext.Authentifications'  is null.");
          }
            _context.Authentifications.Add(new Authentification
            {
                Username = auth.Username,
                Password = auth.Password,
                IsAdmin = auth.IsAdmin,
                CustomerId = auth.CustomerId,
                Customer = _context.Customers.FirstOrDefault(c => c.CustomerId == auth.CustomerId )
            });
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAuthentification", new { id = _context.Authentifications.Last() }, auth);
        }

        // DELETE: api/Authentifications/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAuthentification(int id)
        {
            if (_context.Authentifications == null)
            {
                return NotFound();
            }
            var authentification = await _context.Authentifications.FindAsync(id);
            if (authentification == null)
            {
                return NotFound();
            }

            _context.Authentifications.Remove(authentification);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AuthentificationExists(int id)
        {
            return (_context.Authentifications?.Any(e => e.AuthentificationId == id)).GetValueOrDefault();
        }
    }
}
