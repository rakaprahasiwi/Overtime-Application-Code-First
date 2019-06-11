using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Model;
using Common.Repository;
using Common.Repository.Application;

namespace BusinessLogic.Service.Application
{
    public class EmployeeService : IEmployeeService
    {
        IEmployee iEmployee = new EmployeeRepository(); 

        public List<Employee> Get()
        {
            return iEmployee.Get();
        }

        public Employee Get(int id)
        {
            return iEmployee.Get(id);
        }

        public List<Employee> GetSearch(string values)
        {
            return iEmployee.GetSearch(values);
        }
    }
}
