using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        /// <summary>
        /// Accessor for
        /// </summary>
        List<IOrderItem> items { get; set; }
        Order ord = new Order();


        public NavigationService NavigationService {get;set;}
        public OrderControl()
        {

            
            InitializeComponent();
           
            OrderItems.ItemsSource = items;

        }

        /// <summary>
        /// for  seeing selection changed 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
            if (OrderItems.SelectedItems is Side side)
            {

                
                NavigationService?.Navigate(new SideSelection(side));
            }


        }

        /// <summary>
        /// changes on data conext when changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnDataContextChanged(object sender, EventArgs e)
        {
            if (DataContext is Order order)
            {

                OrderItems.ItemsSource = order.Items;

            }

        }



        public void OnRemoveItem(object sender, RoutedEventArgs args)
        {
           // if(DataContext is Order order)
            //{
                if(OrderItems.SelectedItem is IOrderItem item)
                {
                    ord.Remove(item);
                }
               
          //  }
            

        }

        
    }
}
