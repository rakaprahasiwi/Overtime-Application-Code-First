using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repository
{
    public interface ISubmited
    {
        List<Submited> Get();
        List<Submited> GetSearch(string values);
        Submited Get(int id);
    }
}
