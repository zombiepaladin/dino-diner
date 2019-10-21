using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DinoDiner.Menu
{
    public class Order
    {
        ObservableCollection<IOrderItem> items = new ObservableCollection<IOrderItem>();
    }
}
