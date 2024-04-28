using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RatingAppWPFProject.Model.Data.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? SurName { get; set; }
        public int Age { get; set; }
        public string? Login { get; set; }
        public string? Password { get; set; }
        public bool IsLiver { get; set; }

        public House? CurrentHouse { get; set; }

        public User() { }

        public User(string name, string surname, int age, string login, string password, bool isLiver)
        {
            Name = name;

            SurName = surname;

            Age = age;

            Login = login;

            Password = password;

            IsLiver = isLiver;

            //CurrentHouse = currentHouse;
        }



    }
}
