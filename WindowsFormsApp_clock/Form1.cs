using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DateTime a = DateTime.Now;
            label1.Text = a.ToLongTimeString();
            vTimer.Tick += new EventHandler(ShowTime);
            vTimer.Interval = 1000;
            vTimer.Start();
        }
        private static Timer vTimer = new Timer();
        private void ShowTime(object vObj, EventArgs e)
        {
            // перетворення в рядок
            label1.Text = DateTime.Now.ToLongTimeString();
        }


    }
}
