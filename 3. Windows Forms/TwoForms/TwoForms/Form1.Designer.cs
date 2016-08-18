﻿namespace TwoForms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonChangeColour = new System.Windows.Forms.Button();
            this.buttonNextForm = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(123, 103);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(119, 20);
            this.buttonOpenFile.TabIndex = 0;
            this.buttonOpenFile.Text = "Open a text file";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // buttonChangeColour
            // 
            this.buttonChangeColour.Location = new System.Drawing.Point(110, 193);
            this.buttonChangeColour.Name = "buttonChangeColour";
            this.buttonChangeColour.Size = new System.Drawing.Size(148, 24);
            this.buttonChangeColour.TabIndex = 1;
            this.buttonChangeColour.Text = "Change background colour";
            this.buttonChangeColour.UseVisualStyleBackColor = true;
            this.buttonChangeColour.Click += new System.EventHandler(this.buttonChangeColour_Click);
            // 
            // buttonNextForm
            // 
            this.buttonNextForm.Location = new System.Drawing.Point(141, 278);
            this.buttonNextForm.Name = "buttonNextForm";
            this.buttonNextForm.Size = new System.Drawing.Size(75, 23);
            this.buttonNextForm.TabIndex = 2;
            this.buttonNextForm.Text = "Next form";
            this.buttonNextForm.UseVisualStyleBackColor = true;
            this.buttonNextForm.Click += new System.EventHandler(this.buttonNextForm_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(343, 92);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(329, 263);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 396);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonNextForm);
            this.Controls.Add(this.buttonChangeColour);
            this.Controls.Add(this.buttonOpenFile);
            this.Name = "Form1";
            this.Text = "Two Forms";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonChangeColour;
        private System.Windows.Forms.Button buttonNextForm;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

