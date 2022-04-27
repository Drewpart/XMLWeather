using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{

    public partial class ForecastScreen : UserControl
    {


        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public void displayForecast()
        {


            Form1.days[1].date = "Thursday";
            Form1.days[2].date = "Friday";
            Form1.days[3].date = "Saturday";
            Form1.days[4].date = "Sunday";
            Form1.days[5].date = "Monday";
            Form1.days[6].date = "Tuesday";

            date1.Text = Form1.days[1].date;
           min1.Text = Form1.days[1].tempLow;
            max1.Text = Form1.days[1].tempHigh;

            date2.Text = Form1.days[2].date;
            min2.Text = Form1.days[2].tempLow;
            max2.Text = Form1.days[2].tempHigh;


            date3.Text = Form1.days[3].date;
            max3.Text = Form1.days[3].tempHigh;
            min3.Text = Form1.days[3].tempLow;

            date4.Text = Form1.days[4].date;
            max4.Text = Form1.days[4].tempHigh;
            min4.Text = Form1.days[4].tempLow;

            date5.Text = Form1.days[5].date;
            max5.Text = Form1.days[5].tempHigh;
            min5.Text = Form1.days[5].tempLow;

            date6.Text = Form1.days[6].date;
            max6.Text = Form1.days[6].tempHigh;
            min6.Text = Form1.days[6].tempLow;

            //date7.Text = Form1.days[7].date;
            //max7.Text = Form1.days[7].tempHigh;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
