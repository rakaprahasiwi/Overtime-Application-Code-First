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
    [Table("TB_M_TypeOvertime")]
    public class TypeOvertime : BaseModel
    {
        public TypeOvertime() { }

        public string Overtime_Type { get; set; }

        public TypeOvertime(TypeOvertimeVM typeOvertimeVM)
        {
            this.Overtime_Type = typeOvertimeVM.Overtime_Type;
        }
    }
}
