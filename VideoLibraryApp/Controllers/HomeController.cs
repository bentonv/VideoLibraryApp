using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoLibraryBusinessLayer;

namespace VideoLibraryApp.Controllers
{
    public class HomeController : Controller
    {
        public static Collection<Video> videoList = VideoFactory.GetCollection();
        private static string[] _titles = videoList.Select(x => x.Title).ToArray();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public PartialViewResult SearchResults(Video video)
        {
            List<Video> searchResults = new List<Video>();
            string title = string.Empty;
            string director = string.Empty;

            if (!video.Title.IsNullOrWhiteSpace())
            {
                title = video.Title.ToLower().Trim();
            }

            if (!video.Director.IsNullOrWhiteSpace())
            {
                director = video.Director.ToLower().Trim();
            }

            bool titleMatch = false;
            bool yearMatch = false;
            bool directorMatch = false;

            foreach (var vid in videoList)
            {
                titleMatch = false;
                yearMatch = false;
                directorMatch = false;

                if (vid.Title.ToLower().Contains(title) && title != "")
                {
                    titleMatch = true;
                }

                if (vid.Director.ToLower().Contains(director) && director != "")
                {
                    directorMatch = true;
                }

                if (vid.Year == video.Year)
                {
                    yearMatch = true;
                }

                
                if (!video.Title.IsNullOrWhiteSpace() && video.Year != null && !video.Director.IsNullOrWhiteSpace())
                {
                    if (titleMatch && yearMatch && directorMatch)
                    {
                        searchResults.Add(vid);
                    }
                }
                
                else if (!video.Title.IsNullOrWhiteSpace() && video.Year != null)
                {
                    if (titleMatch && yearMatch)
                    {
                        searchResults.Add(vid);
                    }
                }
                
                else if (video.Year != null && !video.Director.IsNullOrWhiteSpace())
                {
                    if (yearMatch && directorMatch)
                    {
                        searchResults.Add(vid);
                    }
                }
               
                else if (!video.Title.IsNullOrWhiteSpace() && !video.Director.IsNullOrWhiteSpace())
                {
                    if (titleMatch && directorMatch)
                    {
                        searchResults.Add(vid);
                    }
                }
                else
                {
                    if (titleMatch || yearMatch || directorMatch)
                    {
                        searchResults.Add(vid);
                    }
                }
            }
            return PartialView(searchResults);
        }

        public JsonResult Title(string term)
        {
            return Json(_titles.Where(x => x.ToLower().Contains(term)).ToArray(), JsonRequestBehavior.AllowGet);
        }

        [Authorize]
        [Route("Details/{id:int}")]
        public ActionResult Details(int id)
        {
            var result = videoList.First(x => x.VideoId == id);

            return View(result);
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Error()
        {
            return View();
        }
    }
}