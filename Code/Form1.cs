using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace API_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.SuspendLayout();
            this.ClientSize = new System.Drawing.Size(367, 188);
            this.Name = "Program";
            this.ResumeLayout(false);
            InitializeComponent();
        }

         void protectionloop()
         {
            Thread.Sleep(2000);

            Protect.This.Start();
            Thread.Sleep(2000);
            protectionloop();
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            protectionloop();

        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

           // protectionloop();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            protectionloop();
        }
    }
}
