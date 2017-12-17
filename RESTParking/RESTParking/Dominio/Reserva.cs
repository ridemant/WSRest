using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace RESTParking.Dominio
{
    [DataContract]
    public class Reserva
    {
        [DataMember]
        public int id { get; set; }

        [DataMember]
        public int estacionamiento_id { get; set; }

        [DataMember]
        public string fecha { get; set; }

        [DataMember]
        public int estado { get; set; }
    }
}