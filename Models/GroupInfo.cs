﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LaytonTempleTours.Models
{
    //Model that saves group information when group signs up for time slot
    public class GroupInfo
    {
        [Key]
        [Required]
        public int GroupInfoId { get; set; }
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
