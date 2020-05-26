using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyPhotosServiceReference;
using MyPhotosWeb.Models;

namespace MyPhotosWeb
{
    public class RepositoryToDTO
    {
        public DataFileDTO FileToFileDto(DataFile item)
        {
            DataFileDTO file = new DataFileDTO();
            file.Id = item.Id;
            file.Name = item.Name;
            file.Path = item.Path;
            file.CreationDate = item.CreationDate;
            file.Deleted = item.Deleted;
            file.Location = item.Location;
            file.Deleted = item.Deleted;

            List<TagDTO> tags = new List<TagDTO>();
            foreach (var tag in item.Tags)
            {
                tags.Add(TagToTagDto(tag));
            }
            file.Tags = tags;

            List<AttributeDTO> attributes = new List<AttributeDTO>();
            foreach (var attribute in item.Attributes)
            {
                attributes.Add(AttributeToAttributeDto(attribute));
            }
            file.Attributes = attributes;

            return file;
        }

        public TagDTO TagToTagDto(Tag item)
        {
            TagDTO tagDto = new TagDTO();
            tagDto.Id = item.Id;
            tagDto.Name = item.Name;

            return tagDto;
        }
        public AttributeDTO AttributeToAttributeDto(MyPhotosServiceReference.Attribute item)
        {
            AttributeDTO attributeDto = new AttributeDTO();

            attributeDto.Id = item.Id;
            attributeDto.Name = item.Name;
            attributeDto.Value = item.Value;

            return attributeDto;
        }
    }
}
