using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyWebCalculator.Models;
using MathLib;



namespace MyWebCalculator.Controllers
{
    public class CalculatorController : Controller
    {

        public string Add(decimal one, decimal two)
        {
            decimal final = MathRoutines.Add(one,two);
            return $"{one} + {two} = {final}";
        }

        public string Ceiling(decimal number)
        {
            decimal final = MathRoutines.Ceiling(number);
            return $"The ceiling of {number} is {final}";
        }

        public string Floor(decimal number)
        {
            decimal final = MathRoutines.Floor(number);
            return $"The floor of {number} is {final}";
        }

        public string Subtract(decimal one, decimal two)
        {
            decimal final = MathRoutines.Subtract(one,two);
            return $"{one} - {two} = {final}";
        }

        public string Multiply(decimal one, decimal two)
        {
            decimal final = MathRoutines.Multiply(one,two);
            return $"{one} * {two} = {final}";
        }

        public string Divide(decimal one, decimal two)
        {
            decimal final = MathRoutines.Divide(one,two);
            return $"{one} / {two} = {final}";
        }

        public string Power(double number, double power)
        {
            double final = MathRoutines.Power(number, power);
            return $"{number} to the power of {power} is {final}";
        }
    }
}
