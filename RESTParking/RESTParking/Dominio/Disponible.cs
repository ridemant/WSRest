using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace RESTParking.Dominio
{
    [DataContract]
    public class Disponible
    {
        [DataMember]
        public int total { get; set; }

        [DataMember]
        public List<int> disponibles { get; set; }
    }
}