using DataAccess.Model;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repository
{
    public interface IEmployee
    {
        List<Employee> Get();
        List<Employee> GetSearch(string values);
        Employee Get(int id);
    }
}
