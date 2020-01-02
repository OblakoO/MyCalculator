using Model.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Service
{
    public class CalculatorService : ICalculatorService
    {

        public CalculatorService()
        {
            historyOfOperation = new DataTable();
            historyOfOperation.Columns.Add("Commands");
            historyOfOperation.Columns.Add("Numbers");
        }


        private String resultNumber = "";
        private String resultNumber2 = "";
        List<Double> numbers = new List<Double>();
        //List<Double> numbers2 = new List<Double>();
        private Stack<Operation> executedOperations = new Stack<Operation>();
        private Stack<Operation> expectedOperations = new Stack<Operation>();

        


        private DataTable historyOfOperation; //new
        
        public DataTable GetHistory()  //new
        {
            AddNewRow();
            return historyOfOperation;
        }

        public void AddNewRow()
        {
            
            DataRow dataRow = historyOfOperation.NewRow();
            dataRow["Commands"] = resultNumber2;
            dataRow["Numbers"] = numbers;

            historyOfOperation.Rows.Add(dataRow);
            
            //return historyOfOperation;
        }

        //для окошек заполнения цифр
        public String GetResult()
        {
            return resultNumber;
        }
        public String GetResult2()
        {
            return resultNumber2;
        }
        public String CurrentNumber(string number)
        {
            resultNumber += number;
            return resultNumber;
        }
        public String CurrentNumber2(string number)
        {
            resultNumber2 += number;
            return resultNumber2;
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