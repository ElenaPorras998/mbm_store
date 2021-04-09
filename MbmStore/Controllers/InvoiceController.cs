using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MbmStore.Infrastructure;
using Microsoft.AspNetCore.Mvc.Rendering;
using MbmStore.Models;

namespace MbmStore.Controllers
{
    public class InvoiceController : Controller
    {
        public IActionResult Index()
        {
            List<SelectListItem> customers = new List<SelectListItem>();
            ViewBag.Invoices = Repository.Invoices;

            foreach (Invoice invoice in Repository.Invoices)
            {
                customers.Add(new SelectListItem { Text = invoice.Customer.FirstName + " " + invoice.Customer.LastName, Value = invoice.Customer.CustomerId.ToString() });
            }

            // removes duplicate entries with same ID from a IEnumerable
            customers = customers.GroupBy(x => x.Value).Select(y => y.First()).OrderBy(z => z.Text).ToList<SelectListItem>();
            ViewBag.Customers = customers;

            return View();
        }

        [HttpPost]
        public IActionResult Index(int? customer)
        {
            List<SelectListItem> customers = new List<SelectListItem>();
            List<Invoice> invoices = Repository.Invoices;

            foreach (Invoice invoice in Repository.Invoices)
            {
                customers.Add(new SelectListItem { Text = invoice.Customer.FirstName + " " + invoice.Customer.LastName, Value = invoice.Customer.CustomerId.ToString() });
            }

            // removes duplicate entries with same ID from a IEnumerable
            customers = customers.GroupBy(x => x.Value).Select(y => y.First()).OrderBy(z => z.Text).ToList<SelectListItem>();


            if (customer != null)
            {
                // select invoices for a customer with linq
                invoices = Repository.Invoices.Where(r => r.Customer.CustomerId == customer)
               .ToList(); ;
            }

            // generate the dropdown list
            foreach (Invoice invoice in invoices)
            {
                SelectListItem selectListItem = new SelectListItem
                {
                    Text = invoice.Customer.FirstName + " " + invoice.Customer.LastName,
                    Value = invoice.Customer.CustomerId.ToString()
                };
                if (invoice.Customer.CustomerId == customer)
                {
                    selectListItem.Selected = true;
                }
                customers.Add(selectListItem);
            }

            ViewBag.Customers = customers;
            ViewBag.Invoices = invoices;

            return View();
        }
    }
}
