using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotos.Controller
{
    class AttributeController
    {
        public static void addAttribute(Attribute attribute)
        {
            using (ModelContainer context = new ModelContainer())
            {
                context.Attributes.Add(attribute);
                context.SaveChanges();
            }
        }
        public static void deleteAttribute(int id)
        {
            using (ModelContainer context = new ModelContainer())
            {
                var attributeToDelete = new Attribute { Id = id };
                context.Attributes.Attach(attributeToDelete);
                context.Attributes.Remove(attributeToDelete);
                context.SaveChanges();
            }
        }
        public static void updateTag(int id)
        {
            using (ModelContainer context = new ModelContainer())
            {
                var result = context.Attributes.SingleOrDefault(attribute => attribute.Id == id);
                if (result != null)
                {
                    result.Name = "updatedName";
                    context.SaveChanges();
                }
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
