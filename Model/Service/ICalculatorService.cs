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
        String GetResult2();
        String CurrentNumber(string number);
        String CurrentNumber2(string number);
        void SetData(List<Double> bigIntegers);
        List<Double> Execute(Operation operation);
    }
}
