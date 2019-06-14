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
    [Table("TB_M_Parameter")]
    public class Parameter : BaseModel
    {
        public Parameter() { }

        public int Long_Time { get; set; }
        public int Pay { get; set; }

        public Parameter(ParameterVM parameterVM)
        {
            this.Long_Time = parameterVM.Long_Time;
            this.Pay = parameterVM.Pay;
            this.CreateDate = DateTimeOffset.Now.ToLocalTime();
        }

        public void Update(int id, ParameterVM parameterVM)
        {
            this.Id = id;
            this.Long_Time = parameterVM.Long_Time;
            this.Pay = parameterVM.Pay;
            this.UpdateDate = DateTimeOffset.Now.ToLocalTime();
        }

        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.ToLocalTime();
        }
    }
}
