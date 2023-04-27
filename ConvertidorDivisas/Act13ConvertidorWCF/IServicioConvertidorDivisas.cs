using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Act13ConvertidorWCF
{
    [ServiceContract]
    public interface IServicioConvertidorDivisas
    {
        [OperationContract]
        ConvertidorDivisas conversorADolar(double pesoMexicano);

        [OperationContract]
        ConvertidorDivisas conversorAPesoMXN(double pesoEstadounidense);
    }
}
