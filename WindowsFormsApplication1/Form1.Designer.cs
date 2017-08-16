namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.butonSearch = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.butonSalvareXML = new System.Windows.Forms.Button();
            this.butonDB = new System.Windows.Forms.Button();
            this.butonPrint = new System.Windows.Forms.Button();
            this.butonAdaugare = new System.Windows.Forms.Button();
            this.butonEditare = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.ep_Search = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep_Search)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tbSearch);
            this.splitContainer1.Panel1.Controls.Add(this.butonSearch);
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.butonSalvareXML);
            this.splitContainer1.Panel2.Controls.Add(this.butonDB);
            this.splitContainer1.Panel2.Controls.Add(this.butonPrint);
            this.splitContainer1.Panel2.Controls.Add(this.butonAdaugare);
            this.splitContainer1.Panel2.Controls.Add(this.butonEditare);
            this.splitContainer1.Panel2.Controls.Add(this.listView1);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(714, 377);
            this.splitContainer1.SplitterDistance = 238;
            this.splitContainer1.TabIndex = 0;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(92, 338);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(142, 20);
            this.tbSearch.TabIndex = 2;
            // 
            // butonSearch
            // 
            this.butonSearch.Location = new System.Drawing.Point(3, 328);
            this.butonSearch.Name = "butonSearch";
            this.butonSearch.Size = new System.Drawing.Size(83, 38);
            this.butonSearch.TabIndex = 1;
            this.butonSearch.Text = "Search";
            this.butonSearch.UseVisualStyleBackColor = true;
            this.butonSearch.Click += new System.EventHandler(this.butonSearch_Click);
            this.butonSearch.Validating += new System.ComponentModel.CancelEventHandler(this.butonSearch_Validating);
            this.butonSearch.Validated += new System.EventHandler(this.butonSearch_Validated);
            // 
            // treeView1
            // 
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(238, 322);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder.png");
            this.imageList1.Images.SetKeyName(1, "VideoLogo.jpg");
            // 
            // butonSalvareXML
            // 
            this.butonSalvareXML.Location = new System.Drawing.Point(4, 330);
            this.butonSalvareXML.Name = "butonSalvareXML";
            this.butonSalvareXML.Size = new System.Drawing.Size(59, 36);
            this.butonSalvareXML.TabIndex = 5;
            this.butonSalvareXML.Text = "Salvare XML";
            this.butonSalvareXML.UseVisualStyleBackColor = true;
            this.butonSalvareXML.Click += new System.EventHandler(this.butonSalvareXML_Click);
            // 
            // butonDB
            // 
            this.butonDB.Location = new System.Drawing.Point(172, 330);
            this.butonDB.Name = "butonDB";
            this.butonDB.Size = new System.Drawing.Size(101, 36);
            this.butonDB.TabIndex = 4;
            this.butonDB.Text = "Upload Database";
            this.butonDB.UseVisualStyleBackColor = true;
            this.butonDB.Click += new System.EventHandler(this.butonDB_Click);
            // 
            // butonPrint
            // 
            this.butonPrint.Location = new System.Drawing.Point(69, 330);
            this.butonPrint.Name = "butonPrint";
            this.butonPrint.Size = new System.Drawing.Size(97, 36);
            this.butonPrint.TabIndex = 3;
            this.butonPrint.Text = "Print All";
            this.butonPrint.UseVisualStyleBackColor = true;
            this.butonPrint.Click += new System.EventHandler(this.butonPrint_Click);
            // 
            // butonAdaugare
            // 
            this.butonAdaugare.Location = new System.Drawing.Point(380, 329);
            this.butonAdaugare.Name = "butonAdaugare";
            this.butonAdaugare.Size = new System.Drawing.Size(89, 36);
            this.butonAdaugare.TabIndex = 2;
            this.butonAdaugare.Text = "Adaugare";
            this.butonAdaugare.UseVisualStyleBackColor = true;
            this.butonAdaugare.Click += new System.EventHandler(this.butonAdaugare_Click);
            // 
            // butonEditare
            // 
            this.butonEditare.Location = new System.Drawing.Point(279, 330);
            this.butonEditare.Name = "butonEditare";
            this.butonEditare.Size = new System.Drawing.Size(95, 36);
            this.butonEditare.TabIndex = 1;
            this.butonEditare.Text = "Editare";
            this.butonEditare.UseVisualStyleBackColor = true;
            this.butonEditare.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(472, 322);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 108;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Type";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Last Modified";
            this.columnHeader3.Width = 133;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Rating";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Time";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_1);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // ep_Search
            // 
            this.ep_Search.ContainerControl = this;
            this.ep_Search.Icon = ((System.Drawing.Icon)(resources.GetObject("ep_Search.Icon")));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 377);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ep_Search)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button butonAdaugare;
        private System.Windows.Forms.Button butonEditare;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button butonSearch;
        private System.Windows.Forms.Button butonPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ErrorProvider ep_Search;
        private System.Windows.Forms.Button butonDB;
        private System.Windows.Forms.Button butonSalvareXML;
    }
}

