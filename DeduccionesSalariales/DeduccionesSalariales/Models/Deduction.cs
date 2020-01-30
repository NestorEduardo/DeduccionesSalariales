namespace DeduccionesSalariales.Models
{
    public class Deduction
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double RelativeDeduction { get; set; }
        public decimal AbsoluteDeduction { get; set; }
        public decimal FromSalary { get; set; }
        public decimal UntilSalary { get; set; }
        public bool IsActive { get; set; }
    }
}
