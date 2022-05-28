using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entityes
{
    public class User 
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Role { get; set; }
        public List<Ad>? Ad { get; set; }
    }
}
