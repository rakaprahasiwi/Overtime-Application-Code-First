using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Model;
using DataAccess.ViewModels;
using DataAccess.Context;
using System.Data.Entity;

namespace Common.Repository.Application
{
    public class DataOvertimeRepository : IDataOvertime
    {
        MyContext myContext = new MyContext();

        public bool Delete(int id)
        {
            var get = Get(id);
            if (get != null)
            {
                get.Delete();
                myContext.Entry(get).State = EntityState.Modified;
                var result = myContext.SaveChanges();
                return result > 0;
            }
            else
            {
                return false;
            }
        }

        public List<DataOvertime> Get()
        {
            var get = myContext.DataOvertimes.Where(x => x.IsDelete == false).ToList();
            return get;
        }

        public DataOvertime Get(int id)
        {
            var get = myContext.DataOvertimes.Find(id);
            return get;
        }

        public List<DataOvertime> GetSearch(string values)
        {
            var get = myContext.DataOvertimes.Where(x => (x.Pay_Overtime.ToString().Contains(values) || x.Id.ToString().Contains(values) || x.Attachment_Overtime.Contains(values) || x.Status_Overtime.Contains(values) || x.Employee_Id.ToString().Contains(values) || x.Type_Id.ToString().Contains(values)) && x.IsDelete == false).ToList();
            return get;
        }

        public bool Insert(DataOvertimeVM dataOvertimeVM)
        {
            var push = new DataOvertime(dataOvertimeVM);
            var get = myContext.TypeOvertimes.Find(dataOvertimeVM.Type_Id);
            if (get != null)
            {
                push.TypeOvertime = get;
                myContext.DataOvertimes.Add(push);
                var result = myContext.SaveChanges();
                if (result > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool Update(int id, DataOvertimeVM dataOvertimeVM)
        {
            var get = Get(id);
            if (get != null)
            {
                var getSup = myContext.TypeOvertimes.Find(get.Type_Id);
                if (getSup != null)
                {
                    get.TypeOvertime = getSup;
                    get.Update(id, dataOvertimeVM);
                    myContext.Entry(get).State = EntityState.Modified;
                    var result = myContext.SaveChanges();
                    return result > 0;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
