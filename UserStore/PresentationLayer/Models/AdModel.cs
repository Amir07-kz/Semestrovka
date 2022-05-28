using DataLayer.Entityes;
using System;
using System.Collections.Generic;
using System.Text;

namespace PresentationLayer.Models
{
    public class AdViewModel
    {
        public Ad Ad { get; set; }
        public Ad NextAd { get; set; }
    }

    public class AdEditModel
    {
        public int AdId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public byte[] Image { get; set; }
        public int Price { get; set; }
        public int TelephonNumber { get; set; }
        public int UserId { get; set; }
    }

}
