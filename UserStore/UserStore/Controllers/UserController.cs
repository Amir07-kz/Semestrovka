using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserStore.Models;

namespace UserStore.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        static readonly List<Users> data;



        [HttpGet]
        public IEnumerable<Users> Get()
        {
            return data;
        }

        [HttpPost]
        public IActionResult Post(Users users)
        {
            users.Id = Guid.NewGuid().ToString();
            data.Add(users);
            return Ok(users);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            Users users = data.FirstOrDefault(x => x.Id == id);
            if (users == null)
            {
                return NotFound();
            }
            data.Remove(users);
            return Ok(users);
        }
    }
}
