using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatingAppWPFProject.Model.Data.Entities
{
    public class Reviev
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public int Rating { get; set; }
        public User? Reviever { get; set; }
        public Reviev() { }

        public Reviev(string description, int rating, User reviever)
        {
            Description = description;

            Rating = rating;

            Reviever = reviever;
        }
    }
}
