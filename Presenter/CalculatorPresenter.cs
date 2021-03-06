﻿using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.Service;
using Presenter;
using Model.Entity;
using System.Data;
using System.Windows.Forms;

namespace Presenter
{
    public class CalculatorPresenter
    {
        protected IKernel _kernel { get; set; }
        protected ICalculatorService _calculateService { get; set; }
        protected ICalculatorView _view { get; set; }

        public CalculatorPresenter(IKernel kernel, ICalculatorService calculateService, ICalculatorView view)
        {
           
            _kernel = kernel;
            _calculateService = calculateService;
            _view = view;

            _view.OperationEvent += OperationEvent;
            _view.ReturnClick += ReturnClick;

            _view.ZnakPlus += ZnakPlus;
            _view.ZnakMinus += ZnakMinus;
            _view.ZnakMultiply += ZnakMultiply;
            _view.ZnakDivide+= ZnakDivide;
            _view.ZnakStepen2 += ZnakStepen2;
            _view.ZnakStepen += ZnakStepen;
            _view.ZnakSqrt += ZnakSqrt;
            _view.ZnakSqrt2 += ZnakSqrt2;
            _view.ZnakLog += ZnakLog;
            _view.ZnakFact += ZnakFact;
            _view.ZnakMed += ZnakMed;
            _view.ZnakSTD += ZnakSTD;


            _view.Number0v2 += Number0v2;
            _view.Number1v2 += Number1v2;
            _view.Number2v2 += Number2v2;
            _view.Number3v2 += Number3v2;
            _view.Number4v2 += Number4v2;
            _view.Number5v2 += Number5v2;
            _view.Number6v2 += Number6v2;
            _view.Number7v2 += Number7v2;
            _view.Number8v2 += Number8v2;
            _view.Number9v2 += Number9v2;
            _view.ClickDotv2 += ClickDotv2;

            _view.Number0 += Number0;
            _view.Number1 += Number1;
            _view.Number2 += Number2;
            _view.Number3 += Number3;
            _view.Number4 += Number4;
            _view.Number5 += Number5;
            _view.Number6 += Number6;
            _view.Number7 += Number7;
            _view.Number8 += Number8;
            _view.Number9 += Number9;
            _view.ClickDot += ClickDot;
            _view.ClickProbel += ClickProbel;

            _view.SetData += SetData1;
            _view.OperationExecuteEvent += ExecuteOperationExecute;  //new

        }

        private void ReturnClick(int indexRow, int rows)
        {
            //DataGridView gd = (DataGridView)sender;

            //    foreach (DataGridViewRow selected_row in gd.SelectedRows)
            //    {

            //        //_calculateService.DeleteRows(selected_row);
            //    }
            _calculateService.DeleteRows(indexRow, rows);
        }

        private void ZnakSTD()
        {
            string znak = "STD";
            _calculateService.Znak(znak);
        }
        private void ZnakMed()
        {
            string znak = "Mediana";
            _calculateService.Znak(znak);
        }
        private void ZnakFact()
        {
            string znak = "!";
            _calculateService.Znak(znak);
        }
        private void ZnakLog()
        {
            string znak = "log ";
            _calculateService.Znak(znak);
        }
        private void ZnakSqrt2()
        {
            string znak = "^1/2";
            _calculateService.Znak(znak);
        }
        private void ZnakSqrt()
        {
            string znak = "^1/";
            _calculateService.Znak(znak);
        }
        private void ZnakStepen()
        {
            string znak = "^";
            _calculateService.Znak(znak);
        }
        private void ZnakStepen2()
        {
            string znak = "^2";
            _calculateService.Znak(znak);
        }
        private void ZnakDivide()
        {
            string znak = ":";
            _calculateService.Znak(znak);
        }
        private void ZnakMultiply()
        {
            string znak = "x";
            _calculateService.Znak(znak);
        }
        private void ZnakPlus()
        {
            string znak = "+";
            _calculateService.Znak(znak);
        }
        private void ZnakMinus()
        {
            string znak = "-";
            _calculateService.Znak(znak);
        }

        private void OperationEvent()
        {
            ShowInfo();
            ShowInfo2();
        }

        public void ShowList()
        {
            _view.ShowList(_calculateService.GetHistory());
        }

