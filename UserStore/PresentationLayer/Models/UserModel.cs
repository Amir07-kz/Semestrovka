using DataLayer.Entityes;
using System;
using System.Collections.Generic;
using System.Text;

namespace PresentationLayer.Models
{
    public class UserViewModel
    {
        public User User { get; set; }
        public List<AdViewModel> Ad { get; set; }
    }
    public class UserEditModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Role { get; set; }
    }
}
