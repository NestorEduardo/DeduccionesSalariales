using DeduccionesSalariales.Models;
using DeduccionesSalariales.Repository.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DeduccionesSalariales.Repository
{
    public class DeductionRepository : IDeductionRepository
    {
        public readonly IConfiguration configuration;
        public DeductionRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public async Task<ICollection<Deduction>> GetDeductions(decimal netSalary)
        {
            string jsonResult = "";

            using (StreamReader streamReader = new StreamReader("appsettings.json"))
            {
                jsonResult = streamReader.ReadToEnd();
            }

            var x  = JsonConvert.DeserializeObject<List<Deduction>>(jsonResult);


            return null;
        }
    }
}
