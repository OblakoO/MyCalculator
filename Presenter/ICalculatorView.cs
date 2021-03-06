﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Presenter
{
    public interface ICalculatorView
    {
        event Action OperationEvent;
        event Delegat.ReturnClick ReturnClick;

        event Action ZnakPlus;
        event Action ZnakMinus;
        event Action ZnakMultiply;
        event Action ZnakDivide;
        event Action ZnakStepen2;
        event Action ZnakStepen;
        event Action ZnakSqrt;
        event Action ZnakSqrt2;
        event Action ZnakLog;
        event Action ZnakFact;
        event Action ZnakMed;
        event Action ZnakSTD;

        event Action Number0v2;
        event Action Number1v2;
        event Action Number2v2;
        event Action Number3v2;
        event Action Number4v2;
        event Action Number5v2;
        event Action Number6v2;
        event Action Number7v2;
        event Action Number8v2;
        event Action Number9v2;
        event Action ClickDotv2;

        event Action Number0;     
        event Action Number1;
        event Action Number2;
        event Action Number3;
        event Action Number4;
        event Action Number5;
        event Action Number6;
        event Action Number7;
        event Action Number8;
        event Action Number9;
        event Action ClickDot;
        event Action ClickProbel;

        event Delegat.OperationExecuteDelegate OperationExecuteEvent;

        event Delegat.SetData1 SetData;
 
        string NumberZero { get; }
        string NumberOne { get; }
        string NumberTwo { get; }
        string NumberThree { get; }
        string NumberFour { get; }
        string NumberFive { get; }
        string NumberSix { get; }
        string NumberSeven { get; }
        string NumberEight { get; }
        string NumberNine { get; }
        string Dot { get;  }
        string Probel { get; }

        void ShowList(DataTable dataTable); //new

        void ShowInfo(string resultNow);
        void ShowInfo2(string resultNow2);     
        void Show();
    }
}
