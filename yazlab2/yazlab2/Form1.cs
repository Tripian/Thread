using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace yazlab2
{

    public partial class Form1 : Form
    {
        int j = 10, i = 0;

        MainThread mt = new MainThread();
        Thread mt1 = new Thread(new ThreadStart(mt.requestAccept));
        Thread mt2 = new Thread(new ThreadStart(mt.requestReturn));
        
        /*List<Thread> subthreads = new List<Thread>(new ThreadStart(work2));
        Thread threadcreator = new Thread(new ThreadStart(work3));
        Thread threadwatcher = new Thread(new ThreadStart(work4));*/

        public Form1()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

            progressBar1.Increment(j);
            i += 10;
            if (i >= 70)
            {
                i = i / 2;
                progressBar1.Value = i;
            }
        }
    }
}
