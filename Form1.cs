using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace BasicThreading
{
    public partial class FrmBasicThread : Form
    {
        public FrmBasicThread()
        {
            InitializeComponent();
        }

        private void FrmBasicThread_Load(object sender, EventArgs e)
        {
            
        }

        public void method()
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {

            ThreadStart delthreadstart = new ThreadStart(method);

            Thread ThreadA = new Thread(delthreadstart);
            ThreadA.Name = "Thread A Process";

            Thread ThreadB = new Thread(delthreadstart);
            ThreadB.Name = "Thread B Process";

            ThreadA.Start();
            ThreadB.Start();


            Console.WriteLine("- Before Starting Thread -");
            for (int i = 0; i <= 5; i++)
            {

                ThreadA.Join();
                ThreadB.Join();



                Console.WriteLine("Name of Thread: " + ThreadA.Name + " = " + i);
                Console.WriteLine("Name of Thread: " + ThreadB.Name + " = " + i);

                Thread.Sleep(1500);
                Thread thread = Thread.CurrentThread;

            }
            this.ThreadLabel.Text = "- End Of Threading -";
            Console.WriteLine(" - This is the end of Thread - ");
        }

     
    }
}
