using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LaytonTempleTours.Models
{
    public class AvailableTime
    {
        [Key]
        [Required]
        public int AvailableTimeId { get; set; }
        public DateTime AppointementTime { get; set; }
        public bool SlotBooked { get; set; }
    }
}
