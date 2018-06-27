using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

// Разработать программу, которая по двойному щелчку запускает свою вторую копию.
namespace OSISP_Task_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {           
            Thread thread = new Thread(ApplicationStart);
            thread.Start();
        }

        private void ApplicationStart()
        {
            Application.Run(new Form1());
        }
    }
}
