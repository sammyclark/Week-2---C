using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoQuiz
{
    public partial class Form1 : Form
    {
        //variables for timer
        int timeLeft = 60;
        bool q1Correct = false;
        bool q2Correct = false;
        bool q3Correct = false;

        public Form1()
        {
            InitializeComponent();

            //starts with picture and group boxes invisible
            pictureBox1.Visible = false;
            groupBox1.Visible = false;
            pictureBox2.Visible = false;
            groupBox2.Visible = false;
            pictureBox3.Visible = false;
            groupBox3.Visible = false;
        }

        private void radioButtonQ1A1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ1A1.Checked)
            {
                label1.ForeColor = Color.Red;
                label1.Text = "\u00fb"; //cross character
                q1Correct = false;
            }
        }

        private void radioButtonQ1A2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ1A2.Checked)
            {
                label1.ForeColor = Color.Green;
                label1.Text = "\u00fc"; //tick character
                q1Correct = true;
            }
        }

        private void radioButtonQ1A3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ1A3.Checked)
            {
                label1.ForeColor = Color.Red;
                label1.Text = "\u00fb"; //cross character
                q1Correct = false;
            }
        }

        private void radioButtonQ2A1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ2A1.Checked)
            {
                label2.ForeColor = Color.Green;
                label2.Text = "\u00fc"; //tick character
                q2Correct = true;
            }
        }
        private void radioButtonQ2A2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ2A2.Checked)
            {
                label2.ForeColor = Color.Red;
                label2.Text = "\u00fb"; //cross character
                q2Correct = false;
            }
        }

        private void radioButtonQ2A3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ2A3.Checked)
            {
                label2.ForeColor = Color.Red;
                label2.Text = "\u00fb"; //cross character
                q3Correct = false;
            }
        }

        private void radioButtonQ3A1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ3A1.Checked)
            {
                label3.ForeColor = Color.Red;
                label3.Text = "\u00fb"; //cross character
                q3Correct = false;
            }
        }

        private void radioButtonQ3A2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ3A2.Checked)
            {
                label3.ForeColor = Color.Red;
                label3.Text = "\u00fb"; //cross character
                q3Correct = false;
            }
        }

        private void radioButtonQ3A3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ3A3.Checked)
            {
                label3.ForeColor = Color.Green;
                label3.Text = "\u00fc"; //tick character
                q3Correct = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {       //stops time if person gets everything right
            if (q1Correct && q2Correct && q3Correct)
            {
                timer1.Stop();
                MessageBox.Show("You got everything right.");
            }
            else if(timeLeft > 0)
            {
                //update and display time left
                timeLeft--;
                time.Text = timeLeft + "seconds";
            }
            else
            {
                //if user runs out of time
                timer1.Stop();
                time.Text = "Time's up";
                MessageBox.Show("You ran out of time", "Sorry");
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            //when timre is started group boxes and picture boxes become visible
            timer1.Start();
            pictureBox1.Visible = true;
            groupBox1.Visible = true;
            pictureBox2.Visible = true;
            groupBox2.Visible = true;
            pictureBox3.Visible = true;
            groupBox3.Visible = true;
            buttonStart.Enabled = false;
        }
    }
    
}
