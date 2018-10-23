using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCVideo.Models;
using MVCVideo.ViewModels;
using System.Data.Entity;

namespace MVCVideo.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        private DatabaseContext _context;

        public CustomersController()
        {
            _context = new DatabaseContext();
        }


        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index()
        {
            var Customers = _context.customers.Include(c => c.MembershipType).ToList();
            return View(Customers);
        }
        public ActionResult CustomerForm()
        {
            var membershiptype = _context.membershipTypes.ToList();
            var viewModel = new NewCustomerViewModel
            {
                membershipTypes = membershiptype,
                
                
            };
            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                var viewmodel = new NewCustomerViewModel(customer)
                {
                    
                    membershipTypes = _context.membershipTypes.ToList()
                };
                return View("CustomerForm", viewmodel);
            }

            if (customer.Id == 0)
            {
                _context.customers.Add(customer);
            }
            else
            {
                var customerInDb = _context.customers.Single(c => c.Id == customer.Id);

                //Mapper.Map(customer, customerInDb);

                customerInDb.Name = customer.Name;
                customerInDb.DOB = customer.DOB;
                customerInDb.MemberShipTypeId = customer.MemberShipTypeId;
                customerInDb.IsSubscribedToNewsLetter = customer.IsSubscribedToNewsLetter;




            }

            _context.SaveChanges();
            return RedirectToAction("Index", "Customers");




        }
        public ActionResult Edit(int id)
        {
            var customers = _context.customers.SingleOrDefault(n => n.Id == id);
            if (customers == null)
            {
                return HttpNotFound();
            }
            else
            {
                var viewModel = new NewCustomerViewModel(customers)
                {
                    
                    membershipTypes = _context.membershipTypes.ToList()
                };
                return View("CustomerForm", viewModel);
            }
        }


        public ActionResult Details(int id)
        {
            Customer customer = _context.customers.Include(c => c.MembershipType).SingleOrDefault(n => n.Id == id);
            if (customer == null)
                return HttpNotFound();


            return View(customer);
        }
    }
}