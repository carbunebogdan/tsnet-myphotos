using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPhotosWeb.Models
{
    public class AttributeDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }

        public int DataFileId { get; set; }

        public virtual DataFileDTO DataFile { get; set; }
    }
}
