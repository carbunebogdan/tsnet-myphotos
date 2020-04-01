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
    public partial class addAttribute : Form
    {
        private int dataFileId;
        public addAttribute(int dataFileId)
        {
            this.dataFileId = dataFileId;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(dataFileId);
            Console.WriteLine(nameField.Text);
            Console.WriteLine(valueField.Text);
        }
    }
}
