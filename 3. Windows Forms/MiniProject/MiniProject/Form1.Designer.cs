namespace MiniProject
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
            this.userInput1 = new System.Windows.Forms.TextBox();
            this.conv = new System.Windows.Forms.Button();
            this.kg = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.lbOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userInput1
            // 
            this.userInput1.Location = new System.Drawing.Point(34, 165);
            this.userInput1.Name = "userInput1";
            this.userInput1.Size = new System.Drawing.Size(133, 20);
            this.userInput1.TabIndex = 0;
            // 
            // conv
            // 
            this.conv.Location = new System.Drawing.Point(183, 250);
            this.conv.Name = "conv";
            this.conv.Size = new System.Drawing.Size(145, 37);
            this.conv.TabIndex = 2;
            this.conv.Text = "Convert";
            this.conv.UseVisualStyleBackColor = true;
            this.conv.Click += new System.EventHandler(this.conv_Click);
            // 
            // kg
            // 
            this.kg.AutoSize = true;
            this.kg.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kg.Location = new System.Drawing.Point(76, 49);
            this.kg.Name = "kg";
            this.kg.Size = new System.Drawing.Size(54, 24);
            this.kg.TabIndex = 3;
            this.kg.Text = "Kilos";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.Location = new System.Drawing.Point(397, 49);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(71, 24);
            this.lb.TabIndex = 4;
            this.lb.Text = "Pounds";
            // 
            // lbOutput
            // 
            this.lbOutput.AutoSize = true;
            this.lbOutput.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOutput.Location = new System.Drawing.Point(397, 161);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(0, 24);
            this.lbOutput.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 410);
            this.Controls.Add(this.lbOutput);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.kg);
            this.Controls.Add(this.conv);
            this.Controls.Add(this.userInput1);
            this.Name = "Form1";
            this.Text = "Weight Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userInput1;
        private System.Windows.Forms.Button conv;
        private System.Windows.Forms.Label kg;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label lbOutput;
    }
}

