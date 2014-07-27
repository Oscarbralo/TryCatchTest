using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchDTOs
{
    [DataContract]
    public class PersonDTO
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Phone { get; set; }

        [DataMember]
        public string Residence { get; set; }
    }
}
