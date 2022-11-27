using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.Models;

namespace DataAccess.DAO
{
    public class HraccountDAO
    {
        public static HraccountDAO instance = null;
        public static object instanceLook = new object();

        public static HraccountDAO Instance
        {
            get
            {
                lock (instanceLook)
                {
                    if (instance == null)
                    {
                        instance = new HraccountDAO();
                    }
                    return instance;
                }
            }
        }

        public Hraccount Login(string userName, string password)
        {
            Hraccount account = null;
            try
            {
                PeTestContext context = new PeTestContext();
                account = context.Hraccounts.Where(a => a.Email.Equals(userName) && a.Password.Equals(password)).ToList()[0];
            } catch(Exception e)
            {

            }
            
            return account;
        }
    }
}
