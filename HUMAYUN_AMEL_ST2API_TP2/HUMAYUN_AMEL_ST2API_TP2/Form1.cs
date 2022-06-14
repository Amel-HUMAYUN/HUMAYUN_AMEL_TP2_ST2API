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
                Sunset.Text = myDeserializedClass.Sys.sunset.ToString();
                Details.Text = myDeserializedClass.Weather[0].description;
                Sunrise.Text = myDeserializedClass.Sys.sunrise.ToString();
            }
        }

        private void Sunrise_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }
    }

}
