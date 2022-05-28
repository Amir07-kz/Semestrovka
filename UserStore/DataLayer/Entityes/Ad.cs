using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Entityes
{
    public class Ad
    {
        public int AdId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public byte[] Image { get; set; }
        public int Price { get; set; }
        public int TelephonNumber { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

    }
}
