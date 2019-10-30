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
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {

        /// <summary>
        /// Acsessor to Side class
        /// </summary>
        public Side Side { get; set; }

        /// <summary>
        /// Maine constructor
        /// </summary>
        public SideSelection()
        {
            InitializeComponent();
            
        }

        /// <summary>
        /// adds the selected side to list 
        /// </summary>
        /// <param name="side"></param>
        private void SelectSide(Side side)
        {


            if (DataContext is Order order)
            {
                
                order.Add(side);
                this.Side = side;

            }


        }

        /// <summary>
        /// adds side to Side and is a second constructor
        /// </summary>
        /// <param name="side"></param>
        public SideSelection(Side side)
        {
            InitializeComponent();
            Side = side;
        }

        /// <summary>
        /// selects size of the side
        /// </summary>
        /// <param name="size"></param>
        private void SelectSize(DinoDiner.Menu.Size size)
        {
            if(Side !=null)
            this.Side.Size = size;
        }


        /// <summary>
        /// adds selected side to list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSelectFryceritops(object sender, RoutedEventArgs e)
        {
            SelectSide(new Fryceritops());
        }

        /// <summary>
        /// adds selected side to list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSelectMac(object sender, RoutedEventArgs e)
        {
            SelectSide(new MeteorMacAndCheese());
        }

        /// <summary>
        /// adds selected side to list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSelectMezzorella(object sender, RoutedEventArgs e)
        {
            SelectSide(new MezzorellaSticks());
        }

        /// <summary>
        /// adds selected side to list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSelectTriceritops(object sender, RoutedEventArgs e)
        {
            SelectSide(new Triceritots());
        }

        /// <summary>
        /// adds selected side to list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void OnSelectLarge(object sender, RoutedEventArgs args)
        {

            SelectSize(DinoDiner.Menu.Size.Large);
        }

        /// <summary>
        /// adds selected side to list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void OnSelectMedium(object sender, RoutedEventArgs args)
        {

            SelectSize(DinoDiner.Menu.Size.Medium);
        }


        /// <summary>
        /// adds selected side to list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void OnSelectSmall(object sender, RoutedEventArgs args)
        {

            SelectSize(DinoDiner.Menu.Size.Small);
        }


    }
}
