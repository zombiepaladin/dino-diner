using System;
using System.Collections.Generic;
using System.Text;
/* IMenuItem.cs
 * Author: Thomas Paul
 */
namespace DinoDiner.Menu
{
    public interface IMenuItem
    {
       double Price { get;  }

        uint Calories { get; }

        List<string> Ingredients { get; }
    }
}
