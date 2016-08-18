using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        decimal kilo;
        decimal pounds;


        private void conv_Click(object sender, EventArgs e)
        {
            kilo = Convert.ToDecimal(userInput1.Text);
            pounds = kilo * 2.2M;
            string lb = Convert.ToString(pounds);
            (lbOutput.Text) = lb;
            //lol £6000 and you're just playing battleship?
        }
    }
}
