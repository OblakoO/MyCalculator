using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
    public class Log: Operation
    {
        public Log(Double number) : base(number)
        {
        }

        public override List<Double> execute(ref List<Double> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] = Math.Round((Double)Math.Log((double)numbers[i], (double)number),3);
            }

            return numbers;
        }
    }
}
