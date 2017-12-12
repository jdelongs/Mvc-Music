﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            return View();
        }

        // GET: Store/Browse
        public ActionResult Browse(string genre)
        {
            //add the selected genre to the viewbag so we can display it in the browse view
            ViewBag.genre = genre; 
            return View(); 
        }
    }
}