using Model.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private string thisznak = "";
        private string result = "";
        private String resultNumber = "";
        private String resultNumber2 = "";
        List<Double> numbers = new List<Double>();
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
            UpdateNumbers(numbers);
            DataRow dataRow = historyOfOperation.NewRow();
            dataRow["Commands"] =thisznak + resultNumber2;
            dataRow["Numbers"] = result;

            historyOfOperation.Rows.Add(dataRow);

            resultNumber = result;
            resultNumber2 = "";
            thisznak = "";
        }

        public void DeleteRows(int indexRow, int rows)
        {
        
            while (rows > indexRow+1)
            {
                DataRow b = historyOfOperation.Rows[rows-1];
                historyOfOperation.Rows.Remove(b);
                rows--;
            }
            GetResultTable(indexRow);
        }

        public void GetResultTable(int indexRow)
        {
            DataRow dataRow = historyOfOperation.Rows[indexRow];
            resultNumber = dataRow[1].ToString();
     
        }

        public void UpdateNumbers(List<Double> numbers)
        {
            result = "";
            result += string.Join(" ", numbers);
        }

        public String Znak(string znak)
        {
            thisznak = znak;
            return thisznak;
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