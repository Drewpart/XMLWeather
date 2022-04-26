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
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            cityOutput.Text = Form1.days[0].location;
            tempLabel.Text = Math.Round(Convert.ToDouble(Form1.days[0].currentTemp)).ToString("##");
            minOutput.Text = Math.Round(Convert.ToDouble(Form1.days[0].tempLow)).ToString("##");
            maxOutput.Text = Math.Round(Convert.ToDouble(Form1.days[0].tempHigh)).ToString("##");

            int conditionCode = Convert.ToInt32(Form1.days[0].condition);

            if (conditionCode >=200 && conditionCode < 600) //rain
            {
                //show appropriate image here
                pictureBox2 = 
            }
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        private void tempLabel_Click(object sender, EventArgs e)
        {

        }

        private void CurrentScreen_Load(object sender, EventArgs e)
        {

        }
    }
}