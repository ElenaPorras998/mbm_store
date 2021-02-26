using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Invoice
    {
        // fields
        private decimal totalPrice;

        // properties
        public int InvoiceId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice {
            get
            {
                decimal p = 0M;

                foreach(OrderItem item in OrderItems)
                {
                    p = p + item.TotalPrice;
                }
                totalPrice = p;
                return totalPrice;
            }
        }
        public Customer Customer { get; set; }
        public List<OrderItem> OrderItems = new List<OrderItem>();

        public Invoice(int invoiceId, DateTime orderDate, Customer customer)
        {
            InvoiceId = invoiceId;
            OrderDate = orderDate;
            Customer = customer;
        }

        public void AddOrderItem(Product product, int quantity)
        {
            OrderItem item = new OrderItem(product, quantity);
            OrderItems.Add(item);
        }
    }
}
