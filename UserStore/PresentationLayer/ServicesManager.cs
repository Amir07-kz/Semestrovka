using BuisnessLayer;
using PresentationLayer.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace PresentationLayer
{
    public class ServicesManager
    {
		DataManager _dataManager;
		private UserService _userService;
		private AdService _adService;

		public ServicesManager(
			DataManager dataManager
			)
		{
			_dataManager = dataManager;
			_userService = new UserService(_dataManager);
			_adService = new AdService(_dataManager);
		}

		public UserService User { get { return _userService; } }
		public AdService Ad { get { return _adService; } }
	}
}

