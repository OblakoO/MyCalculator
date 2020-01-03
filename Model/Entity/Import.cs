using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
    public class Import: Operation
    {
        public Import()
        {
        }
        public override List<Double> execute(ref List<Double> numbers)
        {
            return numbers;
        }
    }
}
