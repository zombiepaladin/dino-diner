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
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {

        public Drinks Drinks { get; set; }
        /// <summary>
        /// Innitilizes window
        /// </summary>
        public DrinkSelection()
        {
            InitializeComponent();
            addLemon.IsEnabled = false;
            addSweet.IsEnabled = false;
            holdIce.IsEnabled = false;
            OnFlavor.IsEnabled = false;
        }
        /// <summary>
        /// Navigates to the desired window
        /// </summary>
        /// <param name="sender"> sends where it was clicked</param>
        /// <param name="e">and the event argument</param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FlavorSelection fl = new FlavorSelection();
            NavigationService.Navigate(fl);
        }


        /// <summary>
        /// adds the selected side to list 
        /// </summary>
        /// <param name="side"></param>
        private void SelectDrinks(Drinks drinks)
        {


            if (DataContext is Order order)
            {

                order.Add(drinks);
                this.Drinks = drinks;

            }


        }

        /// <summary>
        /// adds side to Side and is a second constructor
        /// </summary>
        /// <param name="side"></param>
        public DrinkSelection(Drinks drinks)
        {
            InitializeComponent();
            Drinks = drinks;
        }

        /// <summary>
        /// selects size of the side
        /// </summary>
        /// <param name="size"></param>
        private void SelectSize(DinoDiner.Menu.Size size)
        {
            if (Drinks != null)
                this.Drinks.Size = size;
        }





        /// <summary>
        /// adds this item to list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSodaSaurus(object sender, RoutedEventArgs e)
        {
            SelectDrinks(new Sodasaurus());
            addLemon.IsEnabled = false;
            addSweet.IsEnabled = false;
            holdIce.IsEnabled = true;
            OnFlavor.IsEnabled = true;
        }

        /// <summary>
        /// adds this item to list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnTyrannotea(object sender, RoutedEventArgs e)
        {
            SelectDrinks(new Tyrannotea());
            addLemon.IsEnabled = true;
            addSweet.IsEnabled = true;
            holdIce.IsEnabled = true;
            
        }

        /// <summary>
        /// adds this item to list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnWater(object sender, RoutedEventArgs e)
        {
            SelectDrinks(new Water());
            addLemon.IsEnabled = true;
            addSweet.IsEnabled = false;
            holdIce.IsEnabled = true;


        }

        /// <summary>
        /// adds this item to list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnJurrasicJava(object sender, RoutedEventArgs e)
        {
            SelectDrinks(new JurassicJava());
            addLemon.IsEnabled = false;
            addSweet.IsEnabled = false;
            holdIce.IsEnabled = false;
        }

        /// <summary>
        /// adds this item to list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSelectedSmall(object sender, RoutedEventArgs e)
        {
            SelectSize(DinoDiner.Menu.Size.Small);

        }

        /// <summary>
        /// adds this item to list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSelectedMedium(object sender, RoutedEventArgs e)
        {
            SelectSize(DinoDiner.Menu.Size.Medium);
        }

        private void OnSelectedLarge(object sender, RoutedEventArgs e)
        {
            SelectSize(DinoDiner.Menu.Size.Large);
        }

        /// <summary>
        /// adds this item to list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSelectedAddSuger(object sender, RoutedEventArgs e)
        {
            
        }

        private void OnSelectedHoldIce(object sender, RoutedEventArgs e)
        {
           
        }

        /// <summary>
        /// adds this item to list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSelectedAddLemon(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// navigates to select flavor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSelectedFlavor(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new FlavorSelection());
        }
    }
}
