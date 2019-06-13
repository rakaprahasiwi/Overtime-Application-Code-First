using DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repository.Application
{
    public class LoginRepository
    {
        MyContext myContext = new MyContext();

        public bool CheckLogin(string email, string password)
        {
            bool status = false;
            var get = myContext.Employees.Where(x => x.Email_Employee == email && x.Password_Employee == password && x.IsDelete == false).SingleOrDefault();

            try
            {
                if(get.Email_Employee == email && get.Password_Employee == password && get.IsDelete == false)
                {
                    status = true;
                    return status;
                }
                else
                {
                    return status;
                }
            }
            catch(Exception e)
            {
                e.GetBaseException();
                return status;
            }
        }

        public bool CheckAdmin(string email, string password)
        {
            bool status = false;
            var get = myContext.Employees.Where(x => x.Email_Employee == email && x.Password_Employee == password && x.IsDelete == false && x.Role == true).SingleOrDefault();

            try
            {
                if (get.Email_Employee == email && get.Password_Employee == password && get.IsDelete == false && get.Role == true)
                {
                    status = true;
                    return status;
                }
                else
                {
                    return status;
                }
            }
            catch (Exception e)
            {
                e.GetBaseException();
                return status;
            }
        }
    }
}
