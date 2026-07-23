using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryTask
{
    public class Violation
    {
        public string? descryption { get; set; }
        public decimal price { get; set; }

        public Violation(string? descryption , decimal price )
        {
            this.descryption = descryption;
            this.price = price;
             
        }
    }
}
