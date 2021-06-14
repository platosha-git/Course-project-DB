using System;
using System.Windows.Forms;

namespace Tours
{
    public partial class FormManageTour : Form
    {
        Tour Tour;
        public FormManageTour()
        {
            InitializeComponent();
            DateTime dateB = new DateTime(2022, 03, 10);
            DateTime dateE = new DateTime(2022, 05, 01);
            Tour = new Tour { Tourid = 11, Food = 1, Hotel = 2, Transfer = 3, Cost = 4, Datebegin = dateB.Date, Dateend = dateE.Date };
        }

        private void TbuttonAd_Click(object sender, EventArgs e)
        {
            ReturnTour();
        }

        public Tour ReturnTour()
        {
            
            Tour.Tourid = Convert.ToInt32(richTextBox1.Text);
            Tour.Food = Convert.ToInt32(richTextBox2.Text);
            Tour.Hotel = Convert.ToInt32(richTextBox3.Text);
            Tour.Transfer = Convert.ToInt32(richTextBox4.Text);
            Tour.Cost = Convert.ToInt32(richTextBox5.Text);
            Tour.Datebegin = dateTimePicker1.Value;
            Tour.Dateend = dateTimePicker2.Value;
            this.Close();
            return Tour;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
