using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCMusicStoreApplication.Models;


namespace MVCMusicStoreApplication.Controllers
{
    public class StoreController : Controller
    {

        private MVCMusicStoreDB db = new MVCMusicStoreDB();

        // GET: Store
        public ActionResult Index(int id)
        {
            List<Album> albumList = db.Albums
                .Where(a => a.GenreId == id)
                .ToList();


            return View(albumList);
        }
        
        public ActionResult Browse()
        {
            List<Genre> genreList = db.Genres.ToList();
            ViewBag.GenresL = genreList;
            return View(genreList);
           
        }

        public ActionResult Details(int id)
        {
            Album album = db.Albums.Find(id);
            if (album == null)
            {
                return HttpNotFound();
            }
            return View(album);


        }
    
    }
}