using DeduccionesSalariales.Models;
using DeduccionesSalariales.Repository.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeduccionesSalariales.Repository
{
    public class DeductionRepository : IDeductionRepository
    {
        private readonly ApplicationDbContext context;
        public DeductionRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<ICollection<Deduction>> GetDeductions(decimal netSalary)
        {
            return await context.Deductions.Where(d => d.FromSalary >= netSalary && d.UntilSalary <= netSalary && d.IsActive).ToListAsync();
        }
    }
}
