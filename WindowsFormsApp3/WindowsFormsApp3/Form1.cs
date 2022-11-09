using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = "hh:mm dddd MMMM dd,yyyy";
        }
        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            label4.Text = dateTimePicker3.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dateTimePicker3.Visible = true;
            button1.Visible = false;
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dateTimePicker3.Visible =false;
            button1.Visible = true;
            button2.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
           
        }


    }
}
