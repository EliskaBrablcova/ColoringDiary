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
			this.coloringBooksTlp = new System.Windows.Forms.TableLayoutPanel();
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
			this.artSuppliesTlp = new System.Windows.Forms.TableLayoutPanel();
			this.addNewSupplyBtn = new System.Windows.Forms.Button();
			this.editSupplyBtn = new System.Windows.Forms.Button();
			this.deleteSupplyBtn = new System.Windows.Forms.Button();
			this.artSuppliesLv = new System.Windows.Forms.ListView();
			this.supplyNameCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.supplyBrandCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.supplyTypeCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.plannerTP = new System.Windows.Forms.TabPage();
			this.wipTP = new System.Windows.Forms.TabPage();
			this.WIPTlp = new System.Windows.Forms.TableLayoutPanel();
			this.editWIPBtn = new System.Windows.Forms.Button();
			this.finishWIPBtn = new System.Windows.Forms.Button();
			this.WIPLv = new System.Windows.Forms.ListView();
			this.WIPBookNameCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.WIPAuthorCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.WIPPageNumberCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.WIPPageDescriptionCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.WITStartDateCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.WIPNoteCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.statisticsTP = new System.Windows.Forms.TabPage();
			this.versionLbl = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.mainTC.SuspendLayout();
			this.coloringBooksTP.SuspendLayout();
			this.coloringBooksTlp.SuspendLayout();
			this.artSuppliesTP.SuspendLayout();
			this.artSuppliesTlp.SuspendLayout();
			this.wipTP.SuspendLayout();
			this.WIPTlp.SuspendLayout();
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
			this.coloringBooksTP.Controls.Add(this.coloringBooksTlp);
			this.coloringBooksTP.Location = new System.Drawing.Point(4, 22);
			this.coloringBooksTP.Name = "coloringBooksTP";
			this.coloringBooksTP.Padding = new System.Windows.Forms.Padding(3);
			this.coloringBooksTP.Size = new System.Drawing.Size(613, 248);
			this.coloringBooksTP.TabIndex = 0;
			this.coloringBooksTP.Text = "Coloring Books";
			this.coloringBooksTP.UseVisualStyleBackColor = true;
			// 
			// coloringBooksTlp
			// 
			this.coloringBooksTlp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.coloringBooksTlp.ColumnCount = 2;
			this.coloringBooksTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.coloringBooksTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.coloringBooksTlp.Controls.Add(this.detailBookBtn, 0, 0);
			this.coloringBooksTlp.Controls.Add(this.deleteBookBtn, 0, 3);
			this.coloringBooksTlp.Controls.Add(this.editBookBtn, 0, 2);
			this.coloringBooksTlp.Controls.Add(this.addNewBookBtn, 0, 1);
			this.coloringBooksTlp.Controls.Add(this.coloringBooksLv, 1, 0);
			this.coloringBooksTlp.Location = new System.Drawing.Point(6, 6);
			this.coloringBooksTlp.Name = "coloringBooksTlp";
			this.coloringBooksTlp.RowCount = 5;
			this.coloringBooksTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.coloringBooksTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.coloringBooksTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.coloringBooksTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.coloringBooksTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.coloringBooksTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.coloringBooksTlp.Size = new System.Drawing.Size(601, 236);
			this.coloringBooksTlp.TabIndex = 0;
			// 
			// detailBookBtn
			// 
			this.detailBookBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.detailBookBtn.Enabled = false;
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
			this.deleteBookBtn.Enabled = false;
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
			this.editBookBtn.Enabled = false;
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
			this.coloringBooksLv.FullRowSelect = true;
			this.coloringBooksLv.HideSelection = false;
			this.coloringBooksLv.Location = new System.Drawing.Point(93, 3);
			this.coloringBooksLv.MultiSelect = false;
			this.coloringBooksLv.Name = "coloringBooksLv";
			this.coloringBooksTlp.SetRowSpan(this.coloringBooksLv, 5);
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
			this.artSuppliesTP.Controls.Add(this.artSuppliesTlp);
			this.artSuppliesTP.Location = new System.Drawing.Point(4, 22);
			this.artSuppliesTP.Name = "artSuppliesTP";
			this.artSuppliesTP.Padding = new System.Windows.Forms.Padding(3);
			this.artSuppliesTP.Size = new System.Drawing.Size(613, 248);
			this.artSuppliesTP.TabIndex = 1;
			this.artSuppliesTP.Text = "Art Supplies";
			this.artSuppliesTP.UseVisualStyleBackColor = true;
			// 
			// artSuppliesTlp
			// 
			this.artSuppliesTlp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.artSuppliesTlp.ColumnCount = 2;
			this.artSuppliesTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.artSuppliesTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.artSuppliesTlp.Controls.Add(this.addNewSupplyBtn, 0, 0);
			this.artSuppliesTlp.Controls.Add(this.editSupplyBtn, 0, 1);
			this.artSuppliesTlp.Controls.Add(this.deleteSupplyBtn, 0, 2);
			this.artSuppliesTlp.Controls.Add(this.artSuppliesLv, 1, 0);
			this.artSuppliesTlp.Location = new System.Drawing.Point(6, 6);
			this.artSuppliesTlp.Name = "artSuppliesTlp";
			this.artSuppliesTlp.RowCount = 4;
			this.artSuppliesTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.artSuppliesTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.artSuppliesTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.artSuppliesTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.artSuppliesTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.artSuppliesTlp.Size = new System.Drawing.Size(601, 236);
			this.artSuppliesTlp.TabIndex = 0;
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
			this.addNewSupplyBtn.Click += new System.EventHandler(this.addNewSupplyBtn_Click);
			// 
			// editSupplyBtn
			// 
			this.editSupplyBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.editSupplyBtn.Enabled = false;
			this.editSupplyBtn.Location = new System.Drawing.Point(3, 28);
			this.editSupplyBtn.Name = "editSupplyBtn";
			this.editSupplyBtn.Size = new System.Drawing.Size(84, 19);
			this.editSupplyBtn.TabIndex = 2;
			this.editSupplyBtn.Text = "Edit";
			this.editSupplyBtn.UseVisualStyleBackColor = true;
			this.editSupplyBtn.Click += new System.EventHandler(this.editSupplyBtn_Click);
			// 
			// deleteSupplyBtn
			// 
			this.deleteSupplyBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.deleteSupplyBtn.Enabled = false;
			this.deleteSupplyBtn.Location = new System.Drawing.Point(3, 53);
			this.deleteSupplyBtn.Name = "deleteSupplyBtn";
			this.deleteSupplyBtn.Size = new System.Drawing.Size(84, 19);
			this.deleteSupplyBtn.TabIndex = 3;
			this.deleteSupplyBtn.Text = "Delete";
			this.deleteSupplyBtn.UseVisualStyleBackColor = true;
			this.deleteSupplyBtn.Click += new System.EventHandler(this.deleteSupplyBtn_Click);
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
			this.artSuppliesLv.FullRowSelect = true;
			this.artSuppliesLv.HideSelection = false;
			this.artSuppliesLv.Location = new System.Drawing.Point(93, 3);
			this.artSuppliesLv.MultiSelect = false;
			this.artSuppliesLv.Name = "artSuppliesLv";
			this.artSuppliesTlp.SetRowSpan(this.artSuppliesLv, 4);
			this.artSuppliesLv.Size = new System.Drawing.Size(505, 230);
			this.artSuppliesLv.TabIndex = 4;
			this.artSuppliesLv.UseCompatibleStateImageBehavior = false;
			this.artSuppliesLv.View = System.Windows.Forms.View.Details;
			this.artSuppliesLv.SelectedIndexChanged += new System.EventHandler(this.artSuppliesLv_SelectedIndexChanged);
			this.artSuppliesLv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.artSuppliesLv_KeyDown);
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
			this.wipTP.Controls.Add(this.WIPTlp);
			this.wipTP.Location = new System.Drawing.Point(4, 22);
			this.wipTP.Name = "wipTP";
			this.wipTP.Padding = new System.Windows.Forms.Padding(3);
			this.wipTP.Size = new System.Drawing.Size(613, 248);
			this.wipTP.TabIndex = 4;
			this.wipTP.Text = "WIP";
			this.wipTP.UseVisualStyleBackColor = true;
			// 
			// WIPTlp
			// 
			this.WIPTlp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.WIPTlp.ColumnCount = 2;
			this.WIPTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.WIPTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.WIPTlp.Controls.Add(this.editWIPBtn, 0, 0);
			this.WIPTlp.Controls.Add(this.finishWIPBtn, 0, 1);
			this.WIPTlp.Controls.Add(this.WIPLv, 1, 0);
			this.WIPTlp.Location = new System.Drawing.Point(6, 6);
			this.WIPTlp.Name = "WIPTlp";
			this.WIPTlp.RowCount = 4;
			this.WIPTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.WIPTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.WIPTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.WIPTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.WIPTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.WIPTlp.Size = new System.Drawing.Size(601, 236);
			this.WIPTlp.TabIndex = 1;
			// 
			// editWIPBtn
			// 
			this.editWIPBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.editWIPBtn.Enabled = false;
			this.editWIPBtn.Location = new System.Drawing.Point(3, 3);
			this.editWIPBtn.Name = "editWIPBtn";
			this.editWIPBtn.Size = new System.Drawing.Size(84, 19);
			this.editWIPBtn.TabIndex = 2;
			this.editWIPBtn.Text = "Edit";
			this.editWIPBtn.UseVisualStyleBackColor = true;
			// 
			// finishWIPBtn
			// 
			this.finishWIPBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.finishWIPBtn.Enabled = false;
			this.finishWIPBtn.Location = new System.Drawing.Point(3, 28);
			this.finishWIPBtn.Name = "finishWIPBtn";
			this.finishWIPBtn.Size = new System.Drawing.Size(84, 19);
			this.finishWIPBtn.TabIndex = 3;
			this.finishWIPBtn.Text = "Finish";
			this.finishWIPBtn.UseVisualStyleBackColor = true;
			// 
			// WIPLv
			// 
			this.WIPLv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.WIPLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.WIPBookNameCh,
            this.WIPAuthorCh,
            this.WIPPageNumberCh,
            this.WIPPageDescriptionCh,
            this.WITStartDateCh,
            this.WIPNoteCh});
			this.WIPLv.FullRowSelect = true;
			this.WIPLv.HideSelection = false;
			this.WIPLv.Location = new System.Drawing.Point(93, 3);
			this.WIPLv.MultiSelect = false;
			this.WIPLv.Name = "WIPLv";
			this.WIPTlp.SetRowSpan(this.WIPLv, 4);
			this.WIPLv.Size = new System.Drawing.Size(505, 230);
			this.WIPLv.TabIndex = 4;
			this.WIPLv.UseCompatibleStateImageBehavior = false;
			this.WIPLv.View = System.Windows.Forms.View.Details;
			// 
			// WIPBookNameCh
			// 
			this.WIPBookNameCh.Text = "Book Name";
			this.WIPBookNameCh.Width = 81;
			// 
			// WIPAuthorCh
			// 
			this.WIPAuthorCh.Text = "Author";
			// 
			// WIPPageNumberCh
			// 
			this.WIPPageNumberCh.Text = "Page Number";
			this.WIPPageNumberCh.Width = 82;
			// 
			// WIPPageDescriptionCh
			// 
			this.WIPPageDescriptionCh.Text = "Page Description";
			// 
			// WITStartDateCh
			// 
			this.WITStartDateCh.Text = "Start Date";
			// 
			// WIPNoteCh
			// 
			this.WIPNoteCh.Text = "Note";
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
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.mainTC.ResumeLayout(false);
			this.coloringBooksTP.ResumeLayout(false);
			this.coloringBooksTlp.ResumeLayout(false);
			this.artSuppliesTP.ResumeLayout(false);
			this.artSuppliesTlp.ResumeLayout(false);
			this.wipTP.ResumeLayout(false);
			this.WIPTlp.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TabControl mainTC;
		private System.Windows.Forms.TabPage coloringBooksTP;
		private System.Windows.Forms.TableLayoutPanel coloringBooksTlp;
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
		private System.Windows.Forms.TableLayoutPanel artSuppliesTlp;
		private System.Windows.Forms.Button addNewSupplyBtn;
		private System.Windows.Forms.Button editSupplyBtn;
		private System.Windows.Forms.Button deleteSupplyBtn;
		private System.Windows.Forms.ListView artSuppliesLv;
		private System.Windows.Forms.ColumnHeader supplyNameCh;
		private System.Windows.Forms.ColumnHeader supplyBrandCh;
		private System.Windows.Forms.ColumnHeader supplyTypeCh;
		private System.Windows.Forms.TableLayoutPanel WIPTlp;
		private System.Windows.Forms.Button editWIPBtn;
		private System.Windows.Forms.Button finishWIPBtn;
		private System.Windows.Forms.ListView WIPLv;
		private System.Windows.Forms.ColumnHeader WIPBookNameCh;
		private System.Windows.Forms.ColumnHeader WIPAuthorCh;
		private System.Windows.Forms.ColumnHeader WIPPageNumberCh;
		private System.Windows.Forms.ColumnHeader WIPPageDescriptionCh;
		private System.Windows.Forms.ColumnHeader WITStartDateCh;
		private System.Windows.Forms.ColumnHeader WIPNoteCh;
	}
}

