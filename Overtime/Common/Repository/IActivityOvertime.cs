using DataAccess.Model;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repository
{
    public interface IActivityOvertime
    {
        List<ActivityOvertime> Get();
        List<ActivityOvertime> GetSearch(string values);
        ActivityOvertime Get(int id);
    }
}
