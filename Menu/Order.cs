﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;
/* Order.cs
 * Author: Thomas Paul
 */
namespace DinoDiner.Menu
{
    /// <summary>
    /// Represents order
    /// </summary>
    public class Order : INotifyPropertyChanged
    {
        
        private List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// List of items
        /// </summary>
        public IOrderItem[] Items
        {
            get { return items.ToArray(); }
        }

        /// <summary>
        /// Gets the subtotal
        /// </summary>
        public double SubtotalCost
        {
            get
            {
                double subtotal = 0;
                foreach (IOrderItem item in Items)
                {
                    subtotal += item.Price;
                }
                if (subtotal < 0) return 0.00;
                else return Math.Round(subtotal, 2);

            }
        }

    


        //private backing variable
        private double salesTaxRate = 0.07;
        /// <summary>
        /// Gets/sets sales tax rate
        /// </summary>
        public double SalesTaxRate
        {
            get { return salesTaxRate; }
            protected set
            {
                salesTaxRate = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxRate"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            }
        }

        /// <summary>
        /// Gets total amount of order
        /// </summary>
        public double SalesTaxCost
        {
            get
            {
                return Math.Round(SalesTaxRate * SubtotalCost, 2);
            }
        }

        /// <summary>
        /// Gets total cost of the order
        /// </summary>
        public double TotalCost
        {
            get { return Math.Round(this.SubtotalCost + SalesTaxCost, 2); }
        }

        public Order()
        {
        }

        private void NotifyIfPropertyChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }

        /// <summary>
        /// Event handler for property changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Event handler for when 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            NotifyIfPropertyChanged();
        }

        /// <summary>
        /// Adds an item 
        /// </summary>
        /// <param name="item">The order item to be added to the order</param>
        public void Add(IOrderItem item)
        {
            items.Add(item);
            item.PropertyChanged += OnPropertyChanged;
            NotifyIfPropertyChanged();
        }

        /// <summary>
        /// Removes an item 
        /// </summary>
        /// <param name="item"></param>
        public bool Remove(IOrderItem item)
        {
            bool removed = items.Remove(item);
            if (removed)
            {
                NotifyIfPropertyChanged();
            }
            return removed;
        }
    }
}