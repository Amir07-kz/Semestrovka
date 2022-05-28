using BuisnessLayer;
using BuisnessLayer.Interfaces;
using DataLayer;
using DataLayer.Entityes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using UserStore.Models;
using User = DataLayer.Entityes.User;

namespace UserStore.Controllers
{
    public class HomeController : Controller
    {

        private DataManager _dataManager;

        public HomeController(DataManager dataManager)
        {

            _dataManager = dataManager;
        }
        
        public IActionResult Index()
        {
            List<User> _dirs = _dataManager.User.GetAllUser(true).ToList();
            return View(_dirs);
        }
         
        public IActionResult Profil()
        {
            return View();
        }
        public IActionResult Ad()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Place()
        {
            return View();
        }
        public IActionResult test()
        {
            return View();
        }
        public IActionResult Chat()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
