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

        public SubmitedVM(string name_submitted, string status_submitted)
        {
            this.Name_Submitted = name_submitted;
            this.Status_Submitted = status_submitted;
        }

        public int Id { get; set; }
        public string Name_Submitted { get; set; }
        public string Status_Submitted { get; set; }

    }
}
