using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatingAppWPFProject.Model.Data.Entities
{
    public class Street
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<House>? Houses { get; set; }

        public Street(string name, List<House> houses)
        {
            Name = name;
            Houses = houses;
        }
        public Street() { }
    }
}
