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

        public static void addFile(string name, string path, DateTime creationDate, string location =null)
        {
            using (ModelContainer context = new ModelContainer())
            {
                DataFile file = new DataFile()
                {
                    Name = name,
                    Path = path,
                    CreationDate = creationDate,
                };
                context.DataFiles.Add(file);
                context.SaveChanges();
            }
        }
        public static void deleteFile(int id)
        {
            using (ModelContainer context = new ModelContainer())
            {
                var fileToDelete = new DataFile { Id = id };
                context.DataFiles.Attach(fileToDelete);
                context.DataFiles.Remove(fileToDelete);
                context.SaveChanges();
            }
        }
        public static void updateFile(int id)
        {
            using (ModelContainer context = new ModelContainer())
            {
                var result = context.DataFiles.SingleOrDefault(file => file.Id == id);
                if (result != null)
                {
                   result.Name = "updatedName";
                    context.SaveChanges();
                }
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
          
                return context.DataFiles.ToList();
            }
        }
    }
}
