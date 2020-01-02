using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter
{
    public class Delegat
    {
        public delegate void SetData1(List<Double> numbers);

        public delegate void OperationExecuteDelegate(Operation operation);
    }
}
