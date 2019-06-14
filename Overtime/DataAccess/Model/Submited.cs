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
    [Table("TB_M_Submited")]
    public class Submited : BaseModel
    {
        public Submited() { }

        public string Name_Submitted { get; set; }
        public string Status_Submitted { get; set; }

        public Submited(SubmitedVM submitedVM)
        {
            this.Name_Submitted = submitedVM.Name_Submitted;
            this.Status_Submitted = submitedVM.Status_Submitted;
        }
    }
}
