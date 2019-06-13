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

        public string Status_submited { get; set; }
        public string Name_Submited { get; set; }

        public Submited(SubmitedVM submitedVM)
        {
            this.Status_submited = submitedVM.Status_submited;
            this.Name_Submited = submitedVM.Name_Submited;
        }
    }
}
