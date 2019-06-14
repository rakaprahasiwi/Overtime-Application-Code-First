using BusinessLogic.Service;
using BusinessLogic.Service.Application;
using DataAccess.Model;
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
        string salary;
        public UCCreateForm()
        {
            InitializeComponent();
            Show();
        }

        public UCCreateForm(Employee employee)
        {
            InitializeComponent();
            Show();
            textBox_Salary.Text = employee.Salary_Employee.ToString();
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
