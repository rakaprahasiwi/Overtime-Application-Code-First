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
    public class SubmitedService : ISubmitedService
    {
        ISubmited iSubmited = new SubmitedRepository();

        public List<Submited> Get()
        {
            return iSubmited.Get();
        }

        public Submited Get(int id)
        {
            return iSubmited.Get(id);
        }

        public List<Submited> GetSearch(string values)
        {
            return iSubmited.GetSearch(values);
        }
    }
}
