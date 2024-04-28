using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatingAppWPFProject.Model.Data.Entities
{
    public class House
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<User>? Users { get; set; }
        public List<Reviev>? Revievs { get; set; }
        public House() { }

        public House(string name, List<User> users, List<Reviev> revievs)
        {
            Name = name;

            Users = users;

            Revievs = revievs;
        }
    }
}
