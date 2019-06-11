using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class DataOvertimeVM
    {
        public DataOvertimeVM() { }

        public DataOvertimeVM(DateTimeOffset date_overtime, double pay_overtime, DateTimeOffset start_overtime, DateTimeOffset end_overtime, string attachment_overtime, string description_overtime, string status_overtime, int employee_id, int type_id)
        {
            this.Date_Overtime = date_overtime;
            this.Pay_Overtime = pay_overtime;
            this.Start_Overtime = start_overtime;
            this.End_Overtime = end_overtime;
            this.Attachment_Overtime = attachment_overtime;
            this.Description_Overtime = description_overtime;
            this.Status_Overtime = status_overtime;
            this.Employee_Id = employee_id;
            this.Type_Id = type_id;
        }

        public void Update(int id, DateTimeOffset date_overtime, double pay_overtime, DateTimeOffset start_overtime, DateTimeOffset end_overtime, string attachment_overtime, string description_overtime, string status_overtime, int employee_id, int type_id)
        {
            this.Id = id;
            this.Date_Overtime = date_overtime;
            this.Pay_Overtime = pay_overtime;
            this.Start_Overtime = start_overtime;
            this.End_Overtime = end_overtime;
            this.Attachment_Overtime = attachment_overtime;
            this.Description_Overtime = description_overtime;
            this.Status_Overtime = status_overtime;
            this.Employee_Id = employee_id;
            this.Type_Id = type_id;
        }

        public int Id { get; set; }
        public DateTimeOffset Date_Overtime { get; set; }
        public double Pay_Overtime { get; set; }
        public DateTimeOffset Start_Overtime { get; set; }
        public DateTimeOffset End_Overtime { get; set; }
        public string Attachment_Overtime { get; set; }
        public string Description_Overtime { get; set; }
        public string Status_Overtime { get; set; }
        public int Employee_Id { get; set; }
        public int Type_Id { get; set; }
    }
}
