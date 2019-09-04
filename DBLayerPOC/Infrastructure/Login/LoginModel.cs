using DBLayerPOC.ModelBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBLayerPOC.Infrastructure.Login
{
    public class LoginModel : Entity
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
