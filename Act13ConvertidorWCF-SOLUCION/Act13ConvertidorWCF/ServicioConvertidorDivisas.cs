using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Act13ConvertidorWCF
{
    public class ServicioConvertidorDivisas : IServicioConvertidorDivisas
    {
        //1 Dólar estadounidense Es igual a 18.17 Peso mexicano 27 abr, 04:10 UTC
        //referencia: https://www.google.com/finance/quote/USD-MXN?sa=X&ved=2ahUKEwifm_jumMn-AhWqlWoFHQJZAw0QmY0JegQICBAd
        public const double PRECIO_DOLAR = 18.17;


        ConvertidorDivisas IServicioConvertidorDivisas.conversorADolar(double pesoMexicano)
        {
            ConvertidorDivisas convertidorDivisas = new ConvertidorDivisas();
            convertidorDivisas.pesoEstadounidense = pesoMexicano / PRECIO_DOLAR;

            return convertidorDivisas;
        }
        ConvertidorDivisas IServicioConvertidorDivisas.conversorAPesoMXN(double pesoEstadounidense)
        {
            ConvertidorDivisas convertidorDivisas = new ConvertidorDivisas();
            convertidorDivisas.pesoMexicano = pesoEstadounidense * PRECIO_DOLAR;
            return convertidorDivisas;
        }
    }
}
