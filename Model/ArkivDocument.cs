using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Model
{
    [DataContract]
    public class ArkivDocument
    {
        [DataMember]
        public int CreatedById { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string Note { get; set; }
        [DataMember]
        public int TypeId { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public DateTime DateCreated { get; set; }
    }
}
