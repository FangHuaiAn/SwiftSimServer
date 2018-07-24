using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SwiftSimServer.Controllers
{
    [Route("api/[controller]")]
    public class LoginController : Controller
    {

        [HttpGet("{account}/{password}")]
        public string Get(string account, string password)
        {
            var user = new User { Name = "使用者一"
                    , Phone = "13213215895"
                    , LoginContent =$"account:{account};password:{ password }" };

            var userString = JsonConvert.SerializeObject(user);

            return userString;
        }

    }

    public class User {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string LoginContent { get; set; }
    }
}
