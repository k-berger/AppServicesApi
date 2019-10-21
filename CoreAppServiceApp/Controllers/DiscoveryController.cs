using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace CoreAppServiceApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscoveryController : ControllerBase
    {
        public Dictionary<string, string> Get()
        {
            var result = new Dictionary<string, string>();
            result.Add("Machine", Environment.MachineName);
            result.Add("OS", Environment.OSVersion.ToString());
            return result;
        }
    }
}