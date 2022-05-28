using System;
using System.Collections.Generic;
using System.Text;
using DataLayer.Entityes;

namespace BuisnessLayer.Interfaces
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAllUser(bool includeAd = false);
        User  GetUserById(int userId, bool includeAd = false);
        void SaveUser(User achieve);
        void DeleteUser(User achieve);
    }
}
