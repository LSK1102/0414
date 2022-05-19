using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using wed410928343.ViewModels;

namespace wed410928343.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult SigUp()
        {
            return View(new SignUpData());
        }
        [HttpPost]
        public ActionResult SigUp(SignUpData data)
        {
            if (ModelState.IsValid)
            {
                data.Message = "註冊成功";
            }
            return View(data);
        }
    }
}