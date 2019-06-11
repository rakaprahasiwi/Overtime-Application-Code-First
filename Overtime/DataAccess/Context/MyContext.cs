using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class MyContext : DbContext
    {
        public MyContext() : base("MyContext") { }

        public DbSet<ActivityOvertime> ActivityOvertimes { get; set; }
        public DbSet<DataOvertime> DataOvertimes { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Parameter> Parameters { get; set; }
        public DbSet<TypeOvertime> TypeOvertimes { get; set; }
    }
}