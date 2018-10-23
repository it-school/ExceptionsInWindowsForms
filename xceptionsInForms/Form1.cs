using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xceptionsInForms
{
    public partial class Form1 : Form
    {
        DateTime date;
        String errorMessage;

        public Form1()
        {
            InitializeComponent();
            date = new DateTime();
            errorMessage = "";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            getDateValue();
        }

        private void getDateValue()
        {
            if (getDateTime(textBox1.Text))
                monthCalendar1.SetDate(date);
            else
            {
                MessageBox.Show(errorMessage);
                textBox1.Clear();
            }
        }

        private bool getDateTime(String datetime)
        {
            bool result = false;
            try
            {
                date = Convert.ToDateTime(datetime);
                result = true;
            }
            catch (Exception e)
            {
                errorMessage = e.Message;

            }
            return result;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                button1_Click(sender, e);
        }
    }
}
