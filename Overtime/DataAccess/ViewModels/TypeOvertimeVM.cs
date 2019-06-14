﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class TypeOvertimeVM
    {
        public TypeOvertimeVM() { }

        public TypeOvertimeVM(string overtime_type)
        {
            this.Overtime_Type = overtime_type;
        }

        public int Id { get; set; }
        public string Overtime_Type { get; set; }
    }
}
