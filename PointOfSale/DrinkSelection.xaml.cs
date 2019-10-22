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
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        public DrinkSelection()
        {
            InitializeComponent();
            RemoveButtons();
        }

        

        

        void RemoveButtons()
        {
            Radio.Children.Remove(Lemon);
            Radio.Children.Remove(Flavor);
            Radio.Children.Remove(Decaf);
            Radio.Children.Remove(Sweet);
            
        }

        private void TyrannoteaButton_Click(object sender, RoutedEventArgs e)
        {
            RemoveButtons();
            Radio.Children.Add(Lemon);
            Radio.Children.Add(Sweet);
            
        }

        private void SodasaurusButton_Click(object sender, RoutedEventArgs e)
        {
            RemoveButtons();
            Radio.Children.Add(Flavor);
            
        }

        

        private void JurassicButton1_Click(object sender, RoutedEventArgs e)
        {
            RemoveButtons();
            Radio.Children.Add(Decaf);
        }

        private void WaterButton_Click(object sender, RoutedEventArgs e)
        {
            RemoveButtons();
            Radio.Children.Add(Lemon);
        }

        private void FlavorButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new FlavorSelection());
        }
    }
}
