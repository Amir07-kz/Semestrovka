using BuisnessLayer.Interfaces;
using DataLayer;
using DataLayer.Entityes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuisnessLayer.Implementations
{
    public class EFAdRepository : IAdRepository
    {
        private EFDBContext context;
        public EFAdRepository(EFDBContext context)
        {
            this.context = context;
        }

        public IEnumerable<Ad> GetAllAd(bool includeUser = false)
        {
            if (includeUser)
                return context.Set<Ad>().Include(x => x.User).AsNoTracking().ToList();
            else
                return context.Ad.ToList();
        }

        public Ad GetAdById(int adId, bool includeUser = false)
        {
            if (includeUser)
                return context.Set<Ad>().Include(x => x.User).AsNoTracking().FirstOrDefault(x => x.AdId == adId);
            else
                return context.Ad.FirstOrDefault(x => x.AdId == adId);
        }

        public void SaveAd(Ad ad)
        {
            if (ad.AdId == 0)
                context.Ad.Add(ad);
            else
                context.Entry(ad).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteAd(Ad ad)
        {
            context.Ad.Remove(ad);
            context.SaveChanges();
        }
    }
}
