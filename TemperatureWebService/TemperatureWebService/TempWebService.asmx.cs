using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace TemperatureWebService
{
    /// <summary>
    /// Summary description for TempWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class TempWebService : System.Web.Services.WebService
    {
        [WebMethod]
        public double CelsiusToFahrenheit(double celsius)
        {
            double fahrenheit = (celsius * 9) / 5 + 32;
            return Math.Round(fahrenheit,2);
        }

        [WebMethod]
        public double CelsiusToKelvin(double celsuis)
        {
            double kelvin = celsuis + 273.15;
            return Math.Round(kelvin,2);
        }

        [WebMethod]
        public double FahrenheitToCelsius(double fahrenheit)
        {
            double celsius = ((fahrenheit - 32) * 5) / 9;
            return Math.Round(celsius,2);
        }

        [WebMethod]
        public double FahrenheitToKelvin(double fahrenheit)
        {
            double kelvin = ((fahrenheit - 32) * 5) / 9 + 273.15;
            return Math.Round(kelvin,2);
        }

        [WebMethod]
        public double KelvinToCelsius(double kelvin)
        {
            double celsius = (kelvin - 273.15);
            return Math.Round(celsius,2);
        }

        [WebMethod]
        public double KelvinToFahrenheit(double kelvin)
        {
            double fahrenheit = ((kelvin - 273.15) * 9) / 5 + 32;
            return Math.Round(fahrenheit,2); 
        }
    }
}
