using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyPhotosServiceReference;
using MyPhotosWeb.Models;

namespace MyPhotosWeb.Pages.Files
{
    public class IndexModel : PageModel
    {
        MyPhotosFacadeClient photosClient = new MyPhotosFacadeClient();
        public List<DataFileDTO> Files { get; set; }


        public SelectList Tags { get; set; }
        [BindProperty(SupportsGet = true)]
        public string FileTags { get; set; }

        public SelectList Attributes { get; set; }
        [BindProperty(SupportsGet = true)]
        public string FileAttributes { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public IndexModel()
        {
            Files = new List<DataFileDTO>();
        }

        public async Task OnGet()
        {
            RepositoryToDTO repositoryToDTO = new RepositoryToDTO();
            IEnumerable<DataFile> files = photosClient.GetDataFilesAsync().Result.ToList().OrderBy(x => x.Name);

            HashSet<string> tags = new HashSet<string>();
            HashSet<string> attributes = new HashSet<string>();

            foreach (var i in files)
            {
                i.Tags.ForEach(tag =>
                {
                    if(!tags.Where(x => x.Contains(tag.Name)).Any())
                    {
                        tags.Add(tag.Name);
                    }
                });
                i.Attributes.ForEach(attr =>
                {
                    if (!attributes.Where(x => x.Contains(attr.Name)).Any())
                    {
                        attributes.Add(attr.Name);
                    }
                });

            }

            Tags = new SelectList(tags);
            Attributes = new SelectList(attributes);

            if (!string.IsNullOrEmpty(SearchString))
            {
                files = files.Where(x => x.Name.Contains(SearchString.ToLower()) ||
                                         (!string.IsNullOrEmpty(x.Path) && x.Path.Contains(SearchString.ToLower())) ||
                                         (!string.IsNullOrEmpty(x.Location) && x.Location.Contains(SearchString.ToLower())));
            }

            if (!string.IsNullOrEmpty(FileTags))
            {
                files = files.Where(x => x.Tags.Where(tag => tag.Name.Contains(FileTags)).Any());
            }

            if (!string.IsNullOrEmpty(FileAttributes))
            {
                files = files.Where(x => x.Attributes.Where(attr => attr.Name.Contains(FileAttributes)).Any());
            }

            foreach (var item in files)
            {
                Files.Add(repositoryToDTO.FileToFileDto(item));
            }
        }
    }
}