using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act13ConvertidorWCF
{
    public class ServicioConvertidorClima : IServicioConvertidorClima
    {
        public const double CONVERSION_CLIMA = 32; 

        ConvertidorClima IServicioConvertidorClima.convertidorClimaCentigrados(double fahrenheit)
        {
            ConvertidorClima convertidorClima = new ConvertidorClima();
            convertidorClima.fahrenheit = fahrenheit;
            convertidorClima.centigrados = (fahrenheit - CONVERSION_CLIMA)*(0.55);
            
            return convertidorClima;
        }

        ConvertidorClima IServicioConvertidorClima.convertidorClimaFahrenheit(double centigrados)
        {
            ConvertidorClima convertidorClima = new ConvertidorClima();
            convertidorClima.centigrados = centigrados;
            convertidorClima.fahrenheit = (centigrados * (9/5)) + CONVERSION_CLIMA;

            return convertidorClima;
        }
    }
}
