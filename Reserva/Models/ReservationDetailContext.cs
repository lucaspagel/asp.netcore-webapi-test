using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reserva.Models
{
    public class ReservationDetailContext : DbContext
    {
        public ReservationDetailContext(DbContextOptions<ReservationDetailContext> options) : base(options)
        {

        }

        public DbSet<ReservationDetail> ReservationDetails { get; set; }
    }
}
