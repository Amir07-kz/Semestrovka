using BuisnessLayer;
using DataLayer.Entityes;
using PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PresentationLayer.Services
{
    public class UserService
    {
        private DataManager _dataManager;
        private AdService _adService;
        public UserService(DataManager dataManager)
        {
            this._dataManager = dataManager;
            _adService = new AdService(dataManager);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<UserViewModel> GetUserList()
        {
            var _dirs = _dataManager.User.GetAllUser();
            List<UserViewModel> _modelsList = new List<UserViewModel>();
            foreach (var item in _dirs)
            {
                _modelsList.Add(UserDBToViewModelById(item.Id));
            }
            return _modelsList;
        }

        public UserViewModel UserDBToViewModelById(int userId)
        {
            var _user = _dataManager.User.GetUserById(userId, true);

            List<AdViewModel> _adViewModelList = new List<AdViewModel>();
            foreach (var item in _user.Ad)
            {
                _adViewModelList.Add(_adService.AdDBModelToView(item.AdId));
            }
            return new UserViewModel() { User = _user, Ad = _adViewModelList };
        }
        public UserEditModel GetUserEdetModel(int userid = 0)
        {
            if (userid != 0)
            {
                var _dirDB = _dataManager.User.GetUserById(userid);
                var _dirEditModel = new UserEditModel() {
                    Id = _dirDB.Id,
                    Email = _dirDB.Email,
                    Password = _dirDB.Password,
                    FirstName = _dirDB.FirstName,
                    SecondName = _dirDB.SecondName,
                    Role = _dirDB.Role,
                };
                return _dirEditModel;
            }
            else { return new UserEditModel() { }; }
        }
        public UserViewModel SaveUserEditModelToDb(UserEditModel userEditModel)
        {
            User _userDbModel;
            if(userEditModel.Id!=0)
            {
                _userDbModel = _dataManager.User.GetUserById(userEditModel.Id);
            }
            else
            {
                _userDbModel = new User();
            }
            _userDbModel.Email = userEditModel.Email;
            _userDbModel.Password = userEditModel.Password;
            _userDbModel.FirstName = userEditModel.FirstName;
            _userDbModel.SecondName = userEditModel.SecondName;

            return UserDBToViewModelById(_userDbModel.Id);
        }

        public UserEditModel CreateNewUserEditModel()
        {
            return new UserEditModel() { };
        }
    }
}
