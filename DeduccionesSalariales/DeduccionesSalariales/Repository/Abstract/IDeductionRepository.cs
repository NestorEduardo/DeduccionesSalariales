using DeduccionesSalariales.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DeduccionesSalariales.Repository.Abstract
{
    public interface IDeductionRepository
    {
        public Task<ICollection<Deduction>> GetDeductions(decimal netSalary);
    }
}
