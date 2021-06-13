using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tours
{
    public partial class FormManageTour : Form
    {
        Tour Tour = null;
        public FormManageTour(Tour tour)
        {
            InitializeComponent();
            Tour = tour;
        }

        private void TbuttonAd_Click(object sender, EventArgs e)
        {
            ReturnTour();
        }

        public Tour ReturnTour()
        {
            this.Close();
            return Tour;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Tour.Datebegin = dateTimePicker1.Value;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            Tour.Dateend = dateTimePicker2.Value;
        }

        private void MTtextBox1_TextChanged(object sender, EventArgs e)
        {
            int TID = Convert.ToInt32(MTtextBox1.Text);
            Tour.Tourid = TID;
        }

        private void MTtextBox2_TextChanged(object sender, EventArgs e)
        {
            int FID = Convert.ToInt32(MTtextBox2.Text);
            Tour.Food = FID;
        }

        private void MTtextBox3_TextChanged(object sender, EventArgs e)
        {
            int HID = Convert.ToInt32(MTtextBox3.Text);
            Tour.Hotel = HID;
        }

        private void MTtextBox4_TextChanged(object sender, EventArgs e)
        {
            int TID = Convert.ToInt32(MTtextBox4.Text);
            Tour.Transfer = TID;
        }

        private void MTtextBox5_TextChanged(object sender, EventArgs e)
        {
            int cost = Convert.ToInt32(MTtextBox5.Text);
            Tour.Cost = cost;
        }
    }
}
