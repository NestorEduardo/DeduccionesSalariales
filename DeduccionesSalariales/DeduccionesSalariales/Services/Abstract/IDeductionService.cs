using DeduccionesSalariales.Models;

namespace DeduccionesSalariales.Services.Abstract
{
    public interface IDeductionService
    {
        public Deductions GetDeductions(decimal netSalary);
    }
}
