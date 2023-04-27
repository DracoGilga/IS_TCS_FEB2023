using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Act13ConvertidorWCF
{
    [DataContract]
    public class ConvertidorDivisas
    {
        [DataMember]
        public double pesoMexicano { get; set; }
        [DataMember]
        public double pesoEstadounidense { get; set; }
    }
}
