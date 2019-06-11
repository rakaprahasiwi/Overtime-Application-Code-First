using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Model;
using DataAccess.ViewModels;
using DataAccess.Context;
using System.Data.Entity;

namespace Common.Repository.Application
{
    public class ParameterRepository : IParameter
    {
        MyContext myContext = new MyContext();

        public bool Delete(int id)
        {
            var get = Get(id);
            if (get != null)
            {
                get.Delete();
                myContext.Entry(get).State = EntityState.Modified;
                var result = myContext.SaveChanges();
                return result > 0;
            }
            else
            {
                return false;
            }
        }

        public List<Parameter> Get()
        {
            var get = myContext.Parameters.Where(x => x.IsDelete == false).ToList();
            return get;
        }

        public Parameter Get(int id)
        {
            var get = myContext.Parameters.Find(id);
            return get;
        }

        public List<Parameter> GetSearch(string values)
        {
            var get = myContext.Parameters.Where(x => (x.Name_Parameter.Contains(values) || x.Value_Parameter.ToString().Contains(values)) && x.IsDelete == false).ToList();
            return get;
        }

        public bool Insert(ParameterVM parameterVM)
        {
            var push = new Parameter(parameterVM);
            myContext.Parameters.Add(push);
            var result = myContext.SaveChanges();
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Update(int id, ParameterVM parameterVM)
        {
            var get = Get(id);
            if (get != null)
            {
                get.Update(id, parameterVM);
                myContext.Entry(get).State = EntityState.Modified;
                var result = myContext.SaveChanges();
                return result > 0;
            }
            else
            {
                return false;
            }
        }
    }
}
