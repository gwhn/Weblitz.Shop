﻿using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Weblitz.Shop.Web.Models.View;

namespace Weblitz.Shop.Web.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/
        public ActionResult Index()
        {
            return View();
        }


        // 
        // GET: /Account/Summary
        [ChildActionOnly]
        public PartialViewResult Summary()
        {
            return PartialView(new AccountSummary
                {
                    IsAuthenticated = true,
                    UserName = "test",
                    LanguageId = 1,
                    LanguageList = new Dictionary<int, string> {{1, "English"}, {2, "French"}, {3, "Spanish"}},
                    CurrencyId = 1,
                    CurrencyList = new Dictionary<int, string> {{1, "GBP"}, {2, "USD"}, {3, "EUR"}}
                });
        }
        
        //
        // GET: /Account/LogOut
        public ActionResult LogOut()
        {
            throw new NotImplementedException();
        }

        //
        // GET: /Account/LogIn
        public ActionResult LogIn()
        {
            throw new NotImplementedException();
        }

        //
        // POST: /Account/Language
        public ActionResult Language(int id)
        {
            throw new NotImplementedException();
        }

        //
        // POST: /Account/Currency
        public ActionResult Currency()
        {
            throw new NotImplementedException();
        }

        // 
        // GET: /Account/WishList
        public ActionResult WishList()
        {
            throw new NotImplementedException();
        }

        // 
        // GET: /Account/Newsletter
        [ChildActionOnly]
        public PartialViewResult Newsletter()
        {
            return PartialView();
        }

        // 
        // POST: /Account/Newsletter/{email}
        [HttpPost]
        public ActionResult Newsletter(string email)
        {
            throw new NotImplementedException();
        }

    }
}