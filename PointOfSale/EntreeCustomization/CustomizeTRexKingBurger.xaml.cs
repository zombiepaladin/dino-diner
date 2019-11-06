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
    /// Interaction logic for CustomizeTRexKingBurger.xaml
    /// </summary>
    public partial class CustomizeTRexKingBurger : Page
    {
        private TRexKingBurger rex;
        private CretaceousCombo combo;

        public CustomizeTRexKingBurger(TRexKingBurger t)
        {
            this.rex = t;
            InitializeComponent();
        }

        public CustomizeTRexKingBurger(CretaceousCombo combo)
        {
            this.combo = combo;
            InitializeComponent();
        }
        public CustomizeTRexKingBurger()
        {
            InitializeComponent();
        }

        private void HoldBunClicked(object sender, RoutedEventArgs args)
        {
            rex?.HoldBun();
            if (this.combo != null)
            {
                if (this.combo.Entree is TRexKingBurger tb)
                {
                    tb.HoldBun();
                }
            }
        }

        private void HoldLettuceClicked(object sender, RoutedEventArgs args)
        {
            rex?.HoldLettuce();
            if (this.combo != null)
            {
                if (this.combo.Entree is TRexKingBurger tb)
                {
                    tb.HoldLettuce();
                }
            }
        }

        private void HoldKetchupClicked(object sender, RoutedEventArgs args)
        {
            rex?.HoldKetchup();
            if (this.combo != null)
            {
                if (this.combo.Entree is TRexKingBurger tb)
                {
                    tb.HoldKetchup();
                }
            }
        }

        private void HoldMayoClicked(object sender, RoutedEventArgs args)
        {
            rex?.HoldMayo();
            if (this.combo != null)
            {
                if (this.combo.Entree is TRexKingBurger tb)
                {
                    tb.HoldMayo();
                }
            }
        }
        private void HoldMustardClicked(object sender, RoutedEventArgs args)
        {
            rex?.HoldMustard();
            if (this.combo != null)
            {
                if (this.combo.Entree is TRexKingBurger tb)
                {
                    tb.HoldMustard();
                }
            }
        }

        private void HoldOnionClicked(object sender, RoutedEventArgs args)
        {
            rex?.HoldOnion();
            if (this.combo != null)
            {
                if (this.combo.Entree is TRexKingBurger tb)
                {
                    tb.HoldOnion();
                }
            }
        }

        private void HoldPickleClicked(object sender, RoutedEventArgs args)
        {
            rex?.HoldPickle();
            if (this.combo != null)
            {
                if (this.combo.Entree is TRexKingBurger tb)
                {
                    tb.HoldPickle();
                }
            }
        }

        private void HoldTomatoClicked(object sender, RoutedEventArgs args)
        {
            rex?.HoldTomato();
            if (this.combo != null)
            {
                if (this.combo.Entree is TRexKingBurger tb)
                {
                    tb.HoldTomato();
                }
            }
        }

        private void DoneClicked(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }

        private void BackClicked(object sender, RoutedEventArgs args)
        {
            if (NavigationService.CanGoBack) NavigationService.GoBack();
            else NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}

