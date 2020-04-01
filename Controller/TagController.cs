using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotos.Controller
{
    class TagController
    {
        public static void addTag(int dataFileId, string name)
        {
            using (ModelContainer context = new ModelContainer())
            {
                Tag tag = new Tag()
                {
                    Name = name,
                };
                context.Tags.Add(tag);
                context.SaveChanges();
            }
        }
        public static void deleteTag(int id)
        {
            using (ModelContainer context = new ModelContainer())
            {
                var tagToDelete = new Tag { Id = id };
                context.Tags.Attach(tagToDelete);
                context.Tags.Remove(tagToDelete);
                context.SaveChanges();
            }
        }
        public static void updateTag(int id)
        {
            using (ModelContainer context = new ModelContainer())
            {
                var result = context.Tags.SingleOrDefault(file => file.Id == id);
                if (result != null)
                {
                    result.Name = "updatedName";
                    context.SaveChanges();
                }
            }
        }
        public static Tag getTag(int id)
        {
            using (ModelContainer context = new ModelContainer())
            {
                return context.Tags.Find(id);
            }
        }
        public static List<Tag> getTags()
        {
            using (ModelContainer context = new ModelContainer())
            {

                return context.Tags.ToList();
            }
        }
    }
}
