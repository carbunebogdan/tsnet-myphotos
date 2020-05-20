using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPhotosWeb.Models
{
    public class DataFileDTO
    {
        public DataFileDTO()
        {
            this.Deleted = false;
            this.Tags = new HashSet<TagDTO>();
            this.Attributes = new HashSet<AttributeDTO>();
        }

        public int Id { get; set; }

        public string Path { get; set; }

        public Nullable<bool> Deleted { get; set; }

        public string Location { get; set; }

        public System.DateTime CreationDate { get; set; }

        public string Name { get; set; }

        public virtual ICollection<TagDTO> Tags { get; set; }

        public virtual ICollection<AttributeDTO> Attributes { get; set; }
    }
}
