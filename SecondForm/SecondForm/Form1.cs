using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondForm
{
    public partial class Form1 : Form
    {

        delegate void MyFirstDelegate();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyFirstDelegate mySuccessDelegate = new MyFirstDelegate(callMeOnSuccess);

            mySuccessDelegate.Invoke(); 
        }

        private static void callMeOnSuccess()
        {
            MessageBox.Show("Success");
        }


        private static void callMeOnFail()
        {
            MessageBox.Show("fail");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MyFirstDelegate myFailDelegate = new MyFirstDelegate(callMeOnFail);
            myFailDelegate.Invoke();
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            Status.Text = "Mouse down";
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            Status.Text = "Mouse hover";
        }
    }
}
