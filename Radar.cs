using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryTask
{
    public class Radar
    {
        public List<Rules>? rules = new List<Rules>(); 
        public List<Fine>? fines = new List<Fine>();

        public void AddNewRule(Rules rule)
        {
            rules?.Add(rule);
        }

        public Fine? CarPreview(CarsData car)
        {
            List<Violation> violations = new List<Violation>();
         
            foreach(var rule in rules)
            {
               var violation = rule.Check(car);

                if(violation != null) violations.Add(violation);
            }

            if(violations.Count > 0)
            {
                Fine fine = new(car.plateNumber,violations); 
                fines.Add(fine);
                fine.PrintFine();

                return fine;
            }

            return null;
        }

        public void PrintAllFines()
        {
            Console.WriteLine("\n========== All Fines ========== \n");

            foreach(var fine in fines)
            {
                Console.WriteLine($"car Plate : {fine.plateNumber}  | Tolal Amount : {fine.TotalAmount}");
            }
        }
    }
}
