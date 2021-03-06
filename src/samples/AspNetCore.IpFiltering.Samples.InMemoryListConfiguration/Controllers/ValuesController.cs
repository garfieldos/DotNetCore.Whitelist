﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore.IpFiltering.Samples.InMemoryListConfiguration.Controllers
{
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("api/some-data")]
        public IActionResult GetSomeData()
        {
            return this.Ok("Some data");
        }

        [HttpGet("api/some-unguarded-data")]
        public IActionResult GetUnguardedData()
        {
            return this.Ok("Some unguarded data");
        }
    }
}
