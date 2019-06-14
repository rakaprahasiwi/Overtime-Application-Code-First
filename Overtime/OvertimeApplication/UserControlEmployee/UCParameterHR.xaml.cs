using BusinessLogic.Service;
using BusinessLogic.Service.Application;
using Common.Repository.Application;
using DataAccess.ViewModels;
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
    /// Interaction logic for UCParameterHR.xaml
    /// </summary>
    public partial class UCParameterHR : UserControl
    {
        IParameterService iParameterService = new ParameterService();
        ParameterVM parameterVM = new ParameterVM();
        public UCParameterHR()
        {
            InitializeComponent();
            Show();
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            parameterVM.Long_Time = Convert.ToInt32(txtBox_longTime.Text);
            parameterVM.Pay = Convert.ToInt32(txtBox_pay.Text);
           
            var result = iParameterService.Insert(parameterVM);
            if (result) //default true
            {
                MessageBox.Show("Insert Successfully");
            }
            else
            {
                MessageBox.Show("Insert Failed");
            }
            Show();
        }

        private void Show()
        {
            dataGrid_parameter.ItemsSource = iParameterService.Get();
        }

        private void button_delete_Click(object sender, RoutedEventArgs e)
        {
            //int id = (dataGrid_parameter.SelectedItem as member)
        }
    }
}
