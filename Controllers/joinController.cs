using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myproject.Models;

namespace myproject.Controllers
{
    [Route("api/[controller]")]
    public class joinController : ControllerBase
    {
        public readonly MyDbContext db;
        public joinController(MyDbContext mdb)
        {
            db = mdb;
        }
        [HttpPost]
        public String Post([FromBody]Join join) {
            db.joins.Add(join);
            return "added sucessfully";
        }


    }
}