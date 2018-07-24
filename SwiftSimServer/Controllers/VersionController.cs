using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SwiftSimServer.Controllers
{
    [Route("api/[controller]")]
    public class VersionController : Controller
    {
        [HttpGet("{version}")]
        public string Get(string version)
        {
            // 紀錄使用者的應用程式版本
            // 回傳最新版本

            return "1.0.0.234";
        }
    }
}
