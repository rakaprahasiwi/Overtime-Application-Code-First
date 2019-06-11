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

        public ParameterVM(string name_parameter, int value_parameter)
        {
            this.Name_Parameter = name_parameter;
            this.Value_Parameter = value_parameter;
        }

        public void Update(int parameter_id, string name_parameter, int value_parameter)
        {
            this.Parameter_Id = parameter_id;
            this.Name_Parameter = name_parameter;
            this.Value_Parameter = value_parameter;
        }

        public int Parameter_Id { get; set; }
        public string Name_Parameter { get; set; }
        public int Value_Parameter { get; set; }
    }
}
