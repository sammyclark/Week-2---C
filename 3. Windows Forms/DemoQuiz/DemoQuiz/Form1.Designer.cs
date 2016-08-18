namespace DemoQuiz
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.neuroQuiz = new System.Windows.Forms.Label();
            this.craNerve = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonQ1A1 = new System.Windows.Forms.RadioButton();
            this.radioButtonQ1A2 = new System.Windows.Forms.RadioButton();
            this.radioButtonQ1A3 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rewPath = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButtonQ2A1 = new System.Windows.Forms.RadioButton();
            this.radioButtonQ2A2 = new System.Windows.Forms.RadioButton();
            this.radioButtonQ2A3 = new System.Windows.Forms.RadioButton();
            this.radioButtonQ3A1 = new System.Windows.Forms.RadioButton();
            this.radioButtonQ3A2 = new System.Windows.Forms.RadioButton();
            this.radioButtonQ3A3 = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.neuroQuiz, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonStart, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.time, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.timer, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(662, 636);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // neuroQuiz
            // 
            this.neuroQuiz.AutoSize = true;
            this.neuroQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.neuroQuiz.Location = new System.Drawing.Point(3, 0);
            this.neuroQuiz.Name = "neuroQuiz";
            this.neuroQuiz.Size = new System.Drawing.Size(152, 18);
            this.neuroQuiz.TabIndex = 0;
            this.neuroQuiz.Text = "Neuroscience Quiz";
            // 
            // craNerve
            // 
            this.craNerve.AutoSize = true;
            this.craNerve.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.craNerve.Location = new System.Drawing.Point(-3, 0);
            this.craNerve.Name = "craNerve";
            this.craNerve.Size = new System.Drawing.Size(283, 18);
            this.craNerve.TabIndex = 3;
            this.craNerve.Text = "Which one of these is not a cranial nerve?";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonQ1A3);
            this.groupBox1.Controls.Add(this.radioButtonQ1A2);
            this.groupBox1.Controls.Add(this.radioButtonQ1A1);
            this.groupBox1.Controls.Add(this.craNerve);
            this.groupBox1.Location = new System.Drawing.Point(168, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 153);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonQ1A1
            // 
            this.radioButtonQ1A1.AutoSize = true;
            this.radioButtonQ1A1.Location = new System.Drawing.Point(7, 22);
            this.radioButtonQ1A1.Name = "radioButtonQ1A1";
            this.radioButtonQ1A1.Size = new System.Drawing.Size(55, 17);
            this.radioButtonQ1A1.TabIndex = 4;
            this.radioButtonQ1A1.TabStop = true;
            this.radioButtonQ1A1.Text = "Vagus";
            this.radioButtonQ1A1.UseVisualStyleBackColor = true;
            this.radioButtonQ1A1.CheckedChanged += new System.EventHandler(this.radioButtonQ1A1_CheckedChanged);
            // 
            // radioButtonQ1A2
            // 
            this.radioButtonQ1A2.AutoSize = true;
            this.radioButtonQ1A2.Location = new System.Drawing.Point(7, 61);
            this.radioButtonQ1A2.Name = "radioButtonQ1A2";
            this.radioButtonQ1A2.Size = new System.Drawing.Size(109, 17);
            this.radioButtonQ1A2.TabIndex = 5;
            this.radioButtonQ1A2.TabStop = true;
            this.radioButtonQ1A2.Text = "Intercostobrachial";
            this.radioButtonQ1A2.UseVisualStyleBackColor = true;
            this.radioButtonQ1A2.CheckedChanged += new System.EventHandler(this.radioButtonQ1A2_CheckedChanged);
            // 
            // radioButtonQ1A3
            // 
            this.radioButtonQ1A3.AutoSize = true;
            this.radioButtonQ1A3.Location = new System.Drawing.Point(7, 107);
            this.radioButtonQ1A3.Name = "radioButtonQ1A3";
            this.radioButtonQ1A3.Size = new System.Drawing.Size(68, 17);
            this.radioButtonQ1A3.TabIndex = 6;
            this.radioButtonQ1A3.TabStop = true;
            this.radioButtonQ1A3.Text = "Trochear";
            this.radioButtonQ1A3.UseVisualStyleBackColor = true;
            this.radioButtonQ1A3.CheckedChanged += new System.EventHandler(this.radioButtonQ1A3_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonQ2A3);
            this.groupBox2.Controls.Add(this.radioButtonQ2A2);
            this.groupBox2.Controls.Add(this.radioButtonQ2A1);
            this.groupBox2.Controls.Add(this.rewPath);
            this.groupBox2.Location = new System.Drawing.Point(168, 225);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 137);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Wingdings", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label1.Location = new System.Drawing.Point(499, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 106);
            this.label1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Wingdings", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label2.Location = new System.Drawing.Point(499, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 106);
            this.label2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Wingdings", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label3.Location = new System.Drawing.Point(499, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 106);
            this.label3.TabIndex = 9;
            // 
            // rewPath
            // 
            this.rewPath.AutoSize = true;
            this.rewPath.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rewPath.Location = new System.Drawing.Point(6, 0);
            this.rewPath.Name = "rewPath";
            this.rewPath.Size = new System.Drawing.Size(194, 17);
            this.rewPath.TabIndex = 0;
            this.rewPath.Text = "Which is the reward pathway?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::DemoQuiz.Properties.Resources.neuron;
            this.pictureBox1.Location = new System.Drawing.Point(3, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::DemoQuiz.Properties.Resources.brain;
            this.pictureBox2.Location = new System.Drawing.Point(3, 225);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(159, 153);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = global::DemoQuiz.Properties.Resources.synapse;
            this.pictureBox3.Location = new System.Drawing.Point(3, 384);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(159, 153);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonQ3A3);
            this.groupBox3.Controls.Add(this.radioButtonQ3A2);
            this.groupBox3.Controls.Add(this.radioButtonQ3A1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(168, 384);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(325, 153);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(308, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Which of these is not a catecholamine neurotransmitter?";
            // 
            // radioButtonQ2A1
            // 
            this.radioButtonQ2A1.AutoSize = true;
            this.radioButtonQ2A1.Location = new System.Drawing.Point(7, 33);
            this.radioButtonQ2A1.Name = "radioButtonQ2A1";
            this.radioButtonQ2A1.Size = new System.Drawing.Size(114, 17);
            this.radioButtonQ2A1.TabIndex = 1;
            this.radioButtonQ2A1.TabStop = true;
            this.radioButtonQ2A1.Text = "Mesolimbic System";
            this.radioButtonQ2A1.UseVisualStyleBackColor = true;
            this.radioButtonQ2A1.CheckedChanged += new System.EventHandler(this.radioButtonQ2A1_CheckedChanged);
            // 
            // radioButtonQ2A2
            // 
            this.radioButtonQ2A2.AutoSize = true;
            this.radioButtonQ2A2.Location = new System.Drawing.Point(7, 70);
            this.radioButtonQ2A2.Name = "radioButtonQ2A2";
            this.radioButtonQ2A2.Size = new System.Drawing.Size(90, 17);
            this.radioButtonQ2A2.TabIndex = 2;
            this.radioButtonQ2A2.TabStop = true;
            this.radioButtonQ2A2.Text = "Hippocampus";
            this.radioButtonQ2A2.UseVisualStyleBackColor = true;
            this.radioButtonQ2A2.CheckedChanged += new System.EventHandler(this.radioButtonQ2A2_CheckedChanged);
            // 
            // radioButtonQ2A3
            // 
            this.radioButtonQ2A3.AutoSize = true;
            this.radioButtonQ2A3.Location = new System.Drawing.Point(6, 104);
            this.radioButtonQ2A3.Name = "radioButtonQ2A3";
            this.radioButtonQ2A3.Size = new System.Drawing.Size(90, 17);
            this.radioButtonQ2A3.TabIndex = 3;
            this.radioButtonQ2A3.TabStop = true;
            this.radioButtonQ2A3.Text = "Basal Ganglia";
            this.radioButtonQ2A3.UseVisualStyleBackColor = true;
            this.radioButtonQ2A3.CheckedChanged += new System.EventHandler(this.radioButtonQ2A3_CheckedChanged);
            // 
            // radioButtonQ3A1
            // 
            this.radioButtonQ3A1.AutoSize = true;
            this.radioButtonQ3A1.Location = new System.Drawing.Point(9, 33);
            this.radioButtonQ3A1.Name = "radioButtonQ3A1";
            this.radioButtonQ3A1.Size = new System.Drawing.Size(73, 17);
            this.radioButtonQ3A1.TabIndex = 1;
            this.radioButtonQ3A1.TabStop = true;
            this.radioButtonQ3A1.Text = "Dopamine";
            this.radioButtonQ3A1.UseVisualStyleBackColor = true;
            this.radioButtonQ3A1.CheckedChanged += new System.EventHandler(this.radioButtonQ3A1_CheckedChanged);
            // 
            // radioButtonQ3A2
            // 
            this.radioButtonQ3A2.AutoSize = true;
            this.radioButtonQ3A2.Location = new System.Drawing.Point(9, 78);
            this.radioButtonQ3A2.Name = "radioButtonQ3A2";
            this.radioButtonQ3A2.Size = new System.Drawing.Size(91, 17);
            this.radioButtonQ3A2.TabIndex = 2;
            this.radioButtonQ3A2.TabStop = true;
            this.radioButtonQ3A2.Text = "Noradrenaline";
            this.radioButtonQ3A2.UseVisualStyleBackColor = true;
            this.radioButtonQ3A2.CheckedChanged += new System.EventHandler(this.radioButtonQ3A2_CheckedChanged);
            // 
            // radioButtonQ3A3
            // 
            this.radioButtonQ3A3.AutoSize = true;
            this.radioButtonQ3A3.Location = new System.Drawing.Point(9, 120);
            this.radioButtonQ3A3.Name = "radioButtonQ3A3";
            this.radioButtonQ3A3.Size = new System.Drawing.Size(88, 17);
            this.radioButtonQ3A3.TabIndex = 3;
            this.radioButtonQ3A3.TabStop = true;
            this.radioButtonQ3A3.Text = "Acetylcholine";
            this.radioButtonQ3A3.UseVisualStyleBackColor = true;
            this.radioButtonQ3A3.CheckedChanged += new System.EventHandler(this.radioButtonQ3A3_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer
            // 
            this.timer.AutoSize = true;
            this.timer.Location = new System.Drawing.Point(168, 0);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(33, 13);
            this.timer.TabIndex = 12;
            this.timer.Text = "Timer";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(499, 0);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(0, 13);
            this.time.TabIndex = 13;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(168, 543);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 14;
            this.buttonStart.Text = "Start timer";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 636);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Biology Quiz";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label neuroQuiz;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonQ1A3;
        private System.Windows.Forms.RadioButton radioButtonQ1A2;
        private System.Windows.Forms.RadioButton radioButtonQ1A1;
        private System.Windows.Forms.Label craNerve;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label rewPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButtonQ2A3;
        private System.Windows.Forms.RadioButton radioButtonQ2A2;
        private System.Windows.Forms.RadioButton radioButtonQ2A1;
        private System.Windows.Forms.RadioButton radioButtonQ3A3;
        private System.Windows.Forms.RadioButton radioButtonQ3A2;
        private System.Windows.Forms.RadioButton radioButtonQ3A1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timer;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Button buttonStart;
    }
}

