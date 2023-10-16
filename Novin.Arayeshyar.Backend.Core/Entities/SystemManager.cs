using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novin.Arayeshyar.Backend.Core.Entities
{
    public class SystemManager
    {
        
        public string Username { get; set; }
        public string Password { get; set; }
        public SystemManager(string username, string password, string? managerCode)
        {
            Username = username;
            Password = password;
            ManagerCode = managerCode;
        }

        public string? ManagerCode { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
    }
}
