using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Reserva.Models;

namespace Reserva.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationDetailController : ControllerBase
    {
        private readonly ReservationDetailContext _context;

        public ReservationDetailController(ReservationDetailContext context)
        {
            _context = context;
        }

        // GET: api/ReservationDetail
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReservationDetail>>> GetReservationDetails()
        {
            return await _context.ReservationDetails.ToListAsync();
        }

        // GET: api/ReservationDetail/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ReservationDetail>> GetReservationDetail(int id)
        {
            var reservationDetail = await _context.ReservationDetails.FindAsync(id);

            if (reservationDetail == null)
            {
                return NotFound();
            }

            return reservationDetail;
        }

        // PUT: api/ReservationDetail/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReservationDetail(int id, ReservationDetail reservationDetail)
        {
            if (id != reservationDetail.ResID)
            {
                return BadRequest();
            }

            _context.Entry(reservationDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReservationDetailExists(id))
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

        // POST: api/ReservationDetail
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<ReservationDetail>> PostReservationDetail(ReservationDetail reservationDetail)
        {
            _context.ReservationDetails.Add(reservationDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetReservationDetail", new { id = reservationDetail.ResID }, reservationDetail);
        }

        // DELETE: api/ReservationDetail/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ReservationDetail>> DeleteReservationDetail(int id)
        {
            var reservationDetail = await _context.ReservationDetails.FindAsync(id);
            if (reservationDetail == null)
            {
                return NotFound();
            }

            _context.ReservationDetails.Remove(reservationDetail);
            await _context.SaveChangesAsync();

            return reservationDetail;
        }

        private bool ReservationDetailExists(int id)
        {
            return _context.ReservationDetails.Any(e => e.ResID == id);
        }
    }
}
