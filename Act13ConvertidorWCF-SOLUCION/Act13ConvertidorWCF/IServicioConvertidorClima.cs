using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Act13ConvertidorWCF
{
    [ServiceContract]
    internal interface IServicioConvertidorClima
    {
        [OperationContract]
        ConvertidorClima convertidorClimaFahrenheit(float centigrados);
        [OperationContract]
        ConvertidorClima convertidorClimaCelntigrados(float fahrenheit);
    }
}
