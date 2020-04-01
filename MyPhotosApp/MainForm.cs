using MyPhotos.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPhotosApp
{
    public partial class MainForm : Form
    {
        ListViewItem selectedItem;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadFiles();
        }

        private void loadFiles()
        {
            listView1.Items.Clear();
            var files = FileController.getFiles();
            files.ForEach(file =>
            {
                var tempItem = new ListViewItem();
                tempItem.Text = file.Name;
                tempItem.Tag = file.Id;
                listView1.Items.Add(tempItem);
            });
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                selectedItem = listView1.SelectedItems[0];
                selectedItemName.Text = selectedItem.Text;
                Console.WriteLine(selectedItem.Tag);
            }
            else
            {
                selectedItem = null;
                selectedItemName.Text = "No item is selected";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = Name.Text;
            string path = Path.Text;

            FileController.addFile(name, path, DateTime.Now);
            loadFiles();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void addTagBtn_Click(object sender, EventArgs e)
        {
            if (selectedItem == null)
                return;
            var addTagForm = new addTag();
            addTagForm.Show();
        }

        private void addAttributeBtn_Click(object sender, EventArgs e)
        {
            if (selectedItem == null)
                return;
            var addAttributeForm = new addAttribute((int)selectedItem.Tag);
            addAttributeForm.Show();
        }
    }
}
