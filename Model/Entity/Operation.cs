using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
    public abstract class Operation
    {
        public Double number;

        protected Operation(Double number)
        {
            this.number = number;
        }

        protected Operation()
        {
        }

        public abstract List<Double> execute(ref List<Double> numbers);
    }
}