        private void ExecuteOperationExecute(Operation operation) //new
        {
            List<Double> numbers = _calculateService.Execute(operation);

            ShowList();
        }

        private void SetData1(List<Double> numbers)          //new
        {
            _calculateService.SetData(numbers);
        }


        private void ClickProbel()
        {
            string probel = _view.Probel;
            _calculateService.CurrentNumber(probel);
            ShowInfo();
        }
        private void ClickDot()
        {
            string dot = _view.Dot;
            _calculateService.CurrentNumber(dot);
            ShowInfo();
        }
        private void ClickDotv2()
        {
            string dot = _view.Dot;
            _calculateService.CurrentNumber2(dot);
            ShowInfo2();
        }

        private void ShowInfo()
        {
            _view.ShowInfo(_calculateService.GetResult());
        }
        private void ShowInfo2()   
        {
            _view.ShowInfo2(_calculateService.GetResult2());
        }
        private void Number0()
        {
            string numberZero = _view.NumberZero;
            _calculateService.CurrentNumber(numberZero);
             ShowInfo();
        }
        private void Number0v2()     
        {
            string numberZero = _view.NumberZero;
            _calculateService.CurrentNumber2(numberZero);
            ShowInfo2();
        }
        private void Number1()
        {
            string numberOne = _view.NumberOne;
            _calculateService.CurrentNumber(numberOne);
            ShowInfo();
        }
        private void Number1v2()       
        {
            string numberOne = _view.NumberOne;
            _calculateService.CurrentNumber2(numberOne);
            ShowInfo2();
        }
        private void Number2()
        {
            string numberTwo = _view.NumberTwo;
            _calculateService.CurrentNumber(numberTwo);
            ShowInfo();
        }
        private void Number2v2()       
        {
            string numberTwo = _view.NumberTwo;
            _calculateService.CurrentNumber2(numberTwo);
            ShowInfo2();
        }
        private void Number3()
        {
            string numberThree = _view.NumberThree;
            _calculateService.CurrentNumber(numberThree);
            ShowInfo();
        }
        private void Number3v2()       
        {
            string numberThree = _view.NumberThree;
            _calculateService.CurrentNumber2(numberThree);
            ShowInfo2();
        }
        private void Number4()
        {
            string numberFour = _view.NumberFour;
            _calculateService.CurrentNumber(numberFour);
            ShowInfo();
        }
        private void Number4v2()       
        {
            string numberFour = _view.NumberFour;
            _calculateService.CurrentNumber2(numberFour);
            ShowInfo2();
        }
        private void Number5()
        {
            string numberFive = _view.NumberFive;
            _calculateService.CurrentNumber(numberFive);
            ShowInfo();
        }
        private void Number5v2()       
        {
            string numberFive = _view.NumberFive;
            _calculateService.CurrentNumber2(numberFive);
            ShowInfo2();
        }
        private void Number6()
        {
            string numberSix = _view.NumberSix;
            _calculateService.CurrentNumber(numberSix);
            ShowInfo();
        }
        private void Number6v2()       
        {
            string numberSix = _view.NumberSix;
            _calculateService.CurrentNumber2(numberSix);
            ShowInfo2();
        }
        private void Number7()
        {
            string numberSeven = _view.NumberSeven;
            _calculateService.CurrentNumber(numberSeven);
            ShowInfo();
        }
        private void Number7v2()       
        {
            string numberSeven = _view.NumberSeven;
            _calculateService.CurrentNumber2(numberSeven);
            ShowInfo2();
        }
        private void Number8()
        {
            string numberEight = _view.NumberEight;
            _calculateService.CurrentNumber(numberEight);
            ShowInfo();
        }
        private void Number8v2()       
        {
            string numberEight = _view.NumberEight;
            _calculateService.CurrentNumber2(numberEight);
            ShowInfo2();
        }
        private void Number9()
        {
            string numberNine = _view.NumberNine;
            _calculateService.CurrentNumber(numberNine);
            ShowInfo();
        }
        private void Number9v2()       
        {
            string numberNine = _view.NumberNine;
            _calculateService.CurrentNumber2(numberNine);
            ShowInfo2();
        }

        
        public void Run()
        {
            _view.Show();
        }
    }
}
