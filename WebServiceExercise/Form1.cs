using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebServiceExercise.TemperatureServiceReference;

namespace WebServiceExercise
{
    public partial class Form1 : Form
    {
        TempWebServiceSoapClient tempWS = new TempWebServiceSoapClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCelsiusToFahrenheit_Click(object sender, EventArgs e)
        {
            double celsius = 0;
            double fahrenheit = 0;
            double kelvin = 0;
            string temp1 = cmbTemp.SelectedItem.ToString();
            string temp2 = cmbTempList.SelectedItem.ToString();

            if (temp1 == "Celsius" && temp2 == "Fahrenheit")
            {
                Double.TryParse(txtTemp1.Text, out celsius);
                fahrenheit = tempWS.CelsiusToFahrenheit(celsius);
                txtTemp2.Text = fahrenheit.ToString();
            }
            else if (temp1 == "Celsius" && temp2 == "Kelvin")
            {
                Double.TryParse(txtTemp1.Text, out celsius);
                kelvin = tempWS.CelsiusToKelvin(celsius);
                txtTemp2.Text = kelvin.ToString();
            }
            else if (temp1 == "Fahrenheit" && temp2 == "Celsius")
            {
                Double.TryParse(txtTemp1.Text, out fahrenheit);
                celsius = tempWS.FahrenheitToCelsius(fahrenheit);
                txtTemp2.Text = celsius.ToString();
            }
            else if (temp1 == "Fahrenheit" && temp2 == "Kelvin")
            {
                Double.TryParse(txtTemp1.Text, out fahrenheit);
                kelvin = tempWS.FahrenheitToKelvin(fahrenheit);
                txtTemp2.Text = kelvin.ToString();
            }
            else if (temp1 == "Kelvin" && temp2 == "Celsius")
            {
                Double.TryParse(txtTemp1.Text, out kelvin);
                celsius = tempWS.KelvinToCelsius(kelvin);
                txtTemp2.Text = celsius.ToString();
            }
            else if (temp1 == "Kelvin" && temp2 == "Fahrenheit")
            {
                Double.TryParse(txtTemp1.Text, out kelvin);
                fahrenheit = tempWS.KelvinToFahrenheit(kelvin);
                txtTemp2.Text = fahrenheit.ToString();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeTempBox();
            cmbTemp.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTempList.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cmbTemp_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitializeTempBox2();
            txtTemp1.Clear();
            txtTemp2.Clear();
        }

        public void InitializeTempBox()
        {
            List<string> listTemp = new List<string>();
            listTemp.Add("Celsius");
            listTemp.Add("Fahrenheit");
            listTemp.Add("Kelvin");
            cmbTemp.DataSource = listTemp;
        }

        public void InitializeTempBox2()
        {
            List<string> listTemp2 = new List<string>();
            listTemp2.Add("Celsius");
            listTemp2.Add("Fahrenheit");
            listTemp2.Add("Kelvin");
            string choice = cmbTemp.SelectedItem.ToString();
            listTemp2.Remove(choice);
            cmbTempList.DataSource = listTemp2;

        }
    }
}
