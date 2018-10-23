using mvcCompleteProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcCompleteProject.Controllers
{
    public class LectureController : Controller
    {
        private LectureContext Ldb = new LectureContext();
        // GET: Lecture
        public ActionResult Index()
        {
            var lecture = Ldb.Lectures.ToList();
            return View(lecture);
        }

        // GET: Lecture/Details/5
        public ActionResult Details(int id)
        {
            Lecture lecture = Ldb.Lectures.Find(id);
            if (lecture == null)
            {
                return HttpNotFound();
            }
            return View(lecture);
        }

        // GET: Lecture/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Lecture/Create
        [HttpPost]
        public ActionResult Create(Lecture lecture)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    Ldb.Lectures.Add(lecture);
                    Ldb.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(lecture);
                }
                
            }
            catch
            {
                return View();
            }
        }

        // GET: Lecture/Edit/5
        public ActionResult Edit(int id)
        {
            Lecture lecture = Ldb.Lectures.Find(id);
            return View(lecture);
        }

        // POST: Lecture/Edit/5
        [HttpPost]
        public ActionResult Edit(Lecture lecture)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    Ldb.Entry(lecture).State = System.Data.Entity.EntityState.Modified;
                    Ldb.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(lecture);

            }
            catch
            {
                return View();
            }
        }

        // GET: Lecture/Delete/5
        public ActionResult Delete(int id)
        {
            Lecture lecture = Ldb.Lectures.Find(id);
            return View(lecture);
        }

        // POST: Lecture/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                Lecture lecture = new Lecture();
                if(ModelState.IsValid)
                {
                    lecture = Ldb.Lectures.Find(id);
                    if(lecture==null)
                    {
                        return HttpNotFound();
                    }
                    else
                    {
                        Ldb.Lectures.Remove(lecture);
                        Ldb.SaveChanges();
                        return RedirectToAction("Index");
                    }
                }
                return View(lecture);
            }
            catch
            {
                return View();
            }
        }
    }
}
