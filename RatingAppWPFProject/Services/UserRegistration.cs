using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatingAppWPFProject.Services
{
    public class UserRegistration
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int Age { get; set; }
        public string? Login { get; set; }
        public string? Password { get; set; }
        public bool isLiver { get; set; }   //checkbox который определяет является ли он жильцом или нет

        public UserRegistration(int iD, string? name, string? surname, int age, string? login, string? password, bool isLiver)
        {
            ID = iD;
            Name = name;
            Surname = surname;
            Age = age;
            Login = login;
            Password = password;
            this.isLiver = isLiver;
        }
    }
}
