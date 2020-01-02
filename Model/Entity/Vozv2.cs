using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
    public class Vozv2 : Operation
    {
        public Vozv2()
        {
        }
        public override List<Double> execute(ref List<Double> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] *= Math.Round(numbers[i],3);
            }
            return numbers;
        }
    }
}
