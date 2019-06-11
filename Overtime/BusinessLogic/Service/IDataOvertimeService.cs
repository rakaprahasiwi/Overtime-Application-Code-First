using DataAccess.Model;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Service
{
    public interface IDataOvertimeService
    {
        List<DataOvertime> Get();
        List<DataOvertime> GetSearch(string values);
        DataOvertime Get(int id);
        bool Insert(DataOvertimeVM dataOvertimeVM);
        bool Update(int id, DataOvertimeVM dataOvertimeVM);
        bool Delete(int id);
    }
}
