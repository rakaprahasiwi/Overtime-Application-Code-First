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
    public class ActivityOvertimeService : IActivityOvertimeService
    {
        IActivityOvertime iActivityOvertime = new ActivityOvertimeRepository();

        public List<ActivityOvertime> Get()
        {
            return iActivityOvertime.Get();
        }

        public ActivityOvertime Get(int id)
        {
            return iActivityOvertime.Get(id);
        }

        public List<ActivityOvertime> GetSearch(string values)
        {
            return iActivityOvertime.GetSearch(values);
        }
    }
}
