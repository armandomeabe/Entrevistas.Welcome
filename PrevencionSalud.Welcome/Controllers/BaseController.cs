using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PrevencionSalud.Welcome.BLL.Users;

namespace PrevencionSalud.Welcome.Controllers
{
    public class BaseController : Controller
    {
        private UserService userService;

        public UserService UserService => userService;

        public BaseController()
        {
            this.userService = new UserService();
        }
    }
}