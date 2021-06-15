﻿using System;
using System.Windows.Forms;

namespace Tours
{
    public partial class FormManageTour : Form
    {
        public enum ChangeObj : int
        {
            Tour,
            Hotel,
            Food
        }

        Tour Tour;
        Hotel Hotel;

        public FormManageTour(ChangeObj obj)
        {
            InitializeComponent();

            if (obj == ChangeObj.Tour)
            {
                MtabControl.Controls.Remove(MtabPageHotel);
            }

            else if (obj == ChangeObj.Hotel)
            {
                MtabControl.Controls.Remove(MtabPageTour);
            }

            DateTime dateB = new DateTime(2022, 03, 10);
            DateTime dateE = new DateTime(2022, 05, 01);
            Tour = new Tour { Tourid = 11, Food = 1, Hotel = 2, Transfer = 3, Cost = 4, Datebegin = dateB.Date, Dateend = dateE.Date };

            Hotel = new Hotel { Hotelid = 11, Name = "Tenerife", Type = "Кемпинг", Class = 4, Swimpool = true, City = "Самара", Cost = 12190 };
        }

        /*--------------------------------------------------------------
         *                          Tour
         * -----------------------------------------------------------*/
        private void TbuttonAd_Click(object sender, EventArgs e)
        {
            ReturnTour();
        }

        public Tour ReturnTour()
        {

            try
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
            catch (Exception er)
            {
                return null;
            }
            
        }

        /*--------------------------------------------------------------
         *                          Hotel
         * -----------------------------------------------------------*/
        private void HbuttonAdd_Click(object sender, EventArgs e)
        {
            ReturnHotel();
        }

        public Hotel ReturnHotel()
        {

            try
            {
                Hotel.Hotelid = Convert.ToInt32(richTextBox10.Text);
                Hotel.City = richTextBox9.Text;
                Hotel.Name = richTextBox8.Text;
                Hotel.Type = richTextBox7.Text;
                Hotel.Class = (int)numericUpDown1.Value;
                Hotel.Swimpool = (numericUpDown2.Value == 0) ? false : true;
                Hotel.Cost = Convert.ToInt32(richTextBox6.Text);
                this.Close();
                return Hotel;
            }
            catch (Exception er)
            {
                return null;
            }

        }
    }
}
