using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Model;
using DataAccess.ViewModels;
using Common.Repository;
using Common.Repository.Application;

namespace BusinessLogic.Service.Application
{
    public class ParameterService : IParameterService
    {
        IParameter iParameter = new ParameterRepository();

        public bool Delete(int id)
        {
            return iParameter.Delete(id);
        }

        public List<Parameter> Get()
        {
            return iParameter.Get();
        }

        public Parameter Get(int id)
        {
            return iParameter.Get(id);
        }

        public List<Parameter> GetSearch(string values)
        {
            return iParameter.GetSearch(values);
        }

        public bool Insert(ParameterVM parameterVM)
        {
            if (string.IsNullOrWhiteSpace(parameterVM.Name_Parameter) || string.IsNullOrWhiteSpace(parameterVM.Value_Parameter.ToString()))
            {
                return false;
            }
            else
            {
                return iParameter.Insert(parameterVM);
            }
        }

        public bool Update(int id, ParameterVM parameterVM)
        {
            if (string.IsNullOrWhiteSpace(parameterVM.Name_Parameter) || string.IsNullOrWhiteSpace(parameterVM.Value_Parameter.ToString()))
            {
                return false;
            }
            else
            {
                return iParameter.Update(id, parameterVM);
            }
        }
    }
}
