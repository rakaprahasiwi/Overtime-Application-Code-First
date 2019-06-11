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
    public class ActivityOvertimeRepository : IActivityOvertime
    {
        MyContext myContext = new MyContext();

        public List<ActivityOvertime> Get()
        {
            var get = myContext.ActivityOvertimes.Where(x => x.IsDelete == false).ToList();
            return get;
        }

        public ActivityOvertime Get(int id)
        {
            var get = myContext.ActivityOvertimes.Find(id);
            return get;
        }

        public List<ActivityOvertime> GetSearch(string values)
        {
            var get = myContext.ActivityOvertimes.Where(x => (x.Overtime_Id.ToString().Contains(values) || x.Overtime_Activity.Contains(values) || x.Id.ToString().Contains(values)) && x.IsDelete == false).ToList();
            return get;
        }
    }
}
