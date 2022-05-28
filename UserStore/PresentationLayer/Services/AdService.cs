using BuisnessLayer;
using DataLayer.Entityes;
using PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PresentationLayer.Services
{
    public class AdService
    {
        private DataManager dataManager;
        public AdService(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public AdViewModel AdDBModelToView(int adId)
        {
            var _model = new AdViewModel()
            {
                Ad = dataManager.Ad.GetAdById(adId),
            };
            var _dir = dataManager.User.GetUserById(_model.Ad.UserId, true);

            if (_dir.Ad.IndexOf(_dir.Ad.FirstOrDefault(x => x.AdId == _model.Ad.AdId)) != _dir.Ad.Count() - 1)
            {
                _model.NextAd = _dir.Ad.ElementAt(_dir.Ad.IndexOf(_dir.Ad.FirstOrDefault(x => x.AdId == _model.Ad.AdId)) + 1);
            }
            return _model;
        }

        public AdEditModel GetMaterialEdetModel(int adId)
        {
            var _dbModel = dataManager.Ad.GetAdById(adId);
            var _editModel = new AdEditModel()
            {
                AdId = _dbModel.AdId,
                Name = _dbModel.Name,
                Category = _dbModel.Category,
                Image = _dbModel.Image,
                Price = _dbModel.Price,
                TelephonNumber = _dbModel.TelephonNumber,
                UserId = _dbModel.UserId,
            };
            return _editModel;
        }

        public AdViewModel SaveAdEditModelToDb(AdEditModel editModel)
        {
            Ad ad;
            if (editModel.AdId != 0)
            {
                ad = dataManager.Ad.GetAdById(editModel.AdId);
            }
            else
            {
                ad = new Ad();
            }
            ad.Name = editModel.Name;
            ad.Category = editModel.Category;
            ad.Image = editModel.Image;
            ad.Price = editModel.Price;
            dataManager.Ad.SaveAd(ad);
            return AdDBModelToView(ad.AdId);
        }
        public AdEditModel CreateNewAdEditModel(int userId)
        {
            return new AdEditModel() { UserId = userId };
        }

    }
}
