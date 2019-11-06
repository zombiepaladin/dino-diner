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
using DinoDiner.Menu.Entrees;
using PointOfSale.EntreeCustomization;
/* CustomizeCombo.cs
* Author: Thomas Paul
*/
namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {
        private CretaceousCombo c;

        public CustomizeCombo()
        {
            InitializeComponent();
        }

        public CustomizeCombo(CretaceousCombo combo)
        {
            InitializeComponent();
            this.c = combo;
        }

        private void DrinkClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DrinkSelection(c.Drink));
            NavigationService.Navigate(new CustomizeCombo());
        }
        private void SideClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SideSelection(c.Side));
            NavigationService.Navigate(new CustomizeCombo());
        }

        private void EntreeButton_Click(object sender, RoutedEventArgs e)
        {
            if (c.Entree is Brontowurst b)
            {
                NavigationService.Navigate(new CustomizeBrontowurst(c));
            }
            if (c.Entree is DinoNuggets d)
            {
                NavigationService.Navigate(new CustomizeDinoNuggets(c));
            }
            if (c.Entree is PrehistoricPBJ pbj)
            {
                NavigationService.Navigate(new CustomizePrehistoricPBJ(c));
            }
            if (c.Entree is SteakosaurusBurger s)
            {
                NavigationService.Navigate(new CustomizeSteakosaurus(c));
            }
            if (c.Entree is TRexKingBurger t)
            {
                NavigationService.Navigate(new CustomizeTRexKingBurger(c));
            }
            if (c.Entree is VelociWrap v)
            {
                NavigationService.Navigate(new CustomizeVelociWrap(c));
            }
            if (c.Entree is PterodactylWings wings)
            {

            }


        }
        private void SmallClicked(object sender, RoutedEventArgs args)
        {
            c.Size = DinoDiner.Menu.Size.Small;
        }

        private void MedClicked(object sender, RoutedEventArgs args)
        {
            c.Size = DinoDiner.Menu.Size.Medium;
        }

        private void LargeClicked(object sender, RoutedEventArgs args)
        {
            c.Size = DinoDiner.Menu.Size.Large;
        }
    }
}
