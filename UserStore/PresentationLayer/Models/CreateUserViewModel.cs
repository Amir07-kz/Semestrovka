using System;
using System.Collections.Generic;
using System.Text;

namespace PresentationLayer.Models
{
    public class CreateUserViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
    }
}
