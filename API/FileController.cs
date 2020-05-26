using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.SqlServer;

namespace MyPhotos.Controller
{

    internal static class MissingDllHack
    {
        // Must reference a type in EntityFramework.SqlServer.dll so that this dll will be
        // included in the output folder of referencing projects without requiring a direct 
        // dependency on Entity Framework. See http://stackoverflow.com/a/22315164/1141360.
        private static SqlProviderServices instance = SqlProviderServices.Instance;
    }
    public class FileController
    {

        public static bool addFile(DataFile file)
        {
            using (ModelContainer context = new ModelContainer())
            {
                context.DataFiles.Add(file);
                context.SaveChanges();
                return true;
            }
        }
        public static int deleteFile(int id)
        {
            using (ModelContainer context = new ModelContainer())
            {
                return context.Database.ExecuteSqlCommand("Delete From DataFile where Id = @p0", id);
            }
        }
        public static DataFile updateFile(DataFile newFile)
        {
            using (ModelContainer context = new ModelContainer())
            {
                DataFile oldFile = context.DataFiles.Find(newFile.Id);
                if (oldFile == null)
                {
                    return null;
                }

                oldFile.Path = newFile.Path;
                oldFile.Deleted = newFile.Deleted;
                oldFile.Location = newFile.Location;
                oldFile.Name = newFile.Name;
                context.SaveChanges();
                return oldFile;
            }
        }
        public static DataFile getFile(int id)
        {
            using (ModelContainer context = new ModelContainer())
            {
                return context.DataFiles.Find(id);
            }
        }
        public static List<DataFile> getFiles()
        {
            using (ModelContainer context = new ModelContainer())
            {
          
                return context.DataFiles.Include("Tags").Include("Attributes").ToList();
            }
        }
    }
}
