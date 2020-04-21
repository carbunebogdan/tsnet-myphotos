using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotos.Controller
{
    public class AttributeController
    {
        public static bool addAttribute(Attribute attribute)
        {
            using (ModelContainer context = new ModelContainer())
            {
                context.Attributes.Add(attribute);
                context.SaveChanges();
                return true;
            }
        }
        public static int deleteAttribute(int id)
        {
            using (ModelContainer context = new ModelContainer())
            {
                return context.Database.ExecuteSqlCommand("Delete From Attribute where Id = @p0", id);
            }
        }
        public static Attribute updateAttribute(Attribute newAttr)
        {
            using (ModelContainer context = new ModelContainer())
            {
                Attribute oldAttr = context.Attributes.Find(newAttr.Id);
                if (oldAttr == null)
                {
                    return null;
                }

                oldAttr.Name = newAttr.Name;
                oldAttr.Value = newAttr.Value;
                context.SaveChanges();
                return oldAttr;
            }
        }
        public static Attribute getAttribute(int id)
        {
            using (ModelContainer context = new ModelContainer())
            {
                return context.Attributes.Find(id);
            }
        }
        public static List<Attribute> getAttributes()
        {
            using (ModelContainer context = new ModelContainer())
            {

                return context.Attributes.ToList();
            }
        }
    }
}
