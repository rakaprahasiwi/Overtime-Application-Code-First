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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OvertimeApplication.UserControlEmployee
{
    /// <summary>
    /// Interaction logic for ListSubmissionOvertime.xaml
    /// </summary>
    public partial class ListSubmissionOvertime : System.Windows.Controls.UserControl
    {
        public ListSubmissionOvertime()
        {
            InitializeComponent();
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GridMain.Children.Clear();

            System.Windows.Controls.UserControl usc = null;
            switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
            {
                case "Parameter":
                    usc = new Parameter();
                    GridMain.Children.Add(usc);
                    break;
                case "CreateOvertime":
                    usc = new CreateOvertime();
                    GridMain.Children.Add(usc);
                    break;
                case "ListSubmissionOvertime":
                    usc = new ListSubmissionOvertime();
                    GridMain.Children.Add(usc);
                    break;
                case "ListApproveOvertimeForm":
                    usc = new ListApproveOvertimeForm();
                    GridMain.Children.Add(usc);
                    break;

                default:
                    break;
            }
        }
    }
}
