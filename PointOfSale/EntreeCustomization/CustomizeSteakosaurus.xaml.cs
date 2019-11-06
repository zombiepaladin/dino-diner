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
    /// Interaction logic for CustomizeSteakosaurus.xaml
    /// </summary>
    public partial class CustomizeSteakosaurus : Page
    {
        private SteakosaurusBurger steak;
        private CretaceousCombo combo;

        public CustomizeSteakosaurus(SteakosaurusBurger s)
        {
            steak = s;
            InitializeComponent();
        }
        public CustomizeSteakosaurus(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
        }

        private void HoldBunClicked(object sender, RoutedEventArgs e)
        {
            steak?.HoldBun();
            if(this.combo != null)
            {
                if(this.combo.Entree is SteakosaurusBurger sb)
                {
                    sb.HoldBun();
                }
            }
        }

        private void HoldKetchupClicked(object sender, RoutedEventArgs e)
        {
            steak?.HoldKetchup();
            if(this.combo != null)
            {
                if(this.combo.Entree is SteakosaurusBurger sb)
                {
                    sb.HoldKetchup();
                }
            }
        }

        private void HoldMustardClicked(object sender, RoutedEventArgs e)
        {
            steak?.HoldMustard();
            if (this.combo != null)
            {
                if(this.combo.Entree is SteakosaurusBurger sb)
                {
                    sb.HoldMustard();
                }
            }
        }

        private void HoldPickleClicked(object sender, RoutedEventArgs e)
        {
            steak?.HoldPickle();
            if(this.combo != null)
            {
                if(this.combo.Entree is SteakosaurusBurger sb)
                {
                    sb.HoldPickle();
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
    }
}
