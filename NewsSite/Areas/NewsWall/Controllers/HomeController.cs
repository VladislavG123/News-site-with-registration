using NewsSite.DataAccess;
using NewsSite.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace NewsSite.Areas.NewsWall.Controllers
{
    public class HomeController : Controller
    {
        private bool isAuthorized = false;
        private User user = null;
        public async Task<ActionResult> Index()
        {
            if (isAuthorized == false)
            {
                return View("Registrate");
            }

            var news = new List<News>();
            using (var context = new NewsContext())
            {
                news = await context.News.ToListAsync();
            }
            return View(news);
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Login(string name, string password)
        {
            using (var context = new NewsContext())
            {
                if (context.Users.Count(user => user.Name == name && user.Password == password) == 1)
                {
                    user = new User() { Name = name, Password = password };
                    return View("Index", await context.News.ToListAsync());
                }
            }
            return View("Login");
        }

        public ActionResult Registrate()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Registrate(string name, string password)
        {
            using (var context = new NewsContext())
            {
                if (context.Users.Count(user => user.Name == name) != 1)
                {
                    return View("Registrate", "Home");
                }
                context.Users.Add(new User() { Name = name, Password = password });
                await context.SaveChangesAsync();
                
                user = new User() { Name = name, Password = password };
                return View("Index", await context.News.ToListAsync());
            }
        }
        public ActionResult NewsInfo(Guid id)
        {
            return View();
        }
    }
}