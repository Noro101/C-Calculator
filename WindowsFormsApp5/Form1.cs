using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {

        bool isOp = false;
        Double Patasxan=0;
        String Op="";

        public Form1()
        {
            InitializeComponent();
        }

        private void Button_click(object sender, EventArgs e)
        {
            Button Anun = (Button)sender;
            if(Box.Text=="0"||isOp==true)
            {
                Box.Clear();
            }
            Box.Text = Box.Text + Anun.Text;
            label1.Text = label1.Text + Anun.Text;
        }

        private void Click_del(object sender, EventArgs e)
        {
            Box.Text = "0";
        }

        private void Op_click(object sender, EventArgs e)
        {
            isOp = true;
            Button Btn = (Button)sender;
            Op = Btn.Text;
            Patasxan = double.Parse(Box.Text);
            label1.Text = label1.Text + Op;
        }

        private void Havasar(object sender, EventArgs e)
        {
          switch(Op)
          {

           case "+":
           Box.Text = (Patasxan + double.Parse(Box.Text)).ToString();
           break;

           case "-":
           Box.Text=(Patasxan-double.Parse(Box.Text)).ToString();
           break;

           case "*":
           Box.Text = (Patasxan * double.Parse(Box.Text)).ToString();
            break;

          case "/":
          Box.Text = (Patasxan / double.Parse(Box.Text)).ToString();
          break;
          }
            label1.Text = Box.Text;
            Box.Clear();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}
