using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PrevencionSalud.Welcome.Contract;

namespace PrevencionSalud.Welcome.Controllers
{
    public class UsersController : BaseController
    {
        // GET: Users
        public ActionResult Index()
        {
            return View(this.UserService.Search(string.Empty));
        }

        [HttpPost]
        public JsonResult Create(UserContract contract)
        {
            this.UserService.Create(contract);

            return Json("", JsonRequestBehavior.AllowGet);
        }
    }
}