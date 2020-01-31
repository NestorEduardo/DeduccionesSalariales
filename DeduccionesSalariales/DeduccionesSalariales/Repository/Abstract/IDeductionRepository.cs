using DeduccionesSalariales.Models;

namespace DeduccionesSalariales.Repository.Abstract
{
    public interface IDeductionRepository
    {
        public Deductions GetDeductions(decimal netSalary);
    }
}
