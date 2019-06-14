using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Service
{
    public interface ISubmitedService
    {
        List<Submited> Get();
        List<Submited> GetSearch(string values);
        Submited Get(int id);
    }
}
