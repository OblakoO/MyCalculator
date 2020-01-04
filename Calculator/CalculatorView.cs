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
using System.IO;

namespace Calculator
{
    public partial class CalculatorView : Form, ICalculatorView
    {
        private ApplicationContext _applicationContext;

        public event Action OperationEvent;
        public event  Delegat.ReturnClick ReturnClick;

        public event Action ZnakPlus;
        public event Action ZnakMinus;
        public event Action ZnakMultiply;
        public event Action ZnakDivide;
        public event Action ZnakStepen2;
        public event Action ZnakStepen;
        public event Action ZnakSqrt;
        public event Action ZnakSqrt2;
        public event Action ZnakLog;
        public event Action ZnakFact;
        public event Action ZnakMed;
        public event Action ZnakSTD;

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
        public bool ravno = false;
        public string znak;

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

        private void b_plus_Click(object sender, EventArgs e)
        {
            if (ravno == false &&(textBox1.Text == "" || textBox4.Text == ""))
            {
                MessageBox.Show("Одно из полей не заполнено");
            }
            else
            if (start == true && ravno == false)
            {
                ZnakPlus?.Invoke();
                Update();
                OperationExecuteEvent?.Invoke(new Summa(Double.Parse(textBox4.Text)));
                OperationEvent?.Invoke();
            }
        }
        private void b_minus_Click(object sender, EventArgs e)
        {
            if (ravno == false && (textBox1.Text == "" || textBox4.Text == ""))
            {
                MessageBox.Show("Одно из полей не заполнено");
            }
            else
               if (start == true && ravno == false)
            {
                ZnakMinus?.Invoke();
                Update();
                OperationExecuteEvent?.Invoke(new Minus(Double.Parse(textBox4.Text)));
                OperationEvent?.Invoke();
            }
        }
        private void b_multiply_Click(object sender, EventArgs e)
        {
            if (ravno == false && (textBox1.Text == "" || textBox4.Text == ""))
            {
                MessageBox.Show("Одно из полей не заполнено");
            }
            else
               if (start == true && ravno == false)
            {
                ZnakMultiply?.Invoke();
                Update();
                OperationExecuteEvent?.Invoke(new Umno(Double.Parse(textBox4.Text)));
                OperationEvent?.Invoke();
            }
        }
        private void b_divide_Click(object sender, EventArgs e)
        {
            if (ravno == false && (textBox1.Text == "" || textBox4.Text == ""))
            {
                MessageBox.Show("Одно из полей не заполнено");
            }
            else
               if (start == true && ravno == false)
            {
                ZnakDivide?.Invoke();
                Update();
                OperationExecuteEvent?.Invoke(new Podel(Double.Parse(textBox4.Text)));
                OperationEvent?.Invoke();
            }
        }
        private void b_stepen2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Поле не заполнено");
            }
            else
               if (start == true && ravno == false)
            {
                ZnakStepen2?.Invoke();
                Update();
                OperationExecuteEvent?.Invoke(new Vozv2());
                OperationEvent?.Invoke();
            }
        }
        private void b_sepen_Click(object sender, EventArgs e)
        {
            if (ravno == false && (textBox1.Text == "" || textBox4.Text == ""))
            {
                MessageBox.Show("Одно из полей не заполнено");
            }
            else
               if (start == true && ravno == false)
            {
                ZnakStepen?.Invoke();
                Update();
                OperationExecuteEvent?.Invoke(new Vozv(Double.Parse(textBox4.Text)));
                OperationEvent?.Invoke();
            }
        }
        private void b_sqrt2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Поле не заполнено");
            }
            else
               if (start == true && ravno == false)
            {
                ZnakSqrt2?.Invoke();
                Update();
                OperationExecuteEvent?.Invoke(new Koren2());
                OperationEvent?.Invoke();
            }
        }
        private void b_sqrt_Click(object sender, EventArgs e)
        {
            if (ravno == false && (textBox1.Text == "" || textBox4.Text == ""))
            {
                MessageBox.Show("Одно из полей не заполнено");
            }
            else
               if (start == true && ravno == false)
            {
                ZnakSqrt?.Invoke();
                Update();
                OperationExecuteEvent?.Invoke(new Koren(Double.Parse(textBox4.Text)));
                OperationEvent?.Invoke();
            }
        }
        private void b_log_Click(object sender, EventArgs e)
        {
            if (ravno == false && (textBox1.Text == "" || textBox4.Text == ""))
            {
                MessageBox.Show("Одно из полей не заполнено");
            }
            else
               if (start == true && ravno == false)
            {
                ZnakLog?.Invoke();
                Update();
                OperationExecuteEvent?.Invoke(new Log(Double.Parse(textBox4.Text)));
                OperationEvent?.Invoke();
            }
        }
        private void b_fact_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Поле не заполнено");
            }
            else
               if (start == true && ravno == false)
            {
                ZnakFact?.Invoke();
                Update();
                OperationExecuteEvent?.Invoke(new Factorial());
                OperationEvent?.Invoke();
            }
        }
        private void b_med_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Поле не заполнено");
            }
            else
               if (start == true && ravno == false)
            {
                ZnakMed?.Invoke();
                Update();
                OperationExecuteEvent?.Invoke(new Mediana());
                OperationEvent?.Invoke();
            }
        }     
        private void b_std_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Поле не заполнено");
            }
            else
               if (start == true && ravno == false)
            {
                ZnakSTD?.Invoke();
                Update();
                OperationExecuteEvent?.Invoke(new STD());
                OperationEvent?.Invoke();
            }
        }

        private void button10_Click_1(object sender, EventArgs e)    //import
        {
            if (ravno == false)
            {
                StreamReader sr = new StreamReader(Application.StartupPath + "\\input.txt");
                List<Double> bigIntegers = new List<Double>();
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    bigIntegers.Add(Double.Parse(line));
                }
                SetData?.Invoke(bigIntegers);
                OperationExecuteEvent?.Invoke(new Import());
                OperationEvent?.Invoke();
                start = true;
            }
        }
        private void button11_Click(object sender, EventArgs e)   //export
        {
            StreamWriter sw = new StreamWriter(Application.StartupPath + "\\output.txt");
            string[] strings = textBox1.Text.Split(' ');
            List<Double> bigIntegers = strings.Select(numberString => Double.Parse(numberString)).ToList();
            bigIntegers.ForEach(number => sw.WriteLine(number));
            sw.Close();
        }

        public void Update()
        {
            string[] strings = textBox1.Text.Split(' ');
            List<Double> bigIntegers = strings.Select(numberString => Double.Parse(numberString)).ToList();
            SetData?.Invoke(bigIntegers);
        }

        private void b_equally_Click(object sender, EventArgs e)
        {
            ravno = true;
            MessageBox.Show("Расчёт окончен. Вы можете только экспортировать результаты в файл.");
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



        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void grid_History_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            int rows = grid_History.Rows.Count -1;

            //MessageBox.Show(rows.ToString(), Text);
            //MessageBox.Show(indexRow.ToString(), Text);
            //CurrentRow.Index;
            ReturnClick?.Invoke(indexRow, rows);
            OperationEvent?.Invoke();
        }
    }
}
