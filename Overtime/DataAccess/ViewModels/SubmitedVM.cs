using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class SubmitedVM
    {
        public SubmitedVM() { }

        public SubmitedVM(string status_submited, string name_submited)
        {
            this.Status_submited = status_submited;
            this.Name_Submited = name_submited;
        }

        public string Status_submited { get; set; }
        public string Name_Submited { get; set; }

    }
}
