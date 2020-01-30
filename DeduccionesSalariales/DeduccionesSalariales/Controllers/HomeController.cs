using DeduccionesSalariales.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace DeduccionesSalariales.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly IDeductionService deductionService;
        public HomeController(IDeductionService deductionService)
        {
            this.deductionService = deductionService;
        }

        [HttpGet]
        public int GetDeductions(decimal salary)
        {
            deductionService.GetDeductions(salary);
            return 1;
        }
    }
}