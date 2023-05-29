using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Act13ConvertidorWCF
{
    [ServiceContract]
    public interface IServicioConvertidorClima
    {
        [OperationContract]
        ConvertidorClima convertidorClimaFahrenheit(double centigrados);
        [OperationContract]
        ConvertidorClima convertidorClimaCentigrados(double fahrenheit);
    }
}
