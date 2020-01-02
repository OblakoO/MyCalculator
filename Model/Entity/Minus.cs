using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
    public class Minus: Operation
    {
        public Minus(Double number) : base(number)
        {
        }

        public override List<Double> execute(ref List<Double> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] -= Math.Round(number, 3);
            }
            return numbers;
        }
    }
}
