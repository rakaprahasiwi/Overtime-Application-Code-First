using DataAccess.Model;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repository
{
    public interface IParameter
    {
        List<Parameter> Get();
        List<Parameter> GetSearch(string values);
        Parameter Get(int id);
        bool Insert(ParameterVM parameterVM);
        bool Update(int id, ParameterVM parameterVM);
        bool Delete(int id);
    }
}
