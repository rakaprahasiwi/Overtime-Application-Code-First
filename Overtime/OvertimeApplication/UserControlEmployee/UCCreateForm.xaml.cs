using BusinessLogic.Service;
using BusinessLogic.Service.Application;
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
    /// Interaction logic for UCCreateForm.xaml
    /// </summary>
    public partial class UCCreateForm : System.Windows.Controls.UserControl
    {
        ITypeOvertimeService iTypeOvertimeService = new TypeOvertimeService();
        IEmployeeService iEmployeeService = new EmployeeService();
        public UCCreateForm()
        {
            InitializeComponent();
            Show();
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Show()
        {
            comboBox_overtime_type.ItemsSource = iTypeOvertimeService.Get();
            
        }
    }
}
