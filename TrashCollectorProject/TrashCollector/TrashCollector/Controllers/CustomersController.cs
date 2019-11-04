using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrashCollector.Models;

namespace TrashCollector.Controllers
{
    public class CustomersController : Controller
    {
        ApplicationDbContext context;

        //CONSTRUCTOR
        public CustomersController()
        {
            context = new ApplicationDbContext();
        }

        // GET: Customers
        public ActionResult Index()
        {
            //code needed
            return View();
        }

        // GET: Customers/Details/5
        public ActionResult Details(int id)
        {
            Customer customer = context.Customers.Where(c => c.Id == id).SingleOrDefault();
            return View(customer);
        }

        // GET: Customers/Create
        public ActionResult Create()
        {
            Customer customer = new Customer();
            return View(customer);
        }

        // POST: Customers/Create
        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            try
            {
                //code needed
                //test #5 for pull/push commands

                context.Customers.Add(customer);
                context.SaveChanges();
                return RedirectToAction("code needed");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customers/Edit/5
        public ActionResult Edit(int id)
        {
            Customer customer = context.Customers.Where(c => c.Id == id).SingleOrDefault();
            return View(customer);
        }

        // POST: Customers/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Customer customer)
        {
            try
            {
                Customer editedCustomer = context.Customers.Find(id);
                editedCustomer.FirstName = customer.FirstName;
                editedCustomer.LastName = customer.LastName;
                editedCustomer.StreetAddress = customer.StreetAddress;
                editedCustomer.CityName = customer.CityName;
                editedCustomer.StateName = customer.StateName;
                editedCustomer.ZipCode = customer.ZipCode;
                //might have to add other columns as I get further into the userStories
                context.SaveChanges();

                return RedirectToAction("code needed");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customers/Delete/5
        public ActionResult Delete(int id)
        {
            Customer customer = context.Customers.Where(c => c.Id == id).SingleOrDefault();
            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Customer customer)
        {
            try
            {
                context.Customers.Remove(context.Customers.Find(id));
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}