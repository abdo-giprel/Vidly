using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Emit;
using System.Web;

namespace Vidly.Models
{
    public class Customers
    {
        public int id { get; set; }
        [Required]
        [StringLength(255,ErrorMessage = "Name is more than 255 characters")]
        public string name { get; set; }
        public DateTime? BirthDate { get; set; }
        public bool IsSubscribedToNewsLatter { get; set; }
        public MembershipType MembershipType { get; set; }
        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }
    }
}