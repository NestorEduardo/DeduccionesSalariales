using DeduccionesSalariales.Models;
using DeduccionesSalariales.Repository;
using DeduccionesSalariales.Repository.Abstract;
using DeduccionesSalariales.Services.Abstract;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DeduccionesSalariales.Services
{
    public class DeductionService : IDeductionService
    {
        private readonly IDeductionRepository deductionRepository;
        public DeductionService(IDeductionRepository deductionRepository)
        {
            this.deductionRepository = deductionRepository;
        }
        public async Task<ICollection<Deduction>> GetDeductions(decimal netSalary) => await deductionRepository.GetDeductions(netSalary);
    }
}
