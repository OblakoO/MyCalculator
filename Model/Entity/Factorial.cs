using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
    public class Factorial: Operation
    {
        public Factorial()
        {
        }

        public override List<Double> execute(ref List<Double> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] = fact(numbers[i]);
            }

            return numbers;
        }

        public Double fact(Double number)
        {
            Double result = 1;
            while (number != 1)
            {
                result = result * number;
                number = number - 1;
            }

            return result;
        }
    }
}
