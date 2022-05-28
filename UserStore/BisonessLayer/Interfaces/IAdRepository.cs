using System;
using System.Collections.Generic;
using System.Text;
using DataLayer.Entityes;

namespace BuisnessLayer.Interfaces
{
    public interface IAdRepository
    {
        IEnumerable<Ad> GetAllAd(bool includeUser = false);
        Ad GetAdById(int materialId, bool includeUser = false);
        void SaveAd(Ad ad);
        void DeleteAd(Ad ad);
    }
}
