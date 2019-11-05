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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for BrontowurstCustom.xaml
    /// </summary>
    public partial class BrontowurstCustom : Page
    {
        public BrontowurstCustom()
        {
            InitializeComponent();
        }

        
        private void OnHoldBun(object sender, RoutedEventArgs e)
        {

        }

        private void OnHoldOnions(object sender, RoutedEventArgs e)
        {

        }

        private void OnHoldPeppers(object sender, RoutedEventArgs e)
        {

        }

        private void OnHoldDone(object sender, RoutedEventArgs e)
        {
           
                NavigationService.Navigate(new CustomizeCombo());
            
        }
    }
}
