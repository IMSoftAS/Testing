using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using ProtoBuf;

namespace IMS.Model
{
    [DataContract]
    [ProtoContract]
    public class ArkivDocument
    {
        [DataMember]
        [ProtoMember( 1 )]
        public int DocumentId { get; set; }
        [DataMember]
        [ProtoMember( 2 )]
        public bool Deleted { get; set; }
        [DataMember]
        [ProtoMember( 3 )]
        public int CreatedById { get; set; }
        [DataMember]
        [ProtoMember( 4 )]
        public int ResponsibleId { get; set; }
        [DataMember]
        [ProtoMember( 5 )]
        public int ProcessedById { get; set; }
        [DataMember]
        [ProtoMember( 6 )]
        public int StatusId { get; set; }
        [DataMember]
        [ProtoMember( 7 )]
        public string Description { get; set; }
        [DataMember]
        [ProtoMember( 8 )]
        public string Note { get; set; }
        [DataMember]
        [ProtoMember( 9 )]
        public string Format { get; set; }
        [DataMember]
        [ProtoMember( 10 )]
        public int TypeId { get; set; }
        [DataMember]
        [ProtoMember( 11 )]
        public int DirectionId { get; set; }
        [DataMember]
        [ProtoMember( 12 )]
        public string Title { get; set; }
        [DataMember]
        [ProtoMember( 13 )]
        public int DocumentFrom { get; set; }
        [DataMember]
        [ProtoMember( 14 )]
        public string PaperDocument { get; set; }
        [DataMember]
        [ProtoMember( 15 )]
        public string PaperDocumentPlacement { get; set; }
        [DataMember]
        [ProtoMember( 16 )]
        public DateTime DateDocumentDated { get; set; }
        [DataMember]
        [ProtoMember( 17 )]
        public DateTime DateSentRecived { get; set; }
        [DataMember]
        [ProtoMember( 18 )]
        public DateTime DateArchived { get; set; }
        [DataMember]
        [ProtoMember( 19 )]
        public DateTime DateCreated { get; set; }
        [DataMember]
        [ProtoMember( 20 )]
        public DateTime DateAnswerDue { get; set; }
        [DataMember]
        [ProtoMember( 21 )]
        public DateTime DateArchiveDue { get; set; }
        [DataMember]
        [ProtoMember( 22 )]
        public int SenderRecipientId { get; set; }
        [DataMember]
        [ProtoMember( 23 )]
        public string SenderRecipientNo { get; set; }
        [DataMember]
        [ProtoMember( 24 )]
        public string SenderRecipientRef { get; set; }
        [DataMember]
        [ProtoMember( 25 )]
        public string CustomerNumber { get; set; }
        [DataMember]
        [ProtoMember( 26 )]
        public bool AutoExpireEnabled { get; set; }
        [DataMember]
        [ProtoMember( 27 )]
        public DateTime AutoExpireDate { get; set; }
        [DataMember]
        [ProtoMember( 28)]
        public string CustomText { get; set; }
        [DataMember]
        [ProtoMember( 29 )]
        public int CustomList { get; set; }
        [DataMember]
        [ProtoMember( 30 )]
        public DateTime CustomDate { get; set; }
        [DataMember]
        [ProtoMember( 31 )]
        public int ArkivId { get; set; }
        [DataMember]
        [ProtoMember( 32 )]
        public int ItemTypeId { get; set; }
        [DataMember]
        [ProtoMember( 33 )]
        public int LockedByUserId { get; set; }
        [DataMember]
        [ProtoMember( 34 )]
        public int ResponsibleType { get; set; }
        [DataMember]
        [ProtoMember( 35 )]
        public int VersionNumber { get; set; }
        [DataMember]
        [ProtoMember( 36 )]
        public int CurrentVersion { get; set; }
        [DataMember]
        [ProtoMember( 37 )]
        public string DocumentInfo { get; set; }
        [DataMember]
        [ProtoMember( 38 )]
        public bool NoExport { get; set; }
        [DataMember]
        [ProtoMember( 39 )]
        public bool AnswerCreated { get; set; }
        [DataMember]
        [ProtoMember( 40 )]
        public string TemplateName { get; set; }
    }
}
