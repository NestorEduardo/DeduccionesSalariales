using System;
using System.Collections.Generic;
using DeduccionesSalariales.Models;
using DeduccionesSalariales.Services;
using Microsoft.AspNetCore.Mvc;

namespace DeduccionesSalariales.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly DeductionService deductionService;
        public HomeController(DeductionService deductionService)
        {
            this.deductionService = deductionService;
        }

        [HttpGet]
        public IEnumerable<Deduction> GetDeductions(decimal salary)
        {
            throw new NotImplementedException("");
        }
    }
}