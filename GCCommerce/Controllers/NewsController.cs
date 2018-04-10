using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GCCommerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace GCCommerce.Controllers
{
    public class NewsController : Controller
    {
        GCCommerceContext OurDbcontext = null;

        public NewsController(GCCommerceContext _OurDbContext )
        {
            OurDbcontext = _OurDbContext;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddNewNews()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddNewNews(News NewsObj)
        {
            OurDbcontext.News.Add(NewsObj);
            OurDbcontext.SaveChanges();
            return View();
        }
    }
}