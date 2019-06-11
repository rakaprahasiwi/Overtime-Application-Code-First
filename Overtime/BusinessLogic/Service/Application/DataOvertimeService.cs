using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Model;
using DataAccess.ViewModels;
using Common.Repository;
using Common.Repository.Application;

namespace BusinessLogic.Service.Application
{
    public class DataOvertimeService : IDataOvertimeService
    {
        IDataOvertime iDataOvertime = new DataOvertimeRepository();

        public bool Delete(int id)
        {
            return iDataOvertime.Delete(id);
        }

        public List<DataOvertime> Get()
        {
            return iDataOvertime.Get();
        }

        public DataOvertime Get(int id)
        {
            return iDataOvertime.Get(id);
        }

        public List<DataOvertime> GetSearch(string values)
        {
            return iDataOvertime.GetSearch(values);
        }

        public bool Insert(DataOvertimeVM dataOvertimeVM)
        {
            if (string.IsNullOrWhiteSpace(dataOvertimeVM.Attachment_Overtime) || string.IsNullOrWhiteSpace(dataOvertimeVM.Description_Overtime) || string.IsNullOrWhiteSpace(dataOvertimeVM.Pay_Overtime.ToString()) || string.IsNullOrWhiteSpace(dataOvertimeVM.Employee_Id.ToString()))
            {
                return false;
            }
            else if (string.IsNullOrWhiteSpace(dataOvertimeVM.End_Overtime.ToString()) || string.IsNullOrWhiteSpace(dataOvertimeVM.Date_Overtime.ToString()) || string.IsNullOrWhiteSpace(dataOvertimeVM.Start_Overtime.ToString()) || string.IsNullOrWhiteSpace(dataOvertimeVM.Status_Overtime) || string.IsNullOrWhiteSpace(dataOvertimeVM.Type_Id.ToString()))
            {
                return false;
            }
            else
            {
                return iDataOvertime.Insert(dataOvertimeVM);
            }
        }

        public bool Update(int id, DataOvertimeVM dataOvertimeVM)
        {
            if (string.IsNullOrWhiteSpace(dataOvertimeVM.Attachment_Overtime) || string.IsNullOrWhiteSpace(dataOvertimeVM.Description_Overtime) || string.IsNullOrWhiteSpace(dataOvertimeVM.Pay_Overtime.ToString()) || string.IsNullOrWhiteSpace(dataOvertimeVM.Employee_Id.ToString()))
            {
                return false;
            }
            else if (string.IsNullOrWhiteSpace(dataOvertimeVM.End_Overtime.ToString()) || string.IsNullOrWhiteSpace(dataOvertimeVM.Date_Overtime.ToString()) || string.IsNullOrWhiteSpace(dataOvertimeVM.Start_Overtime.ToString()) || string.IsNullOrWhiteSpace(dataOvertimeVM.Status_Overtime) || string.IsNullOrWhiteSpace(dataOvertimeVM.Type_Id.ToString()))
            {
                return false;
            }
            else
            {
                return iDataOvertime.Update(id, dataOvertimeVM);
            }
        }
    }
}
