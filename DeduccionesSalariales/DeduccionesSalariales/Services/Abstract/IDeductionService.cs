using DeduccionesSalariales.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DeduccionesSalariales.Services.Abstract
{
    public interface IDeductionService
    {
        public Task<ICollection<Deduction>> GetDeductions(decimal netSalary);
    }
}
