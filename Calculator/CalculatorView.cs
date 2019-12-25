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

        public CalculatorView(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            Number0?.Invoke();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Number1?.Invoke();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Number2?.Invoke();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Number3?.Invoke();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Number4?.Invoke();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Number5?.Invoke();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Number6?.Invoke();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Number7?.Invoke();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Number8?.Invoke();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Number9?.Invoke();
        }

        private void b_dot_Click(object sender, EventArgs e)
        {
            ClickDot?.Invoke();
        }

        private void b_Probel_Click(object sender, EventArgs e)
        {
            ClickProbel?.Invoke();
        }

        public void ShowInfo(string resultNow)
        {
            textBox1.Text = resultNow;
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
