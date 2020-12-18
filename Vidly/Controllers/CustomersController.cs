using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Configuration;
using System.Web.Mvc;
using Vidly.Models;
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


    }

}