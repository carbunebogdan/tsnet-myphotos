using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPhotosWeb.Models
{
    public class TagDTO
    {
        public TagDTO()
        {
            this.DataFiles = new HashSet<DataFileDTO>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<DataFileDTO> DataFiles { get; set; }
    }
}
