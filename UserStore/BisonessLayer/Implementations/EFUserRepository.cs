using BuisnessLayer.Interfaces;
using DataLayer;
using DataLayer.Entityes;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BuisnessLayer.Implementations
{
    public class EFUserRepository : IUserRepository
    {
        private EFDBContext context;
        public EFUserRepository(EFDBContext context)
        {
            this.context = context;
        }

        public IEnumerable<User> GetAllUser(bool includeAd = false)
        {
            if (includeAd)
                return context.Set<User>().Include(x => x.Ad).AsNoTracking().ToList();
            else
                return context.User.ToList();
        }

        public User GetUserById(int userId, bool includeAd = false)
        {
            if (includeAd)
                return context.Set<User>().Include(x => x.Ad).AsNoTracking().FirstOrDefault(x => x.Id == userId);
            else
                return context.User.FirstOrDefault(x => x.Id == userId);
        }

        public void SaveUser(User user)
        {
            if (user.Id == 0)
                context.User.Add(user);
            else
                context.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteUser(User user)
        {
            context.User.Remove(user);
            context.SaveChanges();
        }
    }
}
