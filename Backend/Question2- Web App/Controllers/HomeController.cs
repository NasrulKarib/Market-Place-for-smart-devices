using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Question2__Web_App.Models;
using System.Diagnostics;

namespace Question2__Web_App.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        private readonly CustomerDBContext context;

        public HomeController(ILogger<HomeController> logger, CustomerDBContext context)
        {
            _logger = logger;
            this.context = context;
        }

        public IActionResult Index()
        {
            var customers = context.Customers.ToList();
            return View(customers);
        }

        public IActionResult Add_Customer()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Add_Customer(Customer customer)
        {
            if (ModelState.IsValid)
            {
                context.Customers.Add(customer);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customer);

        }

        [HttpPost]
        public IActionResult Delete(int Id)
        {

            var customer = context.Customers.FirstOrDefault(c => c.Id== Id);

            if (customer == null)
            {
                return NotFound();
            }


            context.Customers.Remove(customer);


            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Update_Customer(int? customerId)
        {
            var customer = context.Customers.FirstOrDefault(c => c.Id == customerId);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }


        [HttpPost]
        public IActionResult Update_Customer(int? Id, Customer customer)
        {
            Console.WriteLine(Id);
            if (ModelState.IsValid)
            {

                var existingCustomer = context.Customers.Find(Id);
                //Console.WriteLine(existingCustomer);
                if (existingCustomer != null)
                {
                    existingCustomer.Name = customer.Name;
                    existingCustomer.Details = customer.Details;
                    existingCustomer.Age = customer.Age;
                    existingCustomer.Mail = customer.Mail;

                    context.Update(existingCustomer);
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }

            return View(customer);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
