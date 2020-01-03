using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
    public class Mediana: Operation
    {
        public override List<Double> execute(ref List<Double> numbers)
        {
            int numberCount = numbers.Count();
            int halfIndex = numbers.Count() / 2;
            var sortedNumbers = numbers.OrderBy(n => n);
            Double median;
            if ((numberCount % 2) == 0)
            {
                median = ((sortedNumbers.ElementAt(halfIndex) +
                           sortedNumbers.ElementAt((halfIndex - 1))) / 2);
            }
            else
            {
                median = sortedNumbers.ElementAt(halfIndex);
            }

            var newNumber = new List<Double>();
            newNumber.Add(median);
            numbers = newNumber;
            return numbers;
        }
    }
}
