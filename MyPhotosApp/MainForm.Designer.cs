namespace MyPhotosApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Name = new System.Windows.Forms.TextBox();
            this.Path = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.dataFilesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myPhotosDataSet = new MyPhotosApp.MyPhotosDataSet();
            this.dataFilesTableAdapter = new MyPhotosApp.MyPhotosDataSetTableAdapters.DataFilesTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addAttributeBtn = new System.Windows.Forms.Button();
            this.addTagBtn = new System.Windows.Forms.Button();
            this.selectedItemName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataFilesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPhotosDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(67, 95);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(100, 20);
            this.Name.TabIndex = 0;
            // 
            // Path
            // 
            this.Path.Location = new System.Drawing.Point(67, 121);
            this.Path.Name = "Path";
            this.Path.Size = new System.Drawing.Size(100, 20);
            this.Path.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Path";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.dataFilesBindingSource, "Name", true));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(19, 209);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(373, 275);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // dataFilesBindingSource
            // 
            this.dataFilesBindingSource.DataMember = "DataFiles";
            this.dataFilesBindingSource.DataSource = this.myPhotosDataSet;
            // 
            // myPhotosDataSet
            // 
            this.myPhotosDataSet.DataSetName = "MyPhotosDataSet";
            this.myPhotosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataFilesTableAdapter
            // 
            this.dataFilesTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "My files";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addAttributeBtn);
            this.panel1.Controls.Add(this.addTagBtn);
            this.panel1.Controls.Add(this.selectedItemName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(404, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // addAttributeBtn
            // 
            this.addAttributeBtn.Location = new System.Drawing.Point(92, 74);
            this.addAttributeBtn.Name = "addAttributeBtn";
            this.addAttributeBtn.Size = new System.Drawing.Size(105, 23);
            this.addAttributeBtn.TabIndex = 4;
            this.addAttributeBtn.Text = "Add Attribute";
            this.addAttributeBtn.UseVisualStyleBackColor = true;
            this.addAttributeBtn.Click += new System.EventHandler(this.addAttributeBtn_Click);
            // 
            // addTagBtn
            // 
            this.addTagBtn.Location = new System.Drawing.Point(11, 74);
            this.addTagBtn.Name = "addTagBtn";
            this.addTagBtn.Size = new System.Drawing.Size(75, 23);
            this.addTagBtn.TabIndex = 3;
            this.addTagBtn.Text = "Add tags";
            this.addTagBtn.UseVisualStyleBackColor = true;
            this.addTagBtn.Click += new System.EventHandler(this.addTagBtn_Click);
            // 
            // selectedItemName
            // 
            this.selectedItemName.AutoSize = true;
            this.selectedItemName.Location = new System.Drawing.Point(52, 24);
            this.selectedItemName.Name = "selectedItemName";
            this.selectedItemName.Size = new System.Drawing.Size(96, 13);
            this.selectedItemName.TabIndex = 2;
            this.selectedItemName.Text = "No item is selected";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Name:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Selected File";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 563);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Path);
            this.Controls.Add(this.Name);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataFilesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPhotosDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox Path;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private MyPhotosDataSet myPhotosDataSet;
        private System.Windows.Forms.BindingSource dataFilesBindingSource;
        private MyPhotosDataSetTableAdapters.DataFilesTableAdapter dataFilesTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label selectedItemName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addAttributeBtn;
        private System.Windows.Forms.Button addTagBtn;
    }
}

