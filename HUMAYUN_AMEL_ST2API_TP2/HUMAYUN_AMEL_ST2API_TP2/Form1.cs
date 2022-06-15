using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;

namespace HUMAYUN_AMEL_ST2API_TP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // API key
        string APIKey = "aecfcdedd663737cb5055aabf60844f3";

        // Interface graphique
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Ville
        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        // button search
        private void button2_Click(object sender, EventArgs e) 
        {
            getWeather();

        }

        // barre de recherche
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // Condition
        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        

        private void Sunset_Click(object sender, EventArgs e)
        {

        }

        void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", City.Text, APIKey);
                var json = web.DownloadString(url);

                Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(json);

                picIcon.ImageLocation = "https://openweathermap.org/img/w/" + myDeserializedClass.Weather[0].icon + ".png";
                Condition.Text = myDeserializedClass.Weather[0].main;

                // Sun(rise)set in UTC
                Sunset.Text = convertDateTime(myDeserializedClass.Sys.sunset).ToShortTimeString();
                Sunrise.Text = convertDateTime(myDeserializedClass.Sys.sunrise).ToShortTimeString();

                // Humidity in %
                int humidity = myDeserializedClass.Main.humidity;
                Humidity.Text = humidity.ToString() + " %";
                

                // Pressure
                int pressure = myDeserializedClass.Main.pressure;
                Pressure.Text = pressure.ToString() + " hPa";

                // Wind
                double speed = ConvertSpeed(myDeserializedClass.Wind.speed);
                double sp = Convert.ToInt32(speed);
                Speed.Text = speed.ToString() + " km/h ";

                // Temperature
                double temperature = ConvertKC(myDeserializedClass.Main.temp);
                double temps = Convert.ToInt32(temperature);
                temp.Text = temps.ToString() + " °C ";
            }
        }

        DateTime convertDateTime (long millisec)
        {
            DateTime day = new DateTime(2022, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(millisec).ToLocalTime();
            day = day.AddHours(1);
            return day;
        }

        public double ConvertKC(double a) // Kelvin en Celsius
        {
            double c = 273.15;
            double tempe = a - c;
            return tempe;
        }

        public double ConvertSpeed(double a) // Kelvin en Celsius
        {
            double k = 3.6;
            double speedk = a * k;
            return speedk;
        }


        private void Sunrise_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }

}
