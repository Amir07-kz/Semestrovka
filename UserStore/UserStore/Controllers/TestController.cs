using BuisnessLayer;
using PresentationLayer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PresentationLayer.Models;

namespace UserStore.Controllers
{
    public class TestController : Controller
    {
        private DataManager _datamanager;
        private ServicesManager _servicesmanager;

        public TestController(DataManager dataManager)
        {
            _datamanager = dataManager;
            _servicesmanager = new ServicesManager(dataManager);
        }
    }
}
