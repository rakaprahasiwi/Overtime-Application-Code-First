using Core.Base;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    [Table("TB_M_Employee")]
    public class Employee : BaseModel
    {
        public Employee() { }

        public int NIK { get; set; }
        public string Name_Employee { get; set; }
        public double Salary_Employee { get; set; }
        public string Email_Employee { get; set; }
        public string Password_Employee { get; set; }

        public Employee(EmployeeVM employeeVM)
        {
            this.NIK = employeeVM.NIK;
            this.Name_Employee = employeeVM.Name_Employee;
            this.Salary_Employee = employeeVM.Salary_Employee;
            this.Email_Employee = employeeVM.Email_Employee;
            this.Password_Employee = employeeVM.Password_Employee;
        }
    }
}
