using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Service
{
    public interface ICalculatorService { 
        String GetResult();
        String CurrentNumber(string number);
        void SetData(List<Double> bigIntegers);
        List<Double> Execute(Operation operation);
    }
}
