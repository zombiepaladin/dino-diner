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
    /// Interaction logic for CustomizePrehistoricPBJ.xaml
    /// </summary>
    public partial class CustomizePrehistoricPBJ : Page
    {
        private PrehistoricPBJ pbj;
        private CretaceousCombo combo;

        public CustomizePrehistoricPBJ()
        {
            InitializeComponent();
        }
        public CustomizePrehistoricPBJ(PrehistoricPBJ pbj)
        {
            this.pbj = pbj;
            InitializeComponent();
        }

        public CustomizePrehistoricPBJ(CretaceousCombo combo)
        {
            this.combo = combo;
            InitializeComponent();
        }
        private void HoldPeanutButterClicked(object sender, RoutedEventArgs e)
        {

            pbj?.HoldPeanutButter();
            if (this.combo != null)
            {
                if (this.combo.Entree is PrehistoricPBJ pb)
                {
                    pb.HoldPeanutButter();
                }
            }
        }

        private void HoldJellyClicked(object sender, RoutedEventArgs e)
        {
            pbj?.HoldJelly();
            if (this.combo != null)
            {
                if (this.combo.Entree is PrehistoricPBJ pb)
                {
                    pb.HoldJelly();
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
