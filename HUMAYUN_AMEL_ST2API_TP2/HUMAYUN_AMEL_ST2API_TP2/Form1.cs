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
                temp.Text = myDeserializedClass.Weather[0].description;
                Sunset.Text = convertDateTime(myDeserializedClass.Sys.sunset).ToString();
                Sunrise.Text = convertDateTime(myDeserializedClass.Sys.sunrise).ToString();
                
                // add wind

                // convert in %
                Humidity.Text = myDeserializedClass.Main.humidity.ToString();
                

                double pressure = myDeserializedClass.Main.pressure;
                Pressure.Text = pressure.ToString();

                Speed.Text = myDeserializedClass.Wind.speed.ToString();
                
                double temperature = ConvertKC(myDeserializedClass.Main.temp);
                Convert.ToInt32(temperature);
                temp.Text = temperature.ToString();
            }
        }

        DateTime convertDateTime (long millisec)
        {
            DateTime day = new DateTime(2022, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddMilliseconds(millisec).ToLocalTime();
            return day;
        }

        public double ConvertKC(double a) // Kelvin en Celsius
        {
            double c = 273.15;
            double tempe = a - c;
            return tempe;
        }

        public int ConvertHPa(int a)
        {
            // 1H hPa = 1000 Pascal
            // => x hPA = a / 1000 Pascal 

            int hPa = a / 1000;
            return hPa;
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
