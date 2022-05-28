using DataLayer.Entityes;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserStore.Models
{
    public class Users : IdentityUser
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public List<Ad>? Ad { get; set; }
    }
}
