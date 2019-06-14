using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Model;
using DataAccess.Context;

namespace Common.Repository.Application
{
    public class SubmitedRepository : ISubmited
    {
        MyContext myContext = new MyContext();

        public List<Submited> Get()
        {
            var get = myContext.Submiteds.Where(x => x.IsDelete == false).ToList();
            return get;
        }

        public Submited Get(int id)
        {
            var get = myContext.Submiteds.Find(id);
            return get;
        }

        public List<Submited> GetSearch(string values)
        {
            var get = myContext.Submiteds.Where(x => (x.Name_Submitted.Contains(values) || x.Status_Submitted.Contains(values)) && x.IsDelete == false).ToList();
            return get;
        }
    }
}
