using Microsoft.AspNetCore.Mvc;
using roocky.Data;
using roocky.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace roocky.Controllers
{
    public class ApplicationController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ApplicationController(ApplicationDbContext dbase)
        {
            _db = dbase;
        }
        public IActionResult Index()
        {
            IEnumerable<Application> objList = _db.Application; // buat objectlist
            return View(objList);
        }
    }
}
