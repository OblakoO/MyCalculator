﻿using Model.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model.Service
{
    public interface ICalculatorService {
        DataTable GetHistory();   //new
        void AddNewRow();   //new
        void DeleteRows(int indexRow, int rows);
        //для окошек заполнения цифрами
        String GetResult();
        String GetResult2();
        String Znak(string znak);
        String CurrentNumber(string number);
        String CurrentNumber2(string number);
        void SetData(List<Double> bigIntegers);
        void UpdateNumbers(List<Double> numbers);
        List<Double> Execute(Operation operation);
    }
}
