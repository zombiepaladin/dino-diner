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
/* ComboSelection.cs
 * Author: Thomas Paul
 */
namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        public CretaceousCombo Combo { get; set; }
        public ComboSelection()
        {
            InitializeComponent();
        }

        public ComboSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            this.Combo = combo;
        }

        private void SelectCombo(CretaceousCombo c)
        {
            if (DataContext is Order order)
            {
                order.Add(c);
                this.Combo = c;
            }
        }
        private void BrontowurstCombo(object sender, RoutedEventArgs e)
        {
            CretaceousCombo combo = new CretaceousCombo(new Brontowurst());
            SelectCombo(combo);
            NavigationService.Navigate(new CustomizeCombo(combo));
        }
        private void DinoNuggetsCombo(object sender, RoutedEventArgs e)
        {
            CretaceousCombo combo = new CretaceousCombo(new DinoNuggets());
            SelectCombo(combo);
            NavigationService.Navigate(new CustomizeCombo(combo));
        }
        private void PrehistoricPBJCombo(object sender, RoutedEventArgs e)
        {
            CretaceousCombo combo = new CretaceousCombo(new PrehistoricPBJ());
            SelectCombo(combo);
            NavigationService.Navigate(new CustomizeCombo(combo));
        }
        private void PterodactylWingsCombo(object sender, RoutedEventArgs e)
        {
            CretaceousCombo combo = new CretaceousCombo(new PterodactylWings());
            SelectCombo(combo);
            NavigationService.Navigate(new CustomizeCombo(combo));
        }
        private void SteakosaurusBurgerCombo(object sender, RoutedEventArgs e)
        {
            CretaceousCombo combo = new CretaceousCombo(new SteakosaurusBurger());
            SelectCombo(combo);
            NavigationService.Navigate(new CustomizeCombo(combo));
        }
        private void TRexKingburgerCombo(object sender, RoutedEventArgs e)
        {
            CretaceousCombo combo = new CretaceousCombo(new TRexKingBurger());
            SelectCombo(combo);
            NavigationService.Navigate(new CustomizeCombo(combo));
        }
        private void VelociWrapCombo(object sender, RoutedEventArgs e)
        {
            CretaceousCombo combo = new CretaceousCombo(new VelociWrap());
            SelectCombo(combo);
            NavigationService.Navigate(new CustomizeCombo(combo));
        }

        private void DoneClicked(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }


    }
}
