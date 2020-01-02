using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
    public class Koren2:Operation
    {
        public Koren2()
        {
        }
        public override List<Double> execute(ref List<Double> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] = Math.Round(Math.Sqrt(numbers[i]), 3);
            }
            return numbers;
        }
  
    }
}
