using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myproject.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace myproject.Controllers
{
    [Route("api/[controller]")]
    public class loginController : ControllerBase
    {
        public readonly MyDbContext db;
        public loginController(MyDbContext mdb)
        {
            db = mdb;
        }

        [HttpPost]
        public void Post([FromBody]User user)
        {

            db.users.Add(user);
        }
    }
}
