using OvertimeApplication.UserControl;
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
using System.Windows.Shapes;

namespace OvertimeApplication.UserInterface
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GridMain.Children.Clear();

            System.Windows.Controls.UserControl usc = null;
            switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
            {
                case "ItemDashboard":
                    usc = new Parameter();
                    GridMain.Children.Add(usc);
                    break;
                //case "ItemProject":
                //    usc = new Project();
                //    GridMain.Children.Add(usc);
                //    break;
                //case "ItemTask":
                //    usc = new Task();
                //    GridMain.Children.Add(usc);
                //    break;

                default:
                    break;
            }
        }
    }
}
