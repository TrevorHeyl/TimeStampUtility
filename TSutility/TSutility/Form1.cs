using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TSutility
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            double ts;

            try
            {
                ts = Convert.ToDouble(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a valid Timestamp", "Error", MessageBoxButtons.OK);
                return;
            }

            double epochstart=0;
            if (radioButton1.Checked) epochstart = 0;
            if (radioButton2.Checked) epochstart = 946677600;

            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            dtDateTime = dtDateTime.AddSeconds(epochstart + ts).ToLocalTime();
            textBox3.Text =  dtDateTime.ToString();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ts;

            DateTime result = dateTimePicker1.Value;
            if(radioButton1.Checked) 
            ts = (result - new DateTime(1970, 1, 1).ToLocalTime()).TotalSeconds;
            else
            ts =  ( result  - new DateTime(2000, 1, 1).ToLocalTime()).TotalSeconds;
            textBox1.Text = ((int)ts).ToString();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = Clipboard.GetText();
        }

    }
}
