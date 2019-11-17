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
/* MenuCategorySelection.cs
 * Author: Thomas Paul
 */
namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuCategorySelection.xaml
    /// </summary>
    public partial class MenuCategorySelection : Page
    {
        public MenuCategorySelection()
        {
            InitializeComponent();
        }

        private void ComboClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ComboSelection());
        }
        private void EntreeClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EntreeSelection());
        }
        private void DrinkClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DrinkSelection());
        }
        private void SideClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SideSelection());
        }
        



    }
}