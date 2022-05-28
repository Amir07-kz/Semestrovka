using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer
{
    public static class SampleData
    {
        public static void InitData(EFDBContext context)
        {
            if(!context.User.Any())
            {
                context.User.Add(new Entityes.User() { Email = "Admin@mail.ru", Password = "Admin", FirstName = "Admin", SecondName = "Admin", Role = "Admin", Ad = null });
                context.SaveChanges();
               
            }
        }
    }
}
