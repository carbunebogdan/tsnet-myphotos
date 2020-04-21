using System.Runtime.Serialization;

namespace ObjectWCF.DTO
{
    [DataContract]
    public sealed class Attribute
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Value { get; set; }
    }
}
