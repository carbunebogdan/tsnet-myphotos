using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotos.Controller
{
    public class TagController
    {
        public static bool addTag(Tag tag, DataFile file)
        {
            using (ModelContainer context = new ModelContainer())
            {
                Tag exists = context.Tags.Where(tg => tg.Name == tag.Name).FirstOrDefault();
                if (exists == null)
                {
                    exists = context.Tags.Add(tag);
                }
                context.SaveChanges();
                var toAdd = context.Tags.Where(tg => tg.Name == tag.Name).Include(tg=>tg.DataFiles).FirstOrDefault();
                toAdd.DataFiles.Add(file);

               // context.SaveChanges();
                return true;
            }
        }
        public static int deleteTag(int id)
        {
            using (ModelContainer context = new ModelContainer())
            {
                return context.Database.ExecuteSqlCommand("Delete From Tag where Id = @p0", id);
            }
        }
        public static Tag updateTag(Tag newTag)
        {
            using (ModelContainer context = new ModelContainer())
            {
                Tag oldTag = context.Tags.Find(newTag.Id);
                if (oldTag == null)
                {
                    return null;
                }

                oldTag.Name = newTag.Name;
                context.SaveChanges();
                return oldTag;
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
