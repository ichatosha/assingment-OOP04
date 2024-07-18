using assingment_OOP04.Intertfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assingment_OOP04
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        // store simple data here in dict : 
        private Dictionary<string, string> users = new Dictionary<string, string>
        {
            { "hesham", "123" },
            { "ahmed", "000" }
        };

        private Dictionary<string, string> roles = new Dictionary<string, string>
        {
            { "hesham", "admin" },
            { "ahmed", "user" }
        };

        // check if the user have the correct pass : 
        public bool AuthenticateUser(string username, string password)
        {
            return users.ContainsKey(username) && users[username] == password;
        }

        // check if the user have the correct role: ( containkey)
        public bool AuthorizeUser(string username, string role)
        {
            return roles.ContainsKey(username) && roles[username] == role;
        }


    }
}
