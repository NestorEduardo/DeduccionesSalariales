using System.Collections.Generic;

namespace DeduccionesSalariales.Models
{
    public class Deduction
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal RelativeDeduction { get; set; }
        public decimal AbsoluteDeduction { get; set; }
        public decimal FromSalary { get; set; }
        public decimal UntilSalary { get; set; }
        public decimal MaximumDeduction { get; set; }
    }
}
