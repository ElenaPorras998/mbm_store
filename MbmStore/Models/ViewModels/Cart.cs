using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models.ViewModels
{
    public class Cart
    {
        // fields
        private List<CartLine> cartLines = new List<CartLine>();

        // properties
        public int TotalPrice { get; }

        public Cart() { }

        public virtual void AddItem(Product product, int quantity)
        {
            CartLine line = cartLines.Where(p => p.Product.ProductId == product.ProductId).FirstOrDefault();

            if (line == null)
            {
                cartLines.Add(new CartLine { Product = product, Quantity = quantity });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public virtual void RemoveLine(Product product) => cartLines.RemoveAll(i => i.Product.ProductId == product.ProductId);

        public decimal ComputeTotalValue() => cartLines.Sum(e => e.Product.Price * e.Quantity);
        public virtual void Clear() => cartLines.Clear();
        public List<CartLine> CartLines => cartLines;
    }

    public class CartLine
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
