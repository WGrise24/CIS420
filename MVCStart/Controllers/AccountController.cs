using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLibrary.BusinessLogic;
using MVCStart.Models;


namespace MVCStart.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult SignUp()
        {
            ViewBag.Message = "Account";

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(AccountModel model)
        {
            if (ModelState.IsValid)
            {
                int recordsCreated = UserProcessor.SaveUser(Guid.NewGuid(),
                    model.FirstName,
                    model.LastName,
                    model.PhoneNumber,
                    model.StreetAddress,
                    model.City,
                    model.State,
                    model.Zip,
                    model.Email,
                    model.Password,
                    DateTime.Now,
                    true,
                    true,
                    true);
                return RedirectToAction("MyProfile");
            }
            return View();
        }

        public ActionResult LogIn()
        {


            return View();
        }

        public ActionResult MyProfile()
        {
            ViewBag.Message = "My Profile";

            var data = UserProcessor.LoadUsers();
            List<AccountModel> users = new List<AccountModel>();

            foreach (var row in data)
            {
                users.Add(new AccountModel
                {
                    FirstName = row.FirstName,
                    LastName = row.LastName,
                    PhoneNumber = row.PhoneNumber,
                    StreetAddress = row.Address,
                    City = row.City,
                    State = row.State,
                    Zip = row.Zip,
                    Email = row.Email,
                    Password = row.Password
                });
            }

            return View(users);
        }
    }
}
