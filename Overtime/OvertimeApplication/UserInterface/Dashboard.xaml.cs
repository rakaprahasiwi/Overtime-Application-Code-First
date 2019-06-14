using OvertimeApplication.UserInterface;
using OvertimeApplication.UserControlEmployee;
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
using DataAccess.Model;
using DataAccess.ViewModels;

namespace OvertimeApplication.UserInterface
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        public Employee _employee;
        public Dashboard()
        {
            InitializeComponent();
        }

        public Dashboard(Employee employee)
        {
            InitializeComponent();
            _employee = employee;
            UserControl usc;
            usc = new UCCreateForm(_employee);
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
                case "Parameter":
                    usc = new UCParameterHR();
                    GridMain.Children.Add(usc);
                    break;
                case "CreateOvertime":
                    usc = new UCCreateOvertimeHR(_employee);
                    GridMain.Children.Add(usc);
                    break;
                case "ListSubmissionOvertime":
                    usc = new UCDashboardHR();
                    GridMain.Children.Add(usc);
                    break;
                case "ListApproveOvertimeForm":
                    usc = new UCListApproveOvertimeForm();
                    GridMain.Children.Add(usc);
                    break;

                default:
                    break;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private void ListSubmissionOvertime_Selected(object sender, RoutedEventArgs e)
        {

        }
    }
}
