using MvcMusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        //db connection 
        MusicStoreModel db = new MusicStoreModel(); 
        // GET: Store
        public ActionResult Index()
        {
            //get the real genre data form the gerne model
            var genres = db.Genres.ToList().OrderBy(g => g.Name); 

            return View(genres);
        }

        // GET: Store/Browse
        public ActionResult Browse(string genre)
        {
            //when a genre is selected display the albums from that genre
            var g = db.Genres.Include("Albums")
                .SingleOrDefault(gn => gn.Name == genre); 
     

            //return the data to the view
            return View(g); 
        }
    }
}