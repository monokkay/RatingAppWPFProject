using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatingAppWPFProject.Model.Data.Entities
{
    public class City
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<Street>? Streets { get; set; }
        public City(string name, List<Street> streets)
        {
            Name = name;
            Streets = streets;
        }
        public City() { }

    }
}
