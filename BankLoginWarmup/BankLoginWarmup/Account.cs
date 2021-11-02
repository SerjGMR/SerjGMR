using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLoginWarmup
{
    class Account
    {
        private string username;
        private string password;

        public Account(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public string getUsername()
        {
            return username;
        }
        public string getPassword()
        {
            return password;
        }
        public bool isValid(string username, string password)
        {
            if (this.username == username && this.password == password)
            {
                return true;
            }
            return false;
        }
    }
}
