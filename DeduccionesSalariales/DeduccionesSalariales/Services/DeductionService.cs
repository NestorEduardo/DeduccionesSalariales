using DeduccionesSalariales.Models;
using DeduccionesSalariales.Repository;
using DeduccionesSalariales.Services.Abstract;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DeduccionesSalariales.Services
{
    public class DeductionService : IDeductionService
    {
        private readonly DeductionRepository deductionRepository;
        public DeductionService(DeductionRepository deductionRepository)
        {
            this.deductionRepository = deductionRepository;
        }
        public async Task<ICollection<Deduction>> GetDeductions(decimal netSalary) => await deductionRepository.GetDeductions(netSalary);
    }
}
