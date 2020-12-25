using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculater.Models;
using Calculater.SolveEquation.Methods;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Calculater.SolveEquation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuadraticEquationController : ControllerBase
    {

        [HttpGet("Solve")]
        public IActionResult Get()
        {
            var equation = new Equation()
            {
                A = 2,
                B = 2,
                C = 4
            };
            return Ok(EquationSolver.Solve(equation));
        }
    }
}
