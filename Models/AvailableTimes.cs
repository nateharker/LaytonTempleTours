using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LaytonTempleTours.Models
{
    public class AvailableTimes
    {
        DateTime AppointementTime { get; }
        bool SlotBooked { get; set; } = false;
    }
}
