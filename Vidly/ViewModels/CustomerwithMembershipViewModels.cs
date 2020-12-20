using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class CustomerwithMembershipViewModels
    {
        public Customers Customer { get; set; }
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
    }
}