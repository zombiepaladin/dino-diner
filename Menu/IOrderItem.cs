using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
/* IOrderItem.cs
 * Author: Thomas Paul
 */
namespace DinoDiner.Menu
{
    public interface IOrderItem : INotifyPropertyChanged
    {
        double Price { get; }

        string Description { get; }

         string[] Special { get; }
    }
}
