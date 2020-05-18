namespace Eli.ColoringDiary.App
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.mainTC = new System.Windows.Forms.TabControl();
			this.coloringBooksTP = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.detailBookBtn = new System.Windows.Forms.Button();
			this.deleteBookBtn = new System.Windows.Forms.Button();
			this.editBookBtn = new System.Windows.Forms.Button();
			this.addNewBookBtn = new System.Windows.Forms.Button();
			this.coloringBooksLv = new System.Windows.Forms.ListView();
			this.bookNameCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.bookAuthorCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.bookTotalPagesCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.bookTotalPagesColoredCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.artSuppliesTP = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.addNewSupplyBtn = new System.Windows.Forms.Button();
			this.editSupplyBtn = new System.Windows.Forms.Button();
			this.deleteSupplyBtn = new System.Windows.Forms.Button();
			this.artSuppliesLv = new System.Windows.Forms.ListView();
			this.supplyNameCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.supplyBrandCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.supplyTypeCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.plannerTP = new System.Windows.Forms.TabPage();
			this.wipTP = new System.Windows.Forms.TabPage();
			this.statisticsTP = new System.Windows.Forms.TabPage();
			this.versionLbl = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.mainTC.SuspendLayout();
			this.coloringBooksTP.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.artSuppliesTP.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.InitialImage = null;
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(250, 150);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// mainTC
			// 
			this.mainTC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.mainTC.Controls.Add(this.coloringBooksTP);
			this.mainTC.Controls.Add(this.artSuppliesTP);
			this.mainTC.Controls.Add(this.plannerTP);
			this.mainTC.Controls.Add(this.wipTP);
			this.mainTC.Controls.Add(this.statisticsTP);
			this.mainTC.Location = new System.Drawing.Point(12, 168);
			this.mainTC.Multiline = true;
			this.mainTC.Name = "mainTC";
			this.mainTC.SelectedIndex = 0;
			this.mainTC.Size = new System.Drawing.Size(621, 274);
			this.mainTC.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.mainTC.TabIndex = 2;
			// 
			// coloringBooksTP
			// 
			this.coloringBooksTP.Controls.Add(this.tableLayoutPanel1);
			this.coloringBooksTP.Location = new System.Drawing.Point(4, 22);
			this.coloringBooksTP.Name = "coloringBooksTP";
			this.coloringBooksTP.Padding = new System.Windows.Forms.Padding(3);
			this.coloringBooksTP.Size = new System.Drawing.Size(613, 248);
			this.coloringBooksTP.TabIndex = 0;
			this.coloringBooksTP.Text = "Coloring Books";
			this.coloringBooksTP.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.detailBookBtn, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.deleteBookBtn, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.editBookBtn, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.addNewBookBtn, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.coloringBooksLv, 1, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 6);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 5;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(601, 236);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// detailBookBtn
			// 
			this.detailBookBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.detailBookBtn.Location = new System.Drawing.Point(3, 3);
			this.detailBookBtn.Name = "detailBookBtn";
			this.detailBookBtn.Size = new System.Drawing.Size(84, 19);
			this.detailBookBtn.TabIndex = 3;
			this.detailBookBtn.Text = "Detail";
			this.detailBookBtn.UseVisualStyleBackColor = true;
			// 
			// deleteBookBtn
			// 
			this.deleteBookBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.deleteBookBtn.Location = new System.Drawing.Point(3, 78);
			this.deleteBookBtn.Name = "deleteBookBtn";
			this.deleteBookBtn.Size = new System.Drawing.Size(84, 19);
			this.deleteBookBtn.TabIndex = 2;
			this.deleteBookBtn.Text = "Delete";
			this.deleteBookBtn.UseVisualStyleBackColor = true;
			// 
			// editBookBtn
			// 
			this.editBookBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.editBookBtn.Location = new System.Drawing.Point(3, 53);
			this.editBookBtn.Name = "editBookBtn";
			this.editBookBtn.Size = new System.Drawing.Size(84, 19);
			this.editBookBtn.TabIndex = 1;
			this.editBookBtn.Text = "Edit";
			this.editBookBtn.UseVisualStyleBackColor = true;
			// 
			// addNewBookBtn
			// 
			this.addNewBookBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.addNewBookBtn.Location = new System.Drawing.Point(3, 28);
			this.addNewBookBtn.Name = "addNewBookBtn";
			this.addNewBookBtn.Size = new System.Drawing.Size(84, 19);
			this.addNewBookBtn.TabIndex = 0;
			this.addNewBookBtn.Text = "Add New";
			this.addNewBookBtn.UseVisualStyleBackColor = true;
			// 
			// coloringBooksLv
			// 
			this.coloringBooksLv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.coloringBooksLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.bookNameCh,
            this.bookAuthorCh,
            this.bookTotalPagesCh,
            this.bookTotalPagesColoredCh});
			this.coloringBooksLv.HideSelection = false;
			this.coloringBooksLv.Location = new System.Drawing.Point(93, 3);
			this.coloringBooksLv.Name = "coloringBooksLv";
			this.tableLayoutPanel1.SetRowSpan(this.coloringBooksLv, 5);
			this.coloringBooksLv.Size = new System.Drawing.Size(505, 230);
			this.coloringBooksLv.TabIndex = 4;
			this.coloringBooksLv.UseCompatibleStateImageBehavior = false;
			this.coloringBooksLv.View = System.Windows.Forms.View.Details;
			// 
			// bookNameCh
			// 
			this.bookNameCh.Text = "Name";
			this.bookNameCh.Width = 86;
			// 
			// bookAuthorCh
			// 
			this.bookAuthorCh.Text = "Author";
			this.bookAuthorCh.Width = 100;
			// 
			// bookTotalPagesCh
			// 
			this.bookTotalPagesCh.Text = "Total Pages";
			this.bookTotalPagesCh.Width = 69;
			// 
			// bookTotalPagesColoredCh
			// 
			this.bookTotalPagesColoredCh.Text = "Total Pages Colored";
			this.bookTotalPagesColoredCh.Width = 109;
			// 
			// artSuppliesTP
			// 
			this.artSuppliesTP.Controls.Add(this.tableLayoutPanel2);
			this.artSuppliesTP.Location = new System.Drawing.Point(4, 22);
			this.artSuppliesTP.Name = "artSuppliesTP";
			this.artSuppliesTP.Padding = new System.Windows.Forms.Padding(3);
			this.artSuppliesTP.Size = new System.Drawing.Size(613, 248);
			this.artSuppliesTP.TabIndex = 1;
			this.artSuppliesTP.Text = "Art Supplies";
			this.artSuppliesTP.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Controls.Add(this.addNewSupplyBtn, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.editSupplyBtn, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.deleteSupplyBtn, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.artSuppliesLv, 1, 0);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 6);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 4;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(601, 236);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// addNewSupplyBtn
			// 
			this.addNewSupplyBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.addNewSupplyBtn.Location = new System.Drawing.Point(3, 3);
			this.addNewSupplyBtn.Name = "addNewSupplyBtn";
			this.addNewSupplyBtn.Size = new System.Drawing.Size(84, 19);
			this.addNewSupplyBtn.TabIndex = 1;
			this.addNewSupplyBtn.Text = "Add New";
			this.addNewSupplyBtn.UseVisualStyleBackColor = true;
			// 
			// editSupplyBtn
			// 
			this.editSupplyBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.editSupplyBtn.Location = new System.Drawing.Point(3, 28);
			this.editSupplyBtn.Name = "editSupplyBtn";
			this.editSupplyBtn.Size = new System.Drawing.Size(84, 19);
			this.editSupplyBtn.TabIndex = 2;
			this.editSupplyBtn.Text = "Edit";
			this.editSupplyBtn.UseVisualStyleBackColor = true;
			// 
			// deleteSupplyBtn
			// 
			this.deleteSupplyBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.deleteSupplyBtn.Location = new System.Drawing.Point(3, 53);
			this.deleteSupplyBtn.Name = "deleteSupplyBtn";
			this.deleteSupplyBtn.Size = new System.Drawing.Size(84, 19);
			this.deleteSupplyBtn.TabIndex = 3;
			this.deleteSupplyBtn.Text = "Delete";
			this.deleteSupplyBtn.UseVisualStyleBackColor = true;
			// 
			// artSuppliesLv
			// 
			this.artSuppliesLv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.artSuppliesLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.supplyNameCh,
            this.supplyBrandCh,
            this.supplyTypeCh});
			this.artSuppliesLv.HideSelection = false;
			this.artSuppliesLv.Location = new System.Drawing.Point(93, 3);
			this.artSuppliesLv.Name = "artSuppliesLv";
			this.tableLayoutPanel2.SetRowSpan(this.artSuppliesLv, 4);
			this.artSuppliesLv.Size = new System.Drawing.Size(505, 230);
			this.artSuppliesLv.TabIndex = 4;
			this.artSuppliesLv.UseCompatibleStateImageBehavior = false;
			this.artSuppliesLv.View = System.Windows.Forms.View.Details;
			// 
			// supplyNameCh
			// 
			this.supplyNameCh.Text = "Name";
			this.supplyNameCh.Width = 117;
			// 
			// supplyBrandCh
			// 
			this.supplyBrandCh.Text = "Brand";
			this.supplyBrandCh.Width = 100;
			// 
			// supplyTypeCh
			// 
			this.supplyTypeCh.Text = "Type";
			this.supplyTypeCh.Width = 140;
			// 
			// plannerTP
			// 
			this.plannerTP.Location = new System.Drawing.Point(4, 22);
			this.plannerTP.Name = "plannerTP";
			this.plannerTP.Padding = new System.Windows.Forms.Padding(3);
			this.plannerTP.Size = new System.Drawing.Size(613, 248);
			this.plannerTP.TabIndex = 2;
			this.plannerTP.Text = "Planner";
			this.plannerTP.UseVisualStyleBackColor = true;
			// 
			// wipTP
			// 
			this.wipTP.Location = new System.Drawing.Point(4, 22);
			this.wipTP.Name = "wipTP";
			this.wipTP.Padding = new System.Windows.Forms.Padding(3);
			this.wipTP.Size = new System.Drawing.Size(613, 248);
			this.wipTP.TabIndex = 4;
			this.wipTP.Text = "WIP";
			this.wipTP.UseVisualStyleBackColor = true;
			// 
			// statisticsTP
			// 
			this.statisticsTP.Location = new System.Drawing.Point(4, 22);
			this.statisticsTP.Name = "statisticsTP";
			this.statisticsTP.Padding = new System.Windows.Forms.Padding(3);
			this.statisticsTP.Size = new System.Drawing.Size(613, 248);
			this.statisticsTP.TabIndex = 3;
			this.statisticsTP.Text = "Statistics";
			this.statisticsTP.UseVisualStyleBackColor = true;
			// 
			// versionLbl
			// 
			this.versionLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.versionLbl.AutoSize = true;
			this.versionLbl.Location = new System.Drawing.Point(602, 446);
			this.versionLbl.Name = "versionLbl";
			this.versionLbl.Size = new System.Drawing.Size(28, 13);
			this.versionLbl.TabIndex = 3;
			this.versionLbl.Text = "v0.1";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(645, 469);
			this.Controls.Add(this.versionLbl);
			this.Controls.Add(this.mainTC);
			this.Controls.Add(this.pictureBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(525, 372);
			this.Name = "MainForm";
			this.Text = "Coloring Diary";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.mainTC.ResumeLayout(false);
			this.coloringBooksTP.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.artSuppliesTP.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TabControl mainTC;
		private System.Windows.Forms.TabPage coloringBooksTP;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button detailBookBtn;
		private System.Windows.Forms.Button deleteBookBtn;
		private System.Windows.Forms.Button editBookBtn;
		private System.Windows.Forms.Button addNewBookBtn;
		private System.Windows.Forms.TabPage artSuppliesTP;
		private System.Windows.Forms.TabPage plannerTP;
		private System.Windows.Forms.TabPage wipTP;
		private System.Windows.Forms.TabPage statisticsTP;
		private System.Windows.Forms.ListView coloringBooksLv;
		private System.Windows.Forms.ColumnHeader bookNameCh;
		private System.Windows.Forms.ColumnHeader bookAuthorCh;
		private System.Windows.Forms.ColumnHeader bookTotalPagesCh;
		private System.Windows.Forms.ColumnHeader bookTotalPagesColoredCh;
		private System.Windows.Forms.Label versionLbl;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Button addNewSupplyBtn;
		private System.Windows.Forms.Button editSupplyBtn;
		private System.Windows.Forms.Button deleteSupplyBtn;
		private System.Windows.Forms.ListView artSuppliesLv;
		private System.Windows.Forms.ColumnHeader supplyNameCh;
		private System.Windows.Forms.ColumnHeader supplyBrandCh;
		private System.Windows.Forms.ColumnHeader supplyTypeCh;
	}
}

