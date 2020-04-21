using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyPhotos;

namespace MyPhotosApp
{
    public partial class addTag : Form
    {
        DataFile file;

        MyPhotosFacadeClient myPhotosClient = new MyPhotosFacadeClient();
        public addTag(DataFile file)
        {
            this.file = file;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = TagName.Text;
            myPhotosClient.AddTag(new Tag()
            {
                Name = name,
            }, file);
        }
    }
}
