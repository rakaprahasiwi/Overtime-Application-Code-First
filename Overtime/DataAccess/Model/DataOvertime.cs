using Core.Base;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    [Table("TB_T_DataOvertime")]
    public class DataOvertime : BaseModel
    {
        public DateTimeOffset Date_Overtime { get; set; }
        public double Pay_Overtime { get; set; }
        public DateTimeOffset Start_Overtime { get; set; }
        public DateTimeOffset End_Overtime { get; set; }
        public string Attachment_Overtime { get; set; }
        public string Status_Overtime { get; set; }

        [ForeignKey("TypeOvertime")]
        public int Type_Id { get; set; }
        public TypeOvertime TypeOvertime { get; set; }

        [ForeignKey("Employee")]
        public int Employee_Id { get; set; }
        public Employee Employee { get; set; }

        public DataOvertime(DataOvertimeVM dataOvertimeVM)
        {
            this.Date_Overtime = dataOvertimeVM.Date_Overtime;
            this.Pay_Overtime = dataOvertimeVM.Pay_Overtime;
            this.Start_Overtime = dataOvertimeVM.Start_Overtime;
            this.End_Overtime = dataOvertimeVM.End_Overtime;
            this.Attachment_Overtime = dataOvertimeVM.Attachment_Overtime;
            this.Status_Overtime = dataOvertimeVM.Status_Overtime;
            this.CreateDate = DateTimeOffset.Now.ToLocalTime();
        }

        public void Update (int id, DataOvertimeVM dataOvertimeVM)
        {
            this.Id = dataOvertimeVM.Id;
            this.Date_Overtime = dataOvertimeVM.Date_Overtime;
            this.Pay_Overtime = dataOvertimeVM.Pay_Overtime;
            this.Start_Overtime = dataOvertimeVM.Start_Overtime;
            this.End_Overtime = dataOvertimeVM.End_Overtime;
            this.Attachment_Overtime = dataOvertimeVM.Attachment_Overtime;
            this.Status_Overtime = dataOvertimeVM.Status_Overtime;
            this.UpdateDate = DateTimeOffset.Now.ToLocalTime();
        }

        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.ToLocalTime();
        }
    }
}
