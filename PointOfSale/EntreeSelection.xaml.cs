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
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {

        /// <summary>
        /// accessor to entree class
        /// </summary>
        public Entree Entree { get; set; }
        public EntreeSelection()
        {
            InitializeComponent();
        }

       


        /// <summary>
        /// adds the selected entree
        /// </summary>
        /// <param name="entree"></param>
        private void SelectEntree(Entree entree)
        {


            if (DataContext is Order order)
            {

                order.Add(entree);
                this.Entree = entree;

            }


        }
        /// <summary>
        /// adds entree to Entree
        /// </summary>
        /// <param name="entree"></param>
        public EntreeSelection(Entree entree)
        {
            InitializeComponent();
            Entree = entree;
        }



        /// <summary>
        /// Button for adding PrehistoricPBJ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void button_PrehistoricPBJ_click(object sender, RoutedEventArgs args)
        {
            SelectEntree(new PrehistoricPBJ());
            NavigationService.Navigate(new PrehistoricPBJCustom(new PrehistoricPBJ()));
        }

        /// <summary>
        /// Button for adding BrontoWurst
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void button_BrontoWurst_Click(object sender, RoutedEventArgs e)
        {
            SelectEntree(new Brontowurst());
            NavigationService.Navigate(new BrontowurstCustom());
        }
        /// <summary>
        /// Button for adding VelociWrap
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void button_VelociWrap_Click(object sender, RoutedEventArgs e)
        {
            SelectEntree(new VelociWrap());
            NavigationService.Navigate(new VelociWarpCustom());
        }
        /// <summary>
        /// Button for adding TRexKingBurger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void button_TRexKingBurger_Click(object sender, RoutedEventArgs e)
        {
            SelectEntree(new TRexKingBurger());
            NavigationService.Navigate(new TRexKingBurgerCustom());
        }

        /// <summary>
        /// Button for adding DinoNuggets
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void button_DinoNuggets_Click(object sender, RoutedEventArgs e)
        {
            SelectEntree(new DinoNuggets());
            NavigationService.Navigate(new DinoNuggetsCustom());
        }

        /// <summary>
        /// Button for adding SteakosaurusBuger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void button_SteakosaurusBuger_Click(object sender, RoutedEventArgs e)
        {
            SelectEntree(new SteakosaurusBurger());
            NavigationService.Navigate(new SteakasaurusBurgerCustom());
        }
        /// <summary>
        /// Button for adding PterodactylWings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void button_PterodactylWings_Click(object sender, RoutedEventArgs e)
        {
            SelectEntree(new PterodactylWings());
            NavigationService.Navigate(new PterodactyWingsCustom());
        }
    }
}
