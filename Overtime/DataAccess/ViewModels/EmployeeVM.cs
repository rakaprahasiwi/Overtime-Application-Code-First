using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class EmployeeVM
    {
        public EmployeeVM() { }

        public EmployeeVM(int nik, string name_employee, double salary_employee, string email_employee, string password_employee)
        {
            this.NIK = nik;
            this.Name_Employee = name_employee;
            this.Salary_Employee = salary_employee;
            this.Email_Employee = email_employee;
            this.Password_Employee = password_employee;
        }

        public int Id { get; set; }
        public int NIK { get; set; }
        public string Name_Employee { get; set; }
        public double Salary_Employee { get; set; }
        public string Email_Employee { get; set; }
        public string Password_Employee { get; set; }
    }
}
    