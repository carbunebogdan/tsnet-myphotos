using MyPhotos;
using MyPhotos.Controller;
using System;
using System.Collections.Generic;

namespace ObjectWCF
{
    public class MainService : IMyPhotosFacade
    {
        //DATAFILE START
        public bool AddDataFile(DataFile file)
        {
            return FileController.addFile(file);
        }

        public int DeleteDataFile(int id)
        {
            return FileController.deleteFile(id);
        }

        public DataFile GetDataFileById(int id)
        {
            return FileController.getFile(id);
        }

        public List<DataFile> GetDataFiles()
        {
            return FileController.getFiles();
        }

        public DataFile UpdateDataFile(DataFile file)
        {
            return FileController.updateFile(file);
        }
        //DATAFILE END


        //ATTRIBUTE START
        public bool AddAttribute(MyPhotos.Attribute attribute)
        {
            return AttributeController.addAttribute(attribute);
        }

        public int DeleteAttribute(int id)
        {
            return AttributeController.deleteAttribute(id);
        }

        public MyPhotos.Attribute GetAttributeById(int id)
        {
            return AttributeController.getAttribute(id);
        }

        public List<MyPhotos.Attribute> GetAttributes()
        {
            return AttributeController.getAttributes();
        }

        public MyPhotos.Attribute UpdateAttribute(MyPhotos.Attribute attribute)
        {
            return AttributeController.updateAttribute(attribute);
        }
        //ATTRIBUTE END

        //TAG START
        public bool AddTag(Tag tag, DataFile file)
        {
            return TagController.addTag(tag, file);
        }

        public Tag GetTagById(int id)
        {
            return TagController.getTag(id);
        }

        public List<Tag> GetTags()
        {
            return TagController.getTags();
        }

        public Tag UpdateTag(Tag tag)
        {
            return TagController.updateTag(tag);
        }

        public int DeleteTag(int id)
        {
            return TagController.deleteTag(id);
        }
        //TAG END
    }
}
