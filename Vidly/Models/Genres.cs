using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Microsoft.SqlServer.Server;

namespace Vidly.Models
{
    public class Genres
    {
        public int id { get; set; }
        [Required]
        public string name { get; set; }
    }
}