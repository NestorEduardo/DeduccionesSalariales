using DeduccionesSalariales.Models;
using DeduccionesSalariales.Repository.Abstract;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.IO;
using System.Linq;

namespace DeduccionesSalariales.Repository
{
    public class DeductionRepository : IDeductionRepository
    {
        public readonly IConfiguration configuration;
        public DeductionRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public Deductions GetDeductions(decimal netSalary)
        {
            string response = "";

            using (StreamReader streamReader = new StreamReader("appsettings.json"))
            {
                response = streamReader.ReadToEndAsync().Result.ToString();
            }                

            Deductions deductions = JsonConvert.DeserializeObject<Deductions>(response);
            return (Deductions)deductions.deductions.Where(d => d.FromSalary >= netSalary && d.UntilSalary <= netSalary);
        }
    }
}
