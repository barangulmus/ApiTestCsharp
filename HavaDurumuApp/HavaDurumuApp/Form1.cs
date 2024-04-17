using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HavaDurumuApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string ApiKey = "0692228edbec544e1c1c56af205281b2";
            string ApiConnecting = $"http://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid={ApiKey}";
            XDocument hava = XDocument.Load(ApiConnecting);
            var sicaklik = hava.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            var ruzgar = hava.Descendants("speed").ElementAt(0).Attribute("value").Value;
            var nem = hava.Descendants("speed").ElementAt(0).Attribute("value").Value;
            var durum = hava.Descendants("weather").ElementAt(0).Attribute("value").Value;
            label3.Text = sicaklik + "°";
            label5.Text = ruzgar + "m/s";
            label7.Text = nem + "%";

            if (durum == "açık")
            {
                pictureBox1.ImageLocation = "C:\\Users\\devba\\source\\repos\\HavaDurumuApp\\Images\\acik.png";
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.BackColor = Color.Transparent;
            }
            if (durum == "kapalı")
            {
                pictureBox1.ImageLocation = "C:\\Users\\devba\\source\\repos\\HavaDurumuApp\\Images\\kapali.png";
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.BackColor = Color.Transparent;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string il = comboBox1.SelectedItem.ToString();
            string ApiKey = "0692228edbec544e1c1c56af205281b2";
            string ApiConnecting = $"http://api.openweathermap.org/data/2.5/weather?q={il}&mode=xml&lang=tr&units=metric&appid={ApiKey}";
            XDocument hava = XDocument.Load(ApiConnecting);
            var sicaklik = hava.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            var ruzgar = hava.Descendants("speed").ElementAt(0).Attribute("value").Value;
            var nem = hava.Descendants("speed").ElementAt(0).Attribute("value").Value;
            var durum = hava.Descendants("weather").ElementAt(0).Attribute("value").Value;
            label3.Text = sicaklik + "°";
            label5.Text = ruzgar + "m/s";
            label7.Text = nem + "%";

            if (durum == "açık")
            {
                pictureBox1.ImageLocation = "C:\\Users\\devba\\source\\repos\\HavaDurumuApp\\Images\\acik.png";
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.BackColor = Color.Transparent;
            }
            if (durum == "kapalı")
            {
                pictureBox1.ImageLocation = "C:\\Users\\devba\\source\\repos\\HavaDurumuApp\\Images\\kapali.png";
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.BackColor = Color.Transparent;
            }
            string seciliOlanIl = il;
            seciliOlanIl = char.ToUpper(seciliOlanIl[0]) + seciliOlanIl.Substring(1);
            label2.Text = seciliOlanIl;
        }
    }
}
