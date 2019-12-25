using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Service
{
    public class CalculatorService: ICalculatorService
    {
        private String resultNumber = "";
        List<Double> numbers = new List<Double>();
        private Stack<Operation> executedOperations = new Stack<Operation>();
        private Stack<Operation> expectedOperations = new Stack<Operation>();

        public String GetResult()
        {
            return resultNumber;
        }
        public String CurrentNumber(string number)
        {
            resultNumber += number;
            return resultNumber;
        }
        public void SetData(List<Double> bigIntegers)
        {
            numbers = new List<Double>(bigIntegers);
            executedOperations.Clear();
            expectedOperations.Clear();
        }
        public List<Double> Execute(Operation operation)
        {
            executedOperations.Push(operation);
            return operation.execute(ref numbers);
        }
    }
}