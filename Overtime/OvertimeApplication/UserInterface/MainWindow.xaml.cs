using Common.Repository.Application;
using DataAccess.Context;
using OvertimeApplication.UserInterface;
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

namespace OvertimeApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MyContext myContext = new MyContext();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Login();
            //UIDashboardEmployee dashboard = new UIDashboardEmployee();
            //dashboard.Show();
            //Dashboard dashboard = new Dashboard();
            //dashboard.Show();
        }

        private void Login()
        {
            LoginRepository loginRepository = new LoginRepository();
            if(loginRepository.CheckLogin(textbox_email.Text, passwordbox_email.Password) == true)
            {
                this.Hide();
                if(loginRepository.CheckAdmin(textbox_email.Text, passwordbox_email.Password) == true)
                {
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                }
                else
                {
                    UIDashboardEmployee uiDashboardEmployee = new UIDashboardEmployee();
                    uiDashboardEmployee.Show();
                }
            }
            else
            {
                MessageBox.Show("Login Failed", "Warning!", MessageBoxButton.OK, MessageBoxImage.Information);
                passwordbox_email.Clear();
                passwordbox_email.Focus();
            }
        }
    }
}
