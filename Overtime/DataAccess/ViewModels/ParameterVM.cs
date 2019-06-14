using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class ParameterVM
    {
        public ParameterVM() { }

        public ParameterVM(int long_time, int pay)
        {
            this.Long_Time = long_time ;
            this.Pay = pay;
        }

        public void Update(int id, int long_time, int pay)
        {
            this.Id = id;
            this.Long_Time = long_time;
            this.Pay = pay;
        }

        public int Id { get; set; }
        public int Long_Time { get; set; }
        public int Pay { get; set; }
    }
}
