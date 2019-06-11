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
    public class TypeOvertimeService : ITypeOvertimeService
    {
        ITypeOvertime iTypeOvertime = new TypeOvertimeRepository();

        public List<TypeOvertime> Get()
        {
            return iTypeOvertime.Get();
        }

        public TypeOvertime Get(int id)
        {
            return iTypeOvertime.Get(id);
        }

        public List<TypeOvertime> GetSearch(string values)
        {
            return iTypeOvertime.GetSearch(values);
        }
    }
}
