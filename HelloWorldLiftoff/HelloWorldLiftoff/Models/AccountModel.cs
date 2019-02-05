using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorldLiftoff.Models
{
    public class AccountModel
    {
        private List<Account> listAccounts = new List<Account>();

        public AccountModel()
        {
            listAccounts.Add(new Account
            {
                username = "acc1",
                password = "123",
                areaCode = 0,
                sourceCode = 0,
                trackingSheets = new List<TrackingSheet>()
            });

            listAccounts.Add(new Account
            {
                username = "acc2",
                password = "123",
                areaCode = 0,
                sourceCode = 0,
                trackingSheets = new List<TrackingSheet>()
            });

            listAccounts.Add(new Account
            {
                username = "acc3",
                password = "123",
                areaCode = 0,
                sourceCode = 0,
                trackingSheets = new List<TrackingSheet>()
            });
        }

        public Account find(string username)
        {
            return listAccounts.Where(acc => acc.username.Equals(username)).FirstOrDefault();
        }

        public Account login(string username, string password)
        {
            return listAccounts.Where(acc => acc.username.Equals(username) && acc.password.Equals(password)).FirstOrDefault();
        }
    }
}
