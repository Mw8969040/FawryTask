using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryTask
{
    public class Fine
    {
        public string? plateNumber { get; set; }
        public List<Violation>? violations { get; set; }

        public Fine(string? plateNumber, List<Violation> violations)
        {
            this.plateNumber = plateNumber;
            this.violations = violations;
        }

        private decimal TotalAmount => violations?.Sum(v => v.price)??0;

        public void PrintFine()
        {
            Console.WriteLine($"Car PlateNumber : {plateNumber}");
            Console.WriteLine($"Total amount {TotalAmount}");
            Console.WriteLine($"All Violations");

            foreach (var v in violations)
            {

                Console.WriteLine($"Description {v.descryption}");
                Console.WriteLine($"price {v.price}\n");

            }
            
        }
    }
}
