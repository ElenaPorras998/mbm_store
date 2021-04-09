using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Product
    {
        // fields
        private decimal price;

        // properties
        public int ProductId { get; set; }
        public string Category { get; set; }
        public string Title { get; }
        public string ImageFileName { get; set; }
        public decimal Price
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Price is not accepted");
                }
                else
                {
                    price = value;
                }
            }
            get { return price; }
        }

        public Product() { }

        public Product(int productId, string title, decimal price)
        {
            ProductId = productId;
            Title = title;
            this.price = price;
        }
        public Product(int productId, string title, decimal price, string file)
        {
            ProductId = productId;
            Title = title;
            this.price = price;
            ImageFileName = file;
        }
    }
}
