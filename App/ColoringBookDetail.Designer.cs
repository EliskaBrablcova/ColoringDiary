﻿namespace Eli.ColoringDiary.App
{
	partial class ColoringBookDetail
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColoringBookDetail));
			this.coloringBookDetailTlp = new System.Windows.Forms.TableLayoutPanel();
			this.coloringBookDetailDeletePageBtn = new System.Windows.Forms.Button();
			this.coloringBookDetailEditPageBtn = new System.Windows.Forms.Button();
			this.coloringBookDetailBookAuthorLbl = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.coloringBookDetailBookNameLbl = new System.Windows.Forms.Label();
			this.coloringBookDetailLv = new System.Windows.Forms.ListView();
			this.coloringBookDetailPageNumberCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.coloringBookDetailPageDescriptionCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.coloringBookDetailStartDateCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.coloringBookDetailFinishDateCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.coloringBookDetailArtSuppliesUsedCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.coloringBookDetailNoteCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.coloringBookDetailAddNewPageBtn = new System.Windows.Forms.Button();
			this.coloringBookDetailTlp.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// coloringBookDetailTlp
			// 
			this.coloringBookDetailTlp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.coloringBookDetailTlp.ColumnCount = 3;
			this.coloringBookDetailTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.coloringBookDetailTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 280F));
			this.coloringBookDetailTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.coloringBookDetailTlp.Controls.Add(this.coloringBookDetailDeletePageBtn, 0, 4);
			this.coloringBookDetailTlp.Controls.Add(this.coloringBookDetailEditPageBtn, 0, 3);
			this.coloringBookDetailTlp.Controls.Add(this.coloringBookDetailBookAuthorLbl, 2, 1);
			this.coloringBookDetailTlp.Controls.Add(this.pictureBox1, 0, 0);
			this.coloringBookDetailTlp.Controls.Add(this.coloringBookDetailBookNameLbl, 2, 0);
			this.coloringBookDetailTlp.Controls.Add(this.coloringBookDetailLv, 1, 2);
			this.coloringBookDetailTlp.Controls.Add(this.coloringBookDetailAddNewPageBtn, 0, 2);
			this.coloringBookDetailTlp.Location = new System.Drawing.Point(12, 12);
			this.coloringBookDetailTlp.Name = "coloringBookDetailTlp";
			this.coloringBookDetailTlp.RowCount = 6;
			this.coloringBookDetailTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.coloringBookDetailTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.coloringBookDetailTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.coloringBookDetailTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.coloringBookDetailTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.coloringBookDetailTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.coloringBookDetailTlp.Size = new System.Drawing.Size(630, 293);
			this.coloringBookDetailTlp.TabIndex = 0;
			// 
			// coloringBookDetailDeletePageBtn
			// 
			this.coloringBookDetailDeletePageBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.coloringBookDetailDeletePageBtn.Location = new System.Drawing.Point(3, 153);
			this.coloringBookDetailDeletePageBtn.Name = "coloringBookDetailDeletePageBtn";
			this.coloringBookDetailDeletePageBtn.Size = new System.Drawing.Size(84, 19);
			this.coloringBookDetailDeletePageBtn.TabIndex = 7;
			this.coloringBookDetailDeletePageBtn.Text = "Delete Page";
			this.coloringBookDetailDeletePageBtn.UseVisualStyleBackColor = true;
			this.coloringBookDetailDeletePageBtn.Click += new System.EventHandler(this.coloringBookDetailDeletePageBtn_Click);
			// 
			// coloringBookDetailEditPageBtn
			// 
			this.coloringBookDetailEditPageBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.coloringBookDetailEditPageBtn.Location = new System.Drawing.Point(3, 128);
			this.coloringBookDetailEditPageBtn.Name = "coloringBookDetailEditPageBtn";
			this.coloringBookDetailEditPageBtn.Size = new System.Drawing.Size(84, 19);
			this.coloringBookDetailEditPageBtn.TabIndex = 6;
			this.coloringBookDetailEditPageBtn.Text = "Edit Page";
			this.coloringBookDetailEditPageBtn.UseVisualStyleBackColor = true;
			this.coloringBookDetailEditPageBtn.Click += new System.EventHandler(this.coloringBookDetailEditPageBtn_Click);
			// 
			// coloringBookDetailBookAuthorLbl
			// 
			this.coloringBookDetailBookAuthorLbl.AutoSize = true;
			this.coloringBookDetailBookAuthorLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.coloringBookDetailBookAuthorLbl.Font = new System.Drawing.Font("Rage Italic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.coloringBookDetailBookAuthorLbl.Location = new System.Drawing.Point(373, 50);
			this.coloringBookDetailBookAuthorLbl.Name = "coloringBookDetailBookAuthorLbl";
			this.coloringBookDetailBookAuthorLbl.Size = new System.Drawing.Size(254, 50);
			this.coloringBookDetailBookAuthorLbl.TabIndex = 3;
			this.coloringBookDetailBookAuthorLbl.Text = "bookAuthor";
			this.coloringBookDetailBookAuthorLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox1
			// 
			this.coloringBookDetailTlp.SetColumnSpan(this.pictureBox1, 2);
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(3, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.coloringBookDetailTlp.SetRowSpan(this.pictureBox1, 2);
			this.pictureBox1.Size = new System.Drawing.Size(364, 94);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// coloringBookDetailBookNameLbl
			// 
			this.coloringBookDetailBookNameLbl.AutoSize = true;
			this.coloringBookDetailBookNameLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.coloringBookDetailBookNameLbl.Font = new System.Drawing.Font("Rage Italic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.coloringBookDetailBookNameLbl.Location = new System.Drawing.Point(373, 0);
			this.coloringBookDetailBookNameLbl.Name = "coloringBookDetailBookNameLbl";
			this.coloringBookDetailBookNameLbl.Size = new System.Drawing.Size(254, 50);
			this.coloringBookDetailBookNameLbl.TabIndex = 1;
			this.coloringBookDetailBookNameLbl.Text = "bookName";
			this.coloringBookDetailBookNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// coloringBookDetailLv
			// 
			this.coloringBookDetailLv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.coloringBookDetailLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.coloringBookDetailPageNumberCh,
            this.coloringBookDetailPageDescriptionCh,
            this.coloringBookDetailNoteCh,
            this.coloringBookDetailStartDateCh,
            this.coloringBookDetailFinishDateCh,
            this.coloringBookDetailArtSuppliesUsedCh});
			this.coloringBookDetailTlp.SetColumnSpan(this.coloringBookDetailLv, 2);
			this.coloringBookDetailLv.FullRowSelect = true;
			this.coloringBookDetailLv.HideSelection = false;
			this.coloringBookDetailLv.Location = new System.Drawing.Point(93, 103);
			this.coloringBookDetailLv.MultiSelect = false;
			this.coloringBookDetailLv.Name = "coloringBookDetailLv";
			this.coloringBookDetailTlp.SetRowSpan(this.coloringBookDetailLv, 4);
			this.coloringBookDetailLv.Size = new System.Drawing.Size(534, 187);
			this.coloringBookDetailLv.TabIndex = 4;
			this.coloringBookDetailLv.UseCompatibleStateImageBehavior = false;
			this.coloringBookDetailLv.View = System.Windows.Forms.View.Details;
			this.coloringBookDetailLv.SelectedIndexChanged += new System.EventHandler(this.coloringBookDetailLv_SelectedIndexChanged);
			this.coloringBookDetailLv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.coloringBookDetailLv_KeyDown);
			// 
			// coloringBookDetailPageNumberCh
			// 
			this.coloringBookDetailPageNumberCh.Text = "Page Number";
			this.coloringBookDetailPageNumberCh.Width = 77;
			// 
			// coloringBookDetailPageDescriptionCh
			// 
			this.coloringBookDetailPageDescriptionCh.Text = "Page Description";
			this.coloringBookDetailPageDescriptionCh.Width = 93;
			// 
			// coloringBookDetailStartDateCh
			// 
			this.coloringBookDetailStartDateCh.DisplayIndex = 3;
			this.coloringBookDetailStartDateCh.Text = "Start Date";
			this.coloringBookDetailStartDateCh.Width = 72;
			// 
			// coloringBookDetailFinishDateCh
			// 
			this.coloringBookDetailFinishDateCh.DisplayIndex = 4;
			this.coloringBookDetailFinishDateCh.Text = "Finish Date";
			this.coloringBookDetailFinishDateCh.Width = 72;
			// 
			// coloringBookDetailArtSuppliesUsedCh
			// 
			this.coloringBookDetailArtSuppliesUsedCh.DisplayIndex = 5;
			this.coloringBookDetailArtSuppliesUsedCh.Text = "Art Supplies Used";
			this.coloringBookDetailArtSuppliesUsedCh.Width = 107;
			// 
			// coloringBookDetailNoteCh
			// 
			this.coloringBookDetailNoteCh.DisplayIndex = 2;
			this.coloringBookDetailNoteCh.Text = "Note";
			// 
			// coloringBookDetailAddNewPageBtn
			// 
			this.coloringBookDetailAddNewPageBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.coloringBookDetailAddNewPageBtn.Location = new System.Drawing.Point(3, 103);
			this.coloringBookDetailAddNewPageBtn.Name = "coloringBookDetailAddNewPageBtn";
			this.coloringBookDetailAddNewPageBtn.Size = new System.Drawing.Size(84, 19);
			this.coloringBookDetailAddNewPageBtn.TabIndex = 5;
			this.coloringBookDetailAddNewPageBtn.Text = "Add New Page";
			this.coloringBookDetailAddNewPageBtn.UseVisualStyleBackColor = true;
			this.coloringBookDetailAddNewPageBtn.Click += new System.EventHandler(this.coloringBookDetailAddNewPageBtn_Click);
			// 
			// ColoringBookDetail
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(654, 317);
			this.Controls.Add(this.coloringBookDetailTlp);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(670, 306);
			this.Name = "ColoringBookDetail";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "ColoringBookDetail";
			this.Load += new System.EventHandler(this.ColoringBookDetail_Load);
			this.coloringBookDetailTlp.ResumeLayout(false);
			this.coloringBookDetailTlp.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel coloringBookDetailTlp;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label coloringBookDetailBookNameLbl;
		private System.Windows.Forms.Label coloringBookDetailBookAuthorLbl;
		private System.Windows.Forms.ListView coloringBookDetailLv;
		private System.Windows.Forms.ColumnHeader coloringBookDetailPageNumberCh;
		private System.Windows.Forms.ColumnHeader coloringBookDetailPageDescriptionCh;
		private System.Windows.Forms.ColumnHeader coloringBookDetailStartDateCh;
		private System.Windows.Forms.ColumnHeader coloringBookDetailFinishDateCh;
		private System.Windows.Forms.ColumnHeader coloringBookDetailArtSuppliesUsedCh;
		private System.Windows.Forms.ColumnHeader coloringBookDetailNoteCh;
		private System.Windows.Forms.Button coloringBookDetailAddNewPageBtn;
		private System.Windows.Forms.Button coloringBookDetailDeletePageBtn;
		private System.Windows.Forms.Button coloringBookDetailEditPageBtn;
	}
}