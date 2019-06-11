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
    public class ActivityOvertime : BaseModel
    {
        public ActivityOvertime() { }

        public string Overtime_Activity { get; set; }

        [ForeignKey("DataOvertime")]
        public int Overtime_Id { get; set; }
        public DataOvertime DataOvertime { get; set; }

        public ActivityOvertime(ActivityOvertimeVM activityOvertimeVM)
        {
            this.Overtime_Activity = activityOvertimeVM.Overtime_Activity;
        }

    }
}
