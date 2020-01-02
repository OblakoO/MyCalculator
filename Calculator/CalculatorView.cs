using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model.Entity;
using Presenter;
using Model;


namespace Calculator
{
    public partial class CalculatorView : Form, ICalculatorView
    {
        private ApplicationContext _applicationContext;

        public event Action Number0v2;          
        public event Action Number1v2;
        public event Action Number2v2;
        public event Action Number3v2;
        public event Action Number4v2;
        public event Action Number5v2;
        public event Action Number6v2;
        public event Action Number7v2;
        public event Action Number8v2;
        public event Action Number9v2;
        public event Action ClickDotv2;

        public event Action Number0;
        public event Action Number1;
        public event Action Number2;
        public event Action Number3;
        public event Action Number4;
        public event Action Number5;
        public event Action Number6;
        public event Action Number7;
        public event Action Number8;
        public event Action Number9;
        public event Action ClickDot;
        public event Action ClickProbel;

        public event Delegat.OperationExecuteDelegate OperationExecuteEvent;
        public event Delegat.SetData1 SetData;
        //public event Delegat.SetData2 SetData2;

        public string NumberZero => button0.Text;
        public string NumberOne => button1.Text;
        public string NumberTwo => button2.Text;
        public string NumberThree => button3.Text;
        public string NumberFour => button4.Text;
        public string NumberFive => button5.Text;
        public string NumberSix => button6.Text;
        public string NumberSeven => button7.Text;
        public string NumberEight => button8.Text;
        public string NumberNine => button9.Text;
        public string Dot => b_dot.Text;
        public string Probel => b_Probel.Text;

        public bool start = false;

        public CalculatorView(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
            InitializeComponent();
        }

        //кнопки цифр, точка и пробел

        private void button0_Click(object sender, EventArgs e)
        {
            if (start == false)
            {
                Number0?.Invoke();
            }
            else
            {
                Number0v2?.Invoke();
            }
                
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (start == false)
            {
                Number1?.Invoke();
            }
            else
            {
                Number1v2?.Invoke();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (start == false)
            {
                Number2?.Invoke();
            }
            else
            {
                Number2v2?.Invoke();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (start == false)
            {
                Number3?.Invoke();
            }
            else
            {
                Number3v2?.Invoke();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (start == false)
            {
                Number4?.Invoke();
            }
            else
            {
                Number4v2?.Invoke();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (start == false)
            {
                Number5?.Invoke();
            }
            else
            {
                Number5v2?.Invoke();
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (start == false)
            {
                Number6?.Invoke();
            }
            else
            {
                Number6v2?.Invoke();
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (start == false)
            {
                Number7?.Invoke();
            }
            else
            {
                Number7v2?.Invoke();
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (start == false)
            {
                Number8?.Invoke();
            }
            else
            {
                Number8v2?.Invoke();
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (start == false)
            {
                Number9?.Invoke();
            }
            else
            {
                Number9v2?.Invoke();
            }
        }
        private void b_dot_Click(object sender, EventArgs e)
        {
            if (start == false)
            {
                ClickDot?.Invoke();
            }
            else
            {
                ClickDotv2?.Invoke();
            }
        }
        private void b_Probel_Click(object sender, EventArgs e)
        {
            if(start == false)
            ClickProbel?.Invoke();
        }

        //метод показать инфу

        public void ShowInfo(string resultNow)
        {
                textBox1.Text = resultNow;
        }
        public void ShowInfo2(string resultNow2)
        {
                textBox4.Text = resultNow2;
        }
        private void b_Start_Click(object sender, EventArgs e)
        {
            start = true;
        }



        public void ShowList(DataTable dataTable)     //new
        {
            grid_History.DataSource = dataTable;
        }


        //кнопки действий
        public void UpdateNumbers(List<Double> numbers)
        {
            //string result = "";
           // result += string.Join(" ", numbers);


            //string tempStr = data.Text;
            //tempStr += "\n" + result;
            //data.Text = tempStr;
        }

        private void b_plus_Click(object sender, EventArgs e)
        {
            OperationExecuteEvent?.Invoke(new Summa(Double.Parse(textBox4.Text)));
            
        }

        private void b_equally_Click(object sender, EventArgs e)
        {
           // string[] strings = textBox1.Text.Split(' ');
            //List<Double> bigIntegers = strings.Select(numberString => Double.Parse(numberString)).ToList();
            //SetData?.Invoke(bigIntegers);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void grid_History_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void b_Undo_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click_1(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
