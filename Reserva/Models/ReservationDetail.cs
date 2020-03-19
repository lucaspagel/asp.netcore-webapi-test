using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Reserva.Models
{
    public class ReservationDetail
    {
        [Key]
        public int ResID { get; set; }

        [Required]
        [Column(TypeName = "varchar (100)")]
        public String CustomerName { get; set; }

        [Required]
        [Column(TypeName = "varchar (100)")]
        public String DestinationName { get; set; }

        [Required]
        [Column(TypeName = "varchar (100)")]
        public String DepartureName { get; set; }

        [Required]
        [Column(TypeName = "varchar (5)")]
        public String TravelDate { get; set; }
    }
}
