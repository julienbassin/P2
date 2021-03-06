﻿using System.Collections.Generic;
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
        public List<CartLine> Lines => GetCartLineList();
        public List<CartLine> currentCartList;
        /// <summary>
        /// Return the actual cartline list
        /// </summary>
        /// <returns></returns>
        public List<CartLine> GetCartLineList()
        {
            if (currentCartList == null)
            {
                this.currentCartList = new List<CartLine>();
            }
            return this.currentCartList;
        }

        /// <summary>
        /// Adds a product in the cart or increment its quantity in the cart if already added
        /// </summary>//
        public void AddItem(Product product, int quantity)
        {
            // TODO implement the method
           

            CartLine cartline = Lines.Where(p => p.Product.Id == product.Id).FirstOrDefault();

            if(cartline != null)
            {
                cartline.Quantity += quantity;
            }
            else
            {
                CartLine newCartLine = new CartLine();
                newCartLine.Product = product;
                newCartLine.Quantity = quantity;
                GetCartLineList().Add(newCartLine);
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
            foreach (var item in Lines)
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
            double totalAverage = 0.0;
            double totalQuantity = 0;
            double average = 0.0;
            if(Lines.Any() == false)
            {
                return average;
            }
            else
            {
                foreach (var item in Lines)
                {
                    totalAverage += (item.Product.Price * item.Quantity);
                    totalQuantity += item.Quantity;
                }
                average = totalAverage / totalQuantity;
                return average;
            }
        }

        /// <summary>
        /// Looks after a given product in the cart and returns if it finds it
        /// </summary>
        public Product FindProductInCartLines(int productId)
        {
            // TODO implement the method
            Product productById = (Product) GetCartLineList().Where(p => p.Product.Id == productId).Select(cartline => cartline.Product).FirstOrDefault();
            return productById;
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
        public int OrderLineId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
