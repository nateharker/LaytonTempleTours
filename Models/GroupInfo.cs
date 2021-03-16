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
        public string Name { get; set; }
        [Required (ErrorMessage = "Please enter a group size.")]
        public int Size { get; set; }
        [Required (ErrorMessage = "Please enter an email address.")]
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }
        public DateTime TimeSlot { get; set; }
    }
}
