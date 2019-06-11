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

        public string Name_Parameter { get; set; }
        public int Value_Parameter { get; set; }

        public Parameter(ParameterVM parameterVM)
        {
            this.Name_Parameter = parameterVM.Name_Parameter;
            this.Value_Parameter = parameterVM.Value_Parameter;
            this.CreateDate = DateTimeOffset.Now.ToLocalTime();
        }

        public void Update(int id, ParameterVM parameterVM)
        {
            this.Id = id;
            this.Name_Parameter = parameterVM.Name_Parameter;
            this.Value_Parameter = parameterVM.Value_Parameter;
            this.UpdateDate = DateTimeOffset.Now.ToLocalTime();
        }

        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.ToLocalTime();
        }
    }
}
