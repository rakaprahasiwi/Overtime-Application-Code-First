using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Model;
using DataAccess.ViewModels;
using DataAccess.Context;

namespace Common.Repository.Application
{
    public class EmployeeRepository : IEmployee
    {
        MyContext myContext = new MyContext();

        public List<Employee> Get()
        {
            var get = myContext.Employees.Where(x => x.IsDelete == false).ToList();
            return get;
        }

        public Employee Get(int id)
        {
            var get = myContext.Employees.Find(id);
            return get;
        }

        public List<Employee> GetSearch(string values)
        {
            var get = myContext.Employees.Where(x => (x.Name_Employee.Contains(values) || x.Id.ToString().Contains(values) || x.NIK.ToString().Contains(values) || x.Salary_Employee.ToString().Contains(values) || x.Email_Employee.Contains(values)) && x.IsDelete == false).ToList();
            return get;
        }
    }
}
