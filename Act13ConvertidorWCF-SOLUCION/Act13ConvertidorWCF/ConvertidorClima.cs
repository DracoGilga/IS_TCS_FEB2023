using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Act13ConvertidorWCF
{
    [DataContract]
    public class ConvertidorClima
    {
        [DataMember]
        public float centigrados { get; set; }
        [DataMember]
        public float fahrenheit { get; set; }
    }
}
