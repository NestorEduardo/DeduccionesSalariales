namespace DeduccionesSalariales.Models
{
    public class Deduction
    {
        public string Name { get; set; }
        public string RelativeDeduction { get; set; }
        public string AbsoluteDeduction { get; set; }
        public string FromSalary { get; set; }
        public string UntilSalary { get; set; }
        public string MaximumDeduction { get; set; }
    }
}
