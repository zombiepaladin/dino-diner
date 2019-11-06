using DinoDiner.Menu;
using DinoDiner.Menu.Entrees;
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

namespace PointOfSale.EntreeCustomization
{
    /// <summary>
    /// Interaction logic for CustomizeBrontowurst.xaml
    /// </summary>
    public partial class CustomizeBrontowurst : Page
    {
        private Brontowurst bronto;
        private CretaceousCombo combo;

        public CustomizeBrontowurst(Brontowurst b)
        {
            bronto = b;
            InitializeComponent();
        }
        public CustomizeBrontowurst(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
        }

        private void HoldBunClicked(object sender, RoutedEventArgs e)
        {
            bronto?.HoldBun();
            if (this.combo != null)
            {
                if (this.combo.Entree is Brontowurst sb)
                {
                    sb.HoldBun();
                }
            }
        }

        

        private void DoneClicked(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }

        private void BackClicked(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack) NavigationService.GoBack();
            else NavigationService.Navigate(new MenuCategorySelection());
        }

        private void HoldOnionClicked(object sender, RoutedEventArgs e)
        {
            bronto?.HoldOnion();
            if (this.combo != null)
            {
                if (this.combo.Entree is Brontowurst sb)
                {
                    sb.HoldOnion();
                }
            }
        }

        
        private void HoldPeppersClicked(object sender, RoutedEventArgs e)
        {
            bronto?.HoldPeppers();
            if (this.combo != null)
            {
                if (this.combo.Entree is Brontowurst sb)
                {
                    sb.HoldPeppers();
                }
            }
        }
    }
}
