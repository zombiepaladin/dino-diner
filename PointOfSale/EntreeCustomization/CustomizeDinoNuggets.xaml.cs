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
    /// Interaction logic for CustomizeDinoNuggets.xaml
    /// </summary>
    public partial class CustomizeDinoNuggets : Page
    {
        private DinoNuggets nug;
        private CretaceousCombo combo;
        public CustomizeDinoNuggets()
        {
            InitializeComponent();
        }
        public CustomizeDinoNuggets(DinoNuggets d)
        {
            InitializeComponent();
            this.nug = d;
        }

        public CustomizeDinoNuggets(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
        }
        private void Add_Nugget_Click(object sender, RoutedEventArgs e)
        {
            nug?.AddNugget();
            if (this.combo != null)
            {
                if (this.combo.Entree is DinoNuggets dn)
                {
                    dn.AddNugget();
                }
            }
        }

        private void BackClicked(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack) NavigationService.GoBack();
            else NavigationService.Navigate(new MenuCategorySelection());
        }

        private void DoneClicked(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
