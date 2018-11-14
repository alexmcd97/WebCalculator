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

        public IActionResult Add(decimal one, decimal two)
        {
            decimal final = MathRoutines.Add(one,two);
            ViewData["Output"] = $"{one} + {two} = {final}";

            return View();
        }

        public IActionResult Ceiling(decimal number)
        {
            decimal final = MathRoutines.Ceiling(number);
            ViewData["Output"] = $"The ceiling of {number} is {final}";

            return View();
        }

        public IActionResult Floor(decimal number)
        {
            decimal final = MathRoutines.Floor(number);
            ViewData["Output"] = $"The floor of {number} is {final}";

            return View();
        }

        public IActionResult Subtract(decimal one, decimal two)
        {
            decimal final = MathRoutines.Subtract(one,two);
            ViewData["Output"] = $"{one} - {two} = {final}";

            return View();
        }

        public IActionResult Multiply(decimal one, decimal two)
        {
            decimal final = MathRoutines.Multiply(one,two);
            ViewData["Output"] = $"{one} * {two} = {final}";

            return View();
        }

        public IActionResult Divide(decimal one, decimal two)
        {
            decimal final = MathRoutines.Divide(one,two);
            ViewData["Output"] = $"{one} / {two} = {final}";

            return View();
        }

        public IActionResult Power(double number, double power)
        {
            double final = MathRoutines.Power(number, power);
            ViewData["Output"] = $"{number} to the power of {power} is {final}";

            return View();
        }
    }
}
