using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ex1.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Ex1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AController : ControllerBase
    {
        private readonly ICaculator _serviceA;

        public AController(ICaculator serviceA){
            _serviceA = serviceA;
        }
        [HttpGet]
        public float Get()
        {
            var numA = 10;
            var numB = 20;
            return _serviceA.Add(numA, numB);
        }
    }
}
