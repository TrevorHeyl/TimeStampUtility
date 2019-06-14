namespace TSutility
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
                  this.groupBox1 = new System.Windows.Forms.GroupBox();
                  this.button3 = new System.Windows.Forms.Button();
                  this.label3 = new System.Windows.Forms.Label();
                  this.textBox3 = new System.Windows.Forms.TextBox();
                  this.button2 = new System.Windows.Forms.Button();
                  this.label2 = new System.Windows.Forms.Label();
                  this.textBox2 = new System.Windows.Forms.TextBox();
                  this.groupBox2 = new System.Windows.Forms.GroupBox();
                  this.label1 = new System.Windows.Forms.Label();
                  this.button1 = new System.Windows.Forms.Button();
                  this.textBox1 = new System.Windows.Forms.TextBox();
                  this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
                  this.groupBox3 = new System.Windows.Forms.GroupBox();
                  this.radioButton2 = new System.Windows.Forms.RadioButton();
                  this.radioButton1 = new System.Windows.Forms.RadioButton();
                  this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
                  this.groupBox1.SuspendLayout();
                  this.groupBox2.SuspendLayout();
                  this.groupBox3.SuspendLayout();
                  this.SuspendLayout();
                  // 
                  // groupBox1
                  // 
                  this.groupBox1.Controls.Add(this.button3);
                  this.groupBox1.Controls.Add(this.label3);
                  this.groupBox1.Controls.Add(this.textBox3);
                  this.groupBox1.Controls.Add(this.button2);
                  this.groupBox1.Controls.Add(this.label2);
                  this.groupBox1.Controls.Add(this.textBox2);
                  this.groupBox1.Location = new System.Drawing.Point(16, 15);
                  this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
                  this.groupBox1.Name = "groupBox1";
                  this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
                  this.groupBox1.Size = new System.Drawing.Size(276, 151);
                  this.groupBox1.TabIndex = 0;
                  this.groupBox1.TabStop = false;
                  this.groupBox1.Text = "TS to Date";
                  // 
                  // button3
                  // 
                  this.button3.Location = new System.Drawing.Point(184, 32);
                  this.button3.Margin = new System.Windows.Forms.Padding(4);
                  this.button3.Name = "button3";
                  this.button3.Size = new System.Drawing.Size(64, 25);
                  this.button3.TabIndex = 5;
                  this.button3.Text = "Paste";
                  this.toolTip1.SetToolTip(this.button3, "Paste from clipboard");
                  this.button3.UseVisualStyleBackColor = true;
                  this.button3.Click += new System.EventHandler(this.button3_Click);
                  // 
                  // label3
                  // 
                  this.label3.AutoSize = true;
                  this.label3.Location = new System.Drawing.Point(32, 111);
                  this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                  this.label3.Name = "label3";
                  this.label3.Size = new System.Drawing.Size(38, 17);
                  this.label3.TabIndex = 4;
                  this.label3.Text = "Date";
                  // 
                  // textBox3
                  // 
                  this.textBox3.Location = new System.Drawing.Point(80, 107);
                  this.textBox3.Margin = new System.Windows.Forms.Padding(4);
                  this.textBox3.Name = "textBox3";
                  this.textBox3.Size = new System.Drawing.Size(167, 22);
                  this.textBox3.TabIndex = 3;
                  // 
                  // button2
                  // 
                  this.button2.Location = new System.Drawing.Point(33, 66);
                  this.button2.Margin = new System.Windows.Forms.Padding(4);
                  this.button2.Name = "button2";
                  this.button2.Size = new System.Drawing.Size(215, 31);
                  this.button2.TabIndex = 2;
                  this.button2.Text = "Convert TS to Date";
                  this.toolTip1.SetToolTip(this.button2, "Click to convert a UNIX timestamp to a Julian date");
                  this.button2.UseVisualStyleBackColor = true;
                  this.button2.Click += new System.EventHandler(this.button2_Click);
                  // 
                  // label2
                  // 
                  this.label2.AutoSize = true;
                  this.label2.Location = new System.Drawing.Point(32, 36);
                  this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                  this.label2.Name = "label2";
                  this.label2.Size = new System.Drawing.Size(26, 17);
                  this.label2.TabIndex = 1;
                  this.label2.Text = "TS";
                  // 
                  // textBox2
                  // 
                  this.textBox2.Location = new System.Drawing.Point(80, 32);
                  this.textBox2.Margin = new System.Windows.Forms.Padding(4);
                  this.textBox2.Name = "textBox2";
                  this.textBox2.Size = new System.Drawing.Size(167, 22);
                  this.textBox2.TabIndex = 0;
                  // 
                  // groupBox2
                  // 
                  this.groupBox2.Controls.Add(this.label1);
                  this.groupBox2.Controls.Add(this.button1);
                  this.groupBox2.Controls.Add(this.textBox1);
                  this.groupBox2.Controls.Add(this.dateTimePicker1);
                  this.groupBox2.Location = new System.Drawing.Point(312, 15);
                  this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
                  this.groupBox2.Name = "groupBox2";
                  this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
                  this.groupBox2.Size = new System.Drawing.Size(264, 151);
                  this.groupBox2.TabIndex = 1;
                  this.groupBox2.TabStop = false;
                  this.groupBox2.Text = "Date To TS";
                  // 
                  // label1
                  // 
                  this.label1.AutoSize = true;
                  this.label1.Location = new System.Drawing.Point(32, 111);
                  this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                  this.label1.Name = "label1";
                  this.label1.Size = new System.Drawing.Size(26, 17);
                  this.label1.TabIndex = 3;
                  this.label1.Text = "TS";
                  // 
                  // button1
                  // 
                  this.button1.Location = new System.Drawing.Point(32, 66);
                  this.button1.Margin = new System.Windows.Forms.Padding(4);
                  this.button1.Name = "button1";
                  this.button1.Size = new System.Drawing.Size(200, 27);
                  this.button1.TabIndex = 2;
                  this.button1.Text = "Convert Date to TS";
                  this.toolTip1.SetToolTip(this.button1, "Click to convert a Julian date to a UNIX timestamp");
                  this.button1.UseVisualStyleBackColor = true;
                  this.button1.Click += new System.EventHandler(this.button1_Click);
                  // 
                  // textBox1
                  // 
                  this.textBox1.Location = new System.Drawing.Point(72, 110);
                  this.textBox1.Margin = new System.Windows.Forms.Padding(4);
                  this.textBox1.Name = "textBox1";
                  this.textBox1.Size = new System.Drawing.Size(159, 22);
                  this.textBox1.TabIndex = 1;
                  // 
                  // dateTimePicker1
                  // 
                  this.dateTimePicker1.Location = new System.Drawing.Point(29, 32);
                  this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
                  this.dateTimePicker1.Name = "dateTimePicker1";
                  this.dateTimePicker1.Size = new System.Drawing.Size(201, 22);
                  this.dateTimePicker1.TabIndex = 0;
                  // 
                  // groupBox3
                  // 
                  this.groupBox3.Controls.Add(this.radioButton2);
                  this.groupBox3.Controls.Add(this.radioButton1);
                  this.groupBox3.Location = new System.Drawing.Point(16, 185);
                  this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
                  this.groupBox3.Name = "groupBox3";
                  this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
                  this.groupBox3.Size = new System.Drawing.Size(276, 97);
                  this.groupBox3.TabIndex = 2;
                  this.groupBox3.TabStop = false;
                  this.groupBox3.Text = "Epoch Start";
                  // 
                  // radioButton2
                  // 
                  this.radioButton2.AutoSize = true;
                  this.radioButton2.Checked = true;
                  this.radioButton2.Location = new System.Drawing.Point(29, 59);
                  this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
                  this.radioButton2.Name = "radioButton2";
                  this.radioButton2.Size = new System.Drawing.Size(108, 21);
                  this.radioButton2.TabIndex = 1;
                  this.radioButton2.TabStop = true;
                  this.radioButton2.Text = "2000 Jan 01";
                  this.radioButton2.UseVisualStyleBackColor = true;
                  // 
                  // radioButton1
                  // 
                  this.radioButton1.AutoSize = true;
                  this.radioButton1.Location = new System.Drawing.Point(29, 31);
                  this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
                  this.radioButton1.Name = "radioButton1";
                  this.radioButton1.Size = new System.Drawing.Size(100, 21);
                  this.radioButton1.TabIndex = 0;
                  this.radioButton1.Text = "1970 Jan 1";
                  this.radioButton1.UseVisualStyleBackColor = true;
                  // 
                  // Form1
                  // 
                  this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
                  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                  this.BackColor = System.Drawing.SystemColors.ControlLight;
                  this.ClientSize = new System.Drawing.Size(599, 305);
                  this.Controls.Add(this.groupBox3);
                  this.Controls.Add(this.groupBox2);
                  this.Controls.Add(this.groupBox1);
                  this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
                  this.HelpButton = true;
                  this.Margin = new System.Windows.Forms.Padding(4);
                  this.Name = "Form1";
                  this.Text = "Timestamp Conversion Utility";
                  this.groupBox1.ResumeLayout(false);
                  this.groupBox1.PerformLayout();
                  this.groupBox2.ResumeLayout(false);
                  this.groupBox2.PerformLayout();
                  this.groupBox3.ResumeLayout(false);
                  this.groupBox3.PerformLayout();
                  this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

