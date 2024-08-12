namespace Address_Book_WinForms
{
    partial class AddressBookMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddressBookMain));
            toolStrip1 = new ToolStrip();
            Add_toolbtn = new ToolStripButton();
            Edit_toolbtn = new ToolStripButton();
            Delete_toolbtn = new ToolStripButton();
            Save_toolbtn = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripSeparator5 = new ToolStripSeparator();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripSeparator6 = new ToolStripSeparator();
            toolStripSeparator4 = new ToolStripSeparator();
            Search_tooltb = new ToolStripTextBox();
            Search_toolbtn = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            Status_toollbl = new ToolStripStatusLabel();
            StatusBar_toolpbar = new ToolStripProgressBar();
            DisplayContacts_dgv = new DataGridView();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DisplayContacts_dgv).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.Silver;
            toolStrip1.Font = new Font("Arial", 9F);
            toolStrip1.Items.AddRange(new ToolStripItem[] { Add_toolbtn, Edit_toolbtn, Delete_toolbtn, Save_toolbtn, toolStripSeparator2, toolStripSeparator5, toolStripSeparator3, toolStripSeparator6, toolStripSeparator4, Search_tooltb, Search_toolbtn });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(444, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // Add_toolbtn
            // 
            Add_toolbtn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            Add_toolbtn.Image = (Image)resources.GetObject("Add_toolbtn.Image");
            Add_toolbtn.ImageTransparentColor = Color.Magenta;
            Add_toolbtn.Name = "Add_toolbtn";
            Add_toolbtn.Size = new Size(32, 22);
            Add_toolbtn.Text = "Add";
            Add_toolbtn.Click += Add_toolbtn_Click;
            // 
            // Edit_toolbtn
            // 
            Edit_toolbtn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            Edit_toolbtn.Image = (Image)resources.GetObject("Edit_toolbtn.Image");
            Edit_toolbtn.ImageTransparentColor = Color.Magenta;
            Edit_toolbtn.Name = "Edit_toolbtn";
            Edit_toolbtn.Size = new Size(32, 22);
            Edit_toolbtn.Text = "Edit";
            Edit_toolbtn.Click += Edit_toolbtn_Click;
            // 
            // Delete_toolbtn
            // 
            Delete_toolbtn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            Delete_toolbtn.Image = (Image)resources.GetObject("Delete_toolbtn.Image");
            Delete_toolbtn.ImageTransparentColor = Color.Magenta;
            Delete_toolbtn.Name = "Delete_toolbtn";
            Delete_toolbtn.Size = new Size(47, 22);
            Delete_toolbtn.Text = "Delete";
            Delete_toolbtn.Click += Delete_toolbtn_Click;
            // 
            // Save_toolbtn
            // 
            Save_toolbtn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            Save_toolbtn.Image = (Image)resources.GetObject("Save_toolbtn.Image");
            Save_toolbtn.ImageTransparentColor = Color.Magenta;
            Save_toolbtn.Name = "Save_toolbtn";
            Save_toolbtn.Size = new Size(38, 22);
            Save_toolbtn.Text = "Save";
            Save_toolbtn.Click += Save_toolbtn_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.ForeColor = Color.Black;
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 25);
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 25);
            // 
            // Search_tooltb
            // 
            Search_tooltb.BackColor = SystemColors.ControlLight;
            Search_tooltb.BorderStyle = BorderStyle.FixedSingle;
            Search_tooltb.ForeColor = Color.Black;
            Search_tooltb.Margin = new Padding(2, 0, 1, 0);
            Search_tooltb.Name = "Search_tooltb";
            Search_tooltb.Size = new Size(150, 25);
            // 
            // Search_toolbtn
            // 
            Search_toolbtn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            Search_toolbtn.Image = (Image)resources.GetObject("Search_toolbtn.Image");
            Search_toolbtn.ImageTransparentColor = Color.Magenta;
            Search_toolbtn.Name = "Search_toolbtn";
            Search_toolbtn.Size = new Size(50, 22);
            Search_toolbtn.Text = "Search";
            Search_toolbtn.Click += Search_toolbtn_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.Silver;
            statusStrip1.Font = new Font("Arial", 9F);
            statusStrip1.Items.AddRange(new ToolStripItem[] { Status_toollbl, StatusBar_toolpbar });
            statusStrip1.Location = new Point(0, 315);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(444, 23);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // Status_toollbl
            // 
            Status_toollbl.Name = "Status_toollbl";
            Status_toollbl.Size = new Size(81, 18);
            Status_toollbl.Text = "Status: Done!";
            // 
            // StatusBar_toolpbar
            // 
            StatusBar_toolpbar.BackColor = Color.White;
            StatusBar_toolpbar.Margin = new Padding(4);
            StatusBar_toolpbar.Name = "StatusBar_toolpbar";
            StatusBar_toolpbar.Size = new Size(100, 15);
            // 
            // DisplayContacts_dgv
            // 
            DisplayContacts_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DisplayContacts_dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DisplayContacts_dgv.BackgroundColor = Color.WhiteSmoke;
            DisplayContacts_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DisplayContacts_dgv.Dock = DockStyle.Fill;
            DisplayContacts_dgv.Location = new Point(0, 25);
            DisplayContacts_dgv.Name = "DisplayContacts_dgv";
            DisplayContacts_dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DisplayContacts_dgv.Size = new Size(444, 290);
            DisplayContacts_dgv.TabIndex = 2;
            // 
            // AddressBookMain
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(444, 338);
            Controls.Add(DisplayContacts_dgv);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            Name = "AddressBookMain";
            Text = "Address Book";
            Load += AddressBookMain_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DisplayContacts_dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton Search_toolbtn;
        private ToolStripButton Add_toolbtn;
        private ToolStripButton Edit_toolbtn;
        private ToolStripButton Delete_toolbtn;
        private ToolStripButton Save_toolbtn;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripTextBox Search_tooltb;
        private ToolStripSeparator toolStripSeparator6;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel Status_toollbl;
        private ToolStripProgressBar StatusBar_toolpbar;
        private DataGridView DisplayContacts_dgv;
    }
}
