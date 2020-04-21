using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ObjectWCF.DTO
{

    [DataContract]
    public sealed class DataFile
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Path { get; set; }

        [DataMember]
        public Nullable<bool> Deleted { get; set; }

        [DataMember]
        public string Location { get; set; }

        [DataMember]
        public System.DateTime CreationDate { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public ICollection<FileTag> Tags { get; set; }

        [DataMember]
        public ICollection<FileAttribute> Attributes { get; set; }
    }

    [DataContract]
    public sealed class FileAttribute
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Value { get; set; }
    }

    [DataContract]
    public sealed class FileTag
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }
    }
}
