using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using Web.UserServiceReference;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        const int PageSize = 25;
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Contact(int? page)
        {
            UserServiceClient userClient = new UserServiceClient();
            var usersList = userClient.GetUsers(page ?? 1, PageSize);
            return View(usersList.ToPagedList(page ?? 1, PageSize));
        }
    }
}