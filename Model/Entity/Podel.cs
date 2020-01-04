using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
    public class Podel : Operation
    {
        public Podel(Double number) : base(number)
        {
        }
        public override List<Double> execute(ref List<Double> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] = Math.Round(numbers[i] / number, 3);
            }
            return numbers;
        }
    }
}
