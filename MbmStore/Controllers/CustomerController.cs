using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace MbmStore.Controllers
{
    public class CustomerController : Controller
    {
        private List<Customer> customers = new List<Customer>();
        public IActionResult Index()
        {
            Customer c1 = new Customer(00001, "Susanna", "Porras", "Jardines de S.I., 26-62", "01016", "Guatemala City");
            c1.AddPhone("+502 50552657");
            c1.Birthday = new DateTime(1996, 7, 20);

            Customer c2 = new Customer(00002, "Niels", "Jensen", "Haslecentervej, 92", "8210", "Aarhus V");
            c2.AddPhone("+45 91953438");
            c2.Birthday = new DateTime(1993, 6, 30);

            customers.Add(c1);
            customers.Add(c2);

            ViewBag.Customers = customers;

            return View();
        }
    }
}
