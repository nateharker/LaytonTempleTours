using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LaytonTempleTours.Models
{
    public class GroupInfo
    {
        [Required]
        string Name { get; set; }
        [Required]
        int Size { get; set; }
        [Required]
        [EmailAddress]
        string Email { get; set; }
        [Phone]
        string PhoneNumber { get; set; }
        DateTime TimeSlot { get; set; }
    }
}
