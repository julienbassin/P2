using System.Collections.Generic;
using System.Linq;
using System;

namespace P2FixAnAppDotNetCode.Models
{
    /// <summary>
    /// The Cart class
    /// </summary>
    public class Cart : ICart
    {
        /// <summary>
        /// Read-only property for dispaly only
        /// </summary>
        public IEnumerable<CartLine> Lines => GetCartLineList();

        /// <summary>
        /// Return the actual cartline list
        /// </summary>
        /// <returns></returns>
        private List<CartLine> GetCartLineList()
        {
            return new List<CartLine>();
        }

        /// <summary>
        /// Adds a product in the cart or increment its quantity in the cart if already added
        /// </summary>//
        public void AddItem(Product product, int quantity)
        {
            // TODO implement the method
            //List<Product> Listproduct = new List<Product>();
            CartLine currentProduct = new CartLine(product);
            if (quantity > 0)
            {
                if (Lines.Contains(currentProduct))
                {
                    currentProduct.Quantity += quantity;
                    currentProduct.Product.Stock -= quantity;
                }

                else
                {
                    currentProduct.Quantity += quantity;
                    Lines.Append(currentProduct);
                }
            }
        }

        /// <summary>
        /// Removes a product form the cart
        /// </summary>
        public void RemoveLine(Product product) =>
            GetCartLineList().RemoveAll(l => l.Product.Id == product.Id);

        /// <summary>
        /// Get total value of a cart
        /// </summary>
        public double GetTotalValue()
        {
            // TODO implement the method
            double total = 0;
            foreach (var item in GetCartLineList())
            {
                total += item.Product.Price * item.Quantity;
            }
            return total;
        }

        /// <summary>
        /// Get average value of a cart
        /// </summary>
        public double GetAverageValue()
        {
            // TODO implement the method
            double totalAverage = 0;
            double totalQuantity = 0;
            double average = 0;
            foreach (var item in GetCartLineList())
            {
                Console.WriteLine($"{item.Product} ==> ${item.Quantity}");
                totalAverage += (item.Product.Price * item.Quantity);
                totalQuantity += item.Quantity;
            }
            average = totalAverage / totalQuantity;
            return average;
        }

        /// <summary>
        /// Looks after a given product in the cart and returns if it finds it
        /// </summary>
        public Product FindProductInCartLines(int productId)
        {
            // TODO implement the method
            return null;
        }

        /// <summary>
        /// Get a specifid cartline by its index
        /// </summary>
        public CartLine GetCartLineByIndex(int index)
        {
            return Lines.ToArray()[index];
        }

        /// <summary>
        /// Clears a the cart of all added products
        /// </summary>
        public void Clear()
        {
            List<CartLine> cartLines = GetCartLineList();
            cartLines.Clear();
        }
    }

    public class CartLine
    {

        public CartLine(Product product)
        {
            this.Product = product;
        }

        public CartLine(Product product, int quantity)
        {
            this.Product = product;
            this.Quantity = quantity;
        }

        public int OrderLineId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
