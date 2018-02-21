using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_Celcius
{
    //This Function convert value of celsius to Farenheit
    class Converter
    {
        public string value(string celsius)
        {
            double farenheit = 0;
            farenheit = Convert.ToDouble(celsius) * 1.8 + 32;
            return (Convert.ToString(farenheit));
        }
    }

    //This Function convert value of Farenheit to celsius
    class confar
    {
        public string value2(string farenheit)
        {
            double celsius = 0;
            celsius = (Convert.ToDouble(farenheit)-32) / 1.8;
            return (Convert.ToString(celsius));
        }    
    }
}
