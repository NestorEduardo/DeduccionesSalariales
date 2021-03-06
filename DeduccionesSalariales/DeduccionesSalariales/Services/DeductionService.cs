﻿using DeduccionesSalariales.Models;
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
        public Deductions GetDeductions(decimal netSalary) => deductionRepository.GetDeductions(netSalary);
    }
}
