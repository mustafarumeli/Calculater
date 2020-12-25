using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculater.Models;
using Calculater.SolveEquation.Methods;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Calculater.SolveEquation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuadraticEquationController : ControllerBase
    {

        [HttpGet("Solve")]
        public IActionResult Get(int a, int b, int c)
        {
            var equation = new Equation()
            {
                A = a,
                B = b,
                C = c
            };
            var eqResult = EquationSolver.Solve(equation);
            var jsonString = JsonConvert.SerializeObject(eqResult);
            return Ok(jsonString);
        }
    }
}
