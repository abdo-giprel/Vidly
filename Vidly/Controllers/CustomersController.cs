using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Configuration;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context =new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

       
        // GET: Customers
        [Route("Customer")]
        public ActionResult Customer()
        {
            var customers = _context.Customers.Include(c=>c.MembershipType).ToList();
            return View(customers);
        }
        [Route("Customer/details/{id?}")]
        public ActionResult Details(int id)
        {
            var Customer = _context.Customers.Include(c=>c.MembershipType).SingleOrDefault(c => c.id == id);
            if (Customer == null)
            {
                return HttpNotFound();
            }
            return View(Customer);
        }
        
        public ActionResult New()
        {
            var membershiptypes = _context.MembershipTypes.ToList();
            var customrwithMembership = new CustomerwithMembershipViewModels()
            {
                MembershipTypes = membershiptypes
            };
            return View(customrwithMembership);
        }
        [HttpPost]
        public ActionResult Create(Customers customer,DateTime?birthDate)
        {
            var newCustomer = new Customers()
                {
                    name = customer.name,
                    BirthDate = birthDate,
                    IsSubscribedToNewsLatter = customer.IsSubscribedToNewsLatter,
                    MembershipTypeId = customer.MembershipTypeId
                }
            ;
            _context.Customers.Add(newCustomer);
            _context.SaveChanges();
            return RedirectToAction("Customer", "Customers");
            
        }
        [HttpGet]
        public ActionResult Update(int id)
        {

            var customer = _context.Customers.SingleOrDefault(c => c.id == id);
            var ViewModel = new CustomerwithMembershipViewModels()
            {
                Customer = customer,
                MembershipTypes = _context.MembershipTypes.ToList()
            };
            return View("Update", ViewModel);

        }
        [HttpPost]
        public ActionResult Update(Customers customer,DateTime? birthDate)
        {
            var birthdateValid = birthDate == null ? customer.BirthDate : null;
            var customerDB = _context.Customers.Single(c => c.id == customer.id);
            customerDB.name = customer.name;
            customerDB.BirthDate = birthdateValid;
            customerDB.name = customer.name;
            customerDB.IsSubscribedToNewsLatter = customer.IsSubscribedToNewsLatter;

            _context.SaveChanges();
            return RedirectToAction("Customer", "Customers");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            _context.Customers.Remove(_context.Customers.Single(c => c.id == id));
            _context.SaveChanges();
            return RedirectToAction("Customer", "Customers");
        }
    }

}