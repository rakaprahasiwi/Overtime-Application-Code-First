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
    public class TypeOvertimeRepository : ITypeOvertime
    {
        MyContext myContext = new MyContext();

        public List<TypeOvertime> Get()
        {
            var get = myContext.TypeOvertimes.Where(x => x.IsDelete == false).ToList();
            return get;
        }

        public TypeOvertime Get(int id)
        {
            var get = myContext.TypeOvertimes.Find(id);
            return get;
        }

        public List<TypeOvertime> GetSearch(string values)
        {
            var get = myContext.TypeOvertimes.Where(x => (x.Overtime_Type.Contains(values) || x.Id.ToString().ToString().Contains(values)) && x.IsDelete == false).ToList();
            return get;
        }
    }
}
