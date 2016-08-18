﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo1
{
    public partial class Form1 : Form
    {
        string name = "";

        public Form1()
        {
            InitializeComponent();
        }      

        private void button1_Click(object sender, EventArgs e)
        {
            //get name from text box
            name = textBoxName.Text;

            //work out how old the person is in days
            DateTime today = DateTime.Now.Date;
            TimeSpan ageDays = today - dateTimePicker1.Value;

            //work out age in years
            int years = ((int)ageDays.TotalDays) / 365;

            //get date from date time picker to use in message
            int day = dateTimePicker1.Value.Day;

            //get the month as a word
            string month = dateTimePicker1.Value.ToString("MMMM");

            //assemble message
            label3.Text = "Hello, " + name + "! You will be " + (years + 1) + " years old on " + day + " " + month + ".";
        }
    }
}
