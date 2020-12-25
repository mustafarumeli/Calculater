using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculater.Models;

namespace Calculater.SolveEquation.Methods
{
    public static class EquationSolver
    {
        public static EquationResult Solve(Equation equation)
        {
            var disc = Math.Pow(equation.B, 2) - (4 * equation.A * equation.C);
            var equationResult = new EquationResult(); ;
            if (disc < 0)
            {
                equationResult.ResultType = ResultType.NotRealRoot;
            }
            else
            {
                equationResult.ResultType = ResultType.RealRoot;
                equationResult.Root1 = (-1 * equation.B + Math.Sqrt(disc)) / 2 * equation.A;
                equationResult.Root2 = (-1 * equation.B - Math.Sqrt(disc)) / 2 * equation.A;
            }

            return equationResult;
        }
    }
}
