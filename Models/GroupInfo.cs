using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LaytonTempleTours.Models
{
    public class GroupInfo
    {
        [Required (ErrorMessage ="Please enter a group name.")]
        string Name { get; set; }
        [Required (ErrorMessage = "Please enter a group size.")]
        int Size { get; set; }
        [Required (ErrorMessage = "Please enter an email address.")]
        [EmailAddress]
        string Email { get; set; }
        [Phone]
        string PhoneNumber { get; set; }
        DateTime TimeSlot { get; set; }
    }
}
