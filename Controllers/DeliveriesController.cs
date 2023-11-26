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
    public class DeliveriesController : ControllerBase
    {
        private readonly DataContext _context;

        public DeliveriesController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Deliveries
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Delivery>>> GetDelivery()
        {
          if (_context.Deliverys == null)
          {
              return NotFound();
          }
            return await _context.Deliverys.ToListAsync();
        }

        // GET: api/Deliveries/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Delivery>> GetDelivery(int id)
        {
          if (_context.Deliverys == null)
          {
              return NotFound();
          }
            var delivery = await _context.Deliverys.FindAsync(id);

            if (delivery == null)
            {
                return NotFound();
            }

            return delivery;
        }

        // PUT: api/Deliveries/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDelivery(int id, Delivery delivery)
        {
            if (id != delivery.DeliveryId)
            {
                return BadRequest();
            }

            _context.Entry(delivery).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DeliveryExists(id))
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

        // POST: api/Deliveries
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Delivery>> PostDelivery(DeliveryDto delivery)
        {
          if (_context.Deliverys == null)
          {
              return Problem("Entity set 'DataContext.Delivery'  is null.");
          }
            _context.Deliverys.Add(new Delivery { DeliveryName = delivery.DeliveryName});
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDelivery", _context.Deliverys.OrderBy(u => u.DeliveryId).Select(u => u.DeliveryName).Last(), delivery);

        }


        // DELETE: api/Deliveries/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDelivery(int id)
        {
            if (_context.Deliverys == null)
            {
                return NotFound();
            }
            var delivery = await _context.Deliverys.FindAsync(id);
            if (delivery == null)
            {
                return NotFound();
            }

            _context.Deliverys.Remove(delivery);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DeliveryExists(int id)
        {
            return (_context.Deliverys?.Any(e => e.DeliveryId == id)).GetValueOrDefault();
        }
    }
}
