using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using MVCVideo.Models;
using MVCVideo.ViewModels;
using System.Data.Entity.Validation;

namespace MVCVideo.Controllers
{
    public class MoviesController : Controller
    {
        DatabaseContext _Context;
        public MoviesController()
        {
            _Context = new DatabaseContext();
        }
        protected override void Dispose(bool disposing)
        {
            _Context.Dispose();
        }
        public ActionResult Index()
        {
            var movies = _Context.movies.Include(c => c.genre).ToList();
            return View(movies);
        }
        public ActionResult SaveMovie()
        {
            var genre = _Context.genre.ToList();
            var newmoviemodel = new NewMovieViewModel
            {
                genres = genre
                
                
            };
            return View(newmoviemodel);
        }
        public ActionResult edit(int id)
        {
            var movies = _Context.movies.SingleOrDefault(n => n.Id == id);
            if(movies == null)
            {
                return HttpNotFound();
            }
            else
            {
                var newmoviemodels = new NewMovieViewModel(movies)
                {
                    genres = _Context.genre.ToList(),
                    
                };
                return View("SaveMovie", newmoviemodels);
            }
            
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveMovies(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                var viewmodel = new NewMovieViewModel(movie)
                {
                    genres = _Context.genre.ToList()
                };
                return View("SaveMovie",viewmodel);
            }
            movie.DateAdded = DateTime.Today;
            if(movie.Id == 0)
            {
                _Context.movies.Add(movie);
            }
            else
            {
                var movieInDb = _Context.movies.Single(n => n.Id == movie.Id);
                movieInDb.Name = movie.Name;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.GenreId = movie.GenreId;
                movieInDb.NumberInStuck = movie.NumberInStuck;
            }
            try
            {
                _Context.SaveChanges();
            }
            catch(DbEntityValidationException e)
            {
                Console.WriteLine(e);
            }
            
            return RedirectToAction("Index");

        }
        public ActionResult Details(int Id)
        {
            var movie = _Context.movies.Include(c => c.genre).Where(n => n.Id == Id).FirstOrDefault();
            if(movie == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(movie);
            }

        }
    }
}