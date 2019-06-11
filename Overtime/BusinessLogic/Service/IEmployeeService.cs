using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Service
{
    public interface IEmployeeService
    {
        List<Employee> Get();
        List<Employee> GetSearch(string values);
        Employee Get(int id);
    }
}
