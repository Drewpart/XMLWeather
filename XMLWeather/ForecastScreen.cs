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
            date1.Text = Form1.days[1].date;
           max1.Text = Form1.days[1].tempLow;
            max1.Text = Form1.days[1].tempHigh;

            date2.Text = Form1.days[2].date;
            max2.Text = Form1.days[2].tempLow;
            max2.Text = Form1.days[2].tempHigh;


            date3.Text = Form1.days[3].date;
            max3.Text = Form1.days[3].tempHigh;

            date4.Text = Form1.days[4].date;
            max4.Text = Form1.days[4].tempHigh;

            date5.Text = Form1.days[5].date;
            max5.Text = Form1.days[5].tempHigh;

            date6.Text = Form1.days[6].date;
            max6.Text = Form1.days[6].tempHigh;

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
