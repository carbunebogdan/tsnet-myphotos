using MyPhotos;
using MyPhotos.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectWCF
{
    public class MainService : InterfaceDataFile, InterfaceTag, InterfaceAttribute
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
            throw new NotImplementedException();
        }

        public int DeleteAttribute(int id)
        {
            throw new NotImplementedException();
        }

        public MyPhotos.Attribute GetAttributeById(int id)
        {
            throw new NotImplementedException();
        }

        public List<MyPhotos.Attribute> GetAttributes()
        {
            throw new NotImplementedException();
        }

        public DataFile UpdateAttribute(MyPhotos.Attribute attribute)
        {
            throw new NotImplementedException();
        }
        //ATTRIBUTE END

        //TAG START
        public bool AddTag(Tag tag)
        {
            throw new NotImplementedException();
        }

        public Tag GetTagById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Tag> GetTags()
        {
            throw new NotImplementedException();
        }

        public Tag UpdateTag(Tag tag)
        {
            throw new NotImplementedException();
        }

        public int DeleteTag(int id)
        {
            throw new NotImplementedException();
        }
        //TAG END
    }
}
