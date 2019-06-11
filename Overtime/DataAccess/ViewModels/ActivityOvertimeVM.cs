using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class ActivityOvertimeVM
    {
        public ActivityOvertimeVM() { }

        public ActivityOvertimeVM(string overtime_activity,int overtime_id)
        {
            this.Overtime_Activity = overtime_activity;
            this.Overtie_Id = overtime_id;
        }

        public int Id { get; set; }
        public string Overtime_Activity { get; set; }
        public int Overtie_Id { get; set; }
    }
}
