using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Domain.Entities.Authentications
{
    public class User : IdentityUser<int>
    {
        public User()
        {

        }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime LastLoginDate { get; set; }
    }
}
