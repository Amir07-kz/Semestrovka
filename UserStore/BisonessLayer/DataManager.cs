using BuisnessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuisnessLayer
{
    public class DataManager
    {
		private IUserRepository _userRepository;
		private IAdRepository _adRepository;

		public DataManager(IUserRepository userRepository, IAdRepository adRepository)
		{
			_userRepository = userRepository;
			_adRepository = adRepository;
		}


		public IUserRepository User { get { return _userRepository; } }
		public IAdRepository Ad { get { return _adRepository; } }
	}
}
