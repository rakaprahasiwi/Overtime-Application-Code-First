using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Service
{
    public interface IActivityOvertimeService
    {
        List<ActivityOvertime> Get();
        List<ActivityOvertime> GetSearch(string values);
        ActivityOvertime Get(int id);
    }
}
