using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movies
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime release_date { get; set; }
        public DateTime dataAdded { get; set; }
        public int numberInStock { get; set; }
        public Genres Genres { get; set; }
        public int Genresid { get; set; }

    }
}