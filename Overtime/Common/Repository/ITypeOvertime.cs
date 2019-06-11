using DataAccess.Model;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repository
{
    public interface ITypeOvertime
    {
        List<TypeOvertime> Get();
        List<TypeOvertime> GetSearch(string values);
        TypeOvertime Get(int id);
    }
}
