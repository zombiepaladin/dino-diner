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

        public Side Side { get; set; }

        public SideSelection()
        {
            InitializeComponent();
        }

        private void SelectSide(Side side)
        {


            if (DataContext is Order order)
            {
                
                order.Items.Add(new Fryceritops());
                this.Side = side;

            }


        }

        public SideSelection(Side side)
        {
            InitializeComponent();
            Side = side;
        }


        private void SelectSize(DinoDiner.Menu.Size size)
        {
            if(Side !=null)
            this.Side.Size = size;
        }



        private void OnSelectFryceritops(object sender, RoutedEventArgs e)
        {
            SelectSide(new Fryceritops());
        }

        private void OnSelectMac(object sender, RoutedEventArgs e)
        {
            SelectSide(new MeteorMacAndCheese());
        }

        private void OnSelectMezzorella(object sender, RoutedEventArgs e)
        {
            SelectSide(new MezzorellaSticks());
        }

        private void OnSelectTriceritops(object sender, RoutedEventArgs e)
        {
            SelectSide(new Triceritots());
        }


        protected void OnSelectLarge(object sender, RoutedEventArgs args)
        {

            SelectSize(DinoDiner.Menu.Size.Large);
        }
        protected void OnSelectMedium(object sender, RoutedEventArgs args)
        {

            SelectSize(DinoDiner.Menu.Size.Medium);
        }

        protected void OnSelectSmall(object sender, RoutedEventArgs args)
        {

            SelectSize(DinoDiner.Menu.Size.Small);
        }


    }
}
