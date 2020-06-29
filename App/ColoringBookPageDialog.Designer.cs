namespace Eli.ColoringDiary.App
{
	partial class ColoringBookPageDialog
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColoringBookPageDialog));
			this.coloringBookDetailDialogSaveBtn = new System.Windows.Forms.Button();
			this.coloringBookDetailDialogCancelBtn = new System.Windows.Forms.Button();
			this.coloringBookDetailDialogTlp = new System.Windows.Forms.TableLayoutPanel();
			this.coloringBookDetailDialogNoteTB = new System.Windows.Forms.TextBox();
			this.coloringBookDetailDialogPageNumberLbl = new System.Windows.Forms.Label();
			this.coloringBookDetailDialogPageDescriptionLbl = new System.Windows.Forms.Label();
			this.coloringBookDetailDialogNoteLbl = new System.Windows.Forms.Label();
			this.coloringBookDetailDialogStartDateLbl = new System.Windows.Forms.Label();
			this.coloringBookDetailDialogFinishDateLbl = new System.Windows.Forms.Label();
			this.coloringBookDetailDialogArtSuplliesLbl = new System.Windows.Forms.Label();
			this.coloringBookDetailDialogPageNumberNud = new System.Windows.Forms.NumericUpDown();
			this.coloringBookDetailDialogPageDescriptionTB = new System.Windows.Forms.TextBox();
			this.coloringBookDetailDialogArtSuplliesClb = new System.Windows.Forms.CheckedListBox();
			this.coloringBookDetailDialogStartDateDtp = new Eli.TimeManagement.FormsLibrary.NullableDateTimePicker();
			this.coloringBookDetailDialogFinishDateDtp = new Eli.TimeManagement.FormsLibrary.NullableDateTimePicker();
			this.coloringBookDetailDialogTlp.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.coloringBookDetailDialogPageNumberNud)).BeginInit();
			this.SuspendLayout();
			// 
			// coloringBookDetailDialogSaveBtn
			// 
			this.coloringBookDetailDialogSaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.coloringBookDetailDialogSaveBtn.Location = new System.Drawing.Point(365, 169);
			this.coloringBookDetailDialogSaveBtn.Name = "coloringBookDetailDialogSaveBtn";
			this.coloringBookDetailDialogSaveBtn.Size = new System.Drawing.Size(75, 23);
			this.coloringBookDetailDialogSaveBtn.TabIndex = 2;
			this.coloringBookDetailDialogSaveBtn.Text = "Save";
			this.coloringBookDetailDialogSaveBtn.UseVisualStyleBackColor = true;
			this.coloringBookDetailDialogSaveBtn.Click += new System.EventHandler(this.coloringBookDetailDialogSaveBtn_Click);
			// 
			// coloringBookDetailDialogCancelBtn
			// 
			this.coloringBookDetailDialogCancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.coloringBookDetailDialogCancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.coloringBookDetailDialogCancelBtn.Location = new System.Drawing.Point(284, 169);
			this.coloringBookDetailDialogCancelBtn.MinimumSize = new System.Drawing.Size(75, 23);
			this.coloringBookDetailDialogCancelBtn.Name = "coloringBookDetailDialogCancelBtn";
			this.coloringBookDetailDialogCancelBtn.Size = new System.Drawing.Size(75, 23);
			this.coloringBookDetailDialogCancelBtn.TabIndex = 3;
			this.coloringBookDetailDialogCancelBtn.Text = "Cancel";
			this.coloringBookDetailDialogCancelBtn.UseVisualStyleBackColor = true;
			// 
			// coloringBookDetailDialogTlp
			// 
			this.coloringBookDetailDialogTlp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.coloringBookDetailDialogTlp.ColumnCount = 2;
			this.coloringBookDetailDialogTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.coloringBookDetailDialogTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.coloringBookDetailDialogTlp.Controls.Add(this.coloringBookDetailDialogNoteTB, 1, 2);
			this.coloringBookDetailDialogTlp.Controls.Add(this.coloringBookDetailDialogPageNumberLbl, 0, 0);
			this.coloringBookDetailDialogTlp.Controls.Add(this.coloringBookDetailDialogPageDescriptionLbl, 0, 1);
			this.coloringBookDetailDialogTlp.Controls.Add(this.coloringBookDetailDialogNoteLbl, 0, 2);
			this.coloringBookDetailDialogTlp.Controls.Add(this.coloringBookDetailDialogStartDateLbl, 0, 3);
			this.coloringBookDetailDialogTlp.Controls.Add(this.coloringBookDetailDialogFinishDateLbl, 0, 4);
			this.coloringBookDetailDialogTlp.Controls.Add(this.coloringBookDetailDialogArtSuplliesLbl, 0, 5);
			this.coloringBookDetailDialogTlp.Controls.Add(this.coloringBookDetailDialogPageNumberNud, 1, 0);
			this.coloringBookDetailDialogTlp.Controls.Add(this.coloringBookDetailDialogPageDescriptionTB, 1, 1);
			this.coloringBookDetailDialogTlp.Controls.Add(this.coloringBookDetailDialogArtSuplliesClb, 1, 5);
			this.coloringBookDetailDialogTlp.Controls.Add(this.coloringBookDetailDialogStartDateDtp, 1, 3);
			this.coloringBookDetailDialogTlp.Controls.Add(this.coloringBookDetailDialogFinishDateDtp, 1, 4);
			this.coloringBookDetailDialogTlp.Location = new System.Drawing.Point(12, 12);
			this.coloringBookDetailDialogTlp.Name = "coloringBookDetailDialogTlp";
			this.coloringBookDetailDialogTlp.RowCount = 6;
			this.coloringBookDetailDialogTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.coloringBookDetailDialogTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.coloringBookDetailDialogTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.coloringBookDetailDialogTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.coloringBookDetailDialogTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.coloringBookDetailDialogTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.coloringBookDetailDialogTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.coloringBookDetailDialogTlp.Size = new System.Drawing.Size(428, 151);
			this.coloringBookDetailDialogTlp.TabIndex = 4;
			// 
			// coloringBookDetailDialogNoteTB
			// 
			this.coloringBookDetailDialogNoteTB.Dock = System.Windows.Forms.DockStyle.Fill;
			this.coloringBookDetailDialogNoteTB.Location = new System.Drawing.Point(103, 53);
			this.coloringBookDetailDialogNoteTB.Name = "coloringBookDetailDialogNoteTB";
			this.coloringBookDetailDialogNoteTB.Size = new System.Drawing.Size(322, 20);
			this.coloringBookDetailDialogNoteTB.TabIndex = 10;
			// 
			// coloringBookDetailDialogPageNumberLbl
			// 
			this.coloringBookDetailDialogPageNumberLbl.AutoSize = true;
			this.coloringBookDetailDialogPageNumberLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.coloringBookDetailDialogPageNumberLbl.Location = new System.Drawing.Point(3, 0);
			this.coloringBookDetailDialogPageNumberLbl.Name = "coloringBookDetailDialogPageNumberLbl";
			this.coloringBookDetailDialogPageNumberLbl.Size = new System.Drawing.Size(94, 25);
			this.coloringBookDetailDialogPageNumberLbl.TabIndex = 0;
			this.coloringBookDetailDialogPageNumberLbl.Text = "Page Number";
			this.coloringBookDetailDialogPageNumberLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// coloringBookDetailDialogPageDescriptionLbl
			// 
			this.coloringBookDetailDialogPageDescriptionLbl.AutoSize = true;
			this.coloringBookDetailDialogPageDescriptionLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.coloringBookDetailDialogPageDescriptionLbl.Location = new System.Drawing.Point(3, 25);
			this.coloringBookDetailDialogPageDescriptionLbl.Name = "coloringBookDetailDialogPageDescriptionLbl";
			this.coloringBookDetailDialogPageDescriptionLbl.Size = new System.Drawing.Size(94, 25);
			this.coloringBookDetailDialogPageDescriptionLbl.TabIndex = 1;
			this.coloringBookDetailDialogPageDescriptionLbl.Text = "Page Description";
			this.coloringBookDetailDialogPageDescriptionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// coloringBookDetailDialogNoteLbl
			// 
			this.coloringBookDetailDialogNoteLbl.AutoSize = true;
			this.coloringBookDetailDialogNoteLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.coloringBookDetailDialogNoteLbl.Location = new System.Drawing.Point(3, 50);
			this.coloringBookDetailDialogNoteLbl.Name = "coloringBookDetailDialogNoteLbl";
			this.coloringBookDetailDialogNoteLbl.Size = new System.Drawing.Size(94, 25);
			this.coloringBookDetailDialogNoteLbl.TabIndex = 2;
			this.coloringBookDetailDialogNoteLbl.Text = "Note";
			this.coloringBookDetailDialogNoteLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// coloringBookDetailDialogStartDateLbl
			// 
			this.coloringBookDetailDialogStartDateLbl.AutoSize = true;
			this.coloringBookDetailDialogStartDateLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.coloringBookDetailDialogStartDateLbl.Location = new System.Drawing.Point(3, 75);
			this.coloringBookDetailDialogStartDateLbl.Name = "coloringBookDetailDialogStartDateLbl";
			this.coloringBookDetailDialogStartDateLbl.Size = new System.Drawing.Size(94, 25);
			this.coloringBookDetailDialogStartDateLbl.TabIndex = 3;
			this.coloringBookDetailDialogStartDateLbl.Text = "Start Date";
			this.coloringBookDetailDialogStartDateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// coloringBookDetailDialogFinishDateLbl
			// 
			this.coloringBookDetailDialogFinishDateLbl.AutoSize = true;
			this.coloringBookDetailDialogFinishDateLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.coloringBookDetailDialogFinishDateLbl.Location = new System.Drawing.Point(3, 100);
			this.coloringBookDetailDialogFinishDateLbl.Name = "coloringBookDetailDialogFinishDateLbl";
			this.coloringBookDetailDialogFinishDateLbl.Size = new System.Drawing.Size(94, 25);
			this.coloringBookDetailDialogFinishDateLbl.TabIndex = 4;
			this.coloringBookDetailDialogFinishDateLbl.Text = "Finish Date";
			this.coloringBookDetailDialogFinishDateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// coloringBookDetailDialogArtSuplliesLbl
			// 
			this.coloringBookDetailDialogArtSuplliesLbl.AutoSize = true;
			this.coloringBookDetailDialogArtSuplliesLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.coloringBookDetailDialogArtSuplliesLbl.Location = new System.Drawing.Point(3, 125);
			this.coloringBookDetailDialogArtSuplliesLbl.Name = "coloringBookDetailDialogArtSuplliesLbl";
			this.coloringBookDetailDialogArtSuplliesLbl.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
			this.coloringBookDetailDialogArtSuplliesLbl.Size = new System.Drawing.Size(94, 26);
			this.coloringBookDetailDialogArtSuplliesLbl.TabIndex = 5;
			this.coloringBookDetailDialogArtSuplliesLbl.Text = "Art Supplies Used";
			// 
			// coloringBookDetailDialogPageNumberNud
			// 
			this.coloringBookDetailDialogPageNumberNud.Dock = System.Windows.Forms.DockStyle.Fill;
			this.coloringBookDetailDialogPageNumberNud.Location = new System.Drawing.Point(103, 3);
			this.coloringBookDetailDialogPageNumberNud.Name = "coloringBookDetailDialogPageNumberNud";
			this.coloringBookDetailDialogPageNumberNud.Size = new System.Drawing.Size(322, 20);
			this.coloringBookDetailDialogPageNumberNud.TabIndex = 8;
			// 
			// coloringBookDetailDialogPageDescriptionTB
			// 
			this.coloringBookDetailDialogPageDescriptionTB.Dock = System.Windows.Forms.DockStyle.Fill;
			this.coloringBookDetailDialogPageDescriptionTB.Location = new System.Drawing.Point(103, 28);
			this.coloringBookDetailDialogPageDescriptionTB.Name = "coloringBookDetailDialogPageDescriptionTB";
			this.coloringBookDetailDialogPageDescriptionTB.Size = new System.Drawing.Size(322, 20);
			this.coloringBookDetailDialogPageDescriptionTB.TabIndex = 9;
			// 
			// coloringBookDetailDialogArtSuplliesClb
			// 
			this.coloringBookDetailDialogArtSuplliesClb.Dock = System.Windows.Forms.DockStyle.Fill;
			this.coloringBookDetailDialogArtSuplliesClb.FormattingEnabled = true;
			this.coloringBookDetailDialogArtSuplliesClb.Location = new System.Drawing.Point(103, 128);
			this.coloringBookDetailDialogArtSuplliesClb.Name = "coloringBookDetailDialogArtSuplliesClb";
			this.coloringBookDetailDialogArtSuplliesClb.Size = new System.Drawing.Size(322, 20);
			this.coloringBookDetailDialogArtSuplliesClb.TabIndex = 11;
			// 
			// coloringBookDetailDialogStartDateDtp
			// 
			this.coloringBookDetailDialogStartDateDtp.CustomFormat = null;
			this.coloringBookDetailDialogStartDateDtp.Dock = System.Windows.Forms.DockStyle.Fill;
			this.coloringBookDetailDialogStartDateDtp.Location = new System.Drawing.Point(103, 78);
			this.coloringBookDetailDialogStartDateDtp.Name = "coloringBookDetailDialogStartDateDtp";
			this.coloringBookDetailDialogStartDateDtp.Size = new System.Drawing.Size(322, 19);
			this.coloringBookDetailDialogStartDateDtp.TabIndex = 12;
			// 
			// coloringBookDetailDialogFinishDateDtp
			// 
			this.coloringBookDetailDialogFinishDateDtp.CustomFormat = null;
			this.coloringBookDetailDialogFinishDateDtp.Dock = System.Windows.Forms.DockStyle.Fill;
			this.coloringBookDetailDialogFinishDateDtp.Location = new System.Drawing.Point(103, 103);
			this.coloringBookDetailDialogFinishDateDtp.Name = "coloringBookDetailDialogFinishDateDtp";
			this.coloringBookDetailDialogFinishDateDtp.Size = new System.Drawing.Size(322, 19);
			this.coloringBookDetailDialogFinishDateDtp.TabIndex = 13;
			// 
			// ColoringBookPageDialog
			// 
			this.AcceptButton = this.coloringBookDetailDialogSaveBtn;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.coloringBookDetailDialogCancelBtn;
			this.ClientSize = new System.Drawing.Size(452, 204);
			this.ControlBox = false;
			this.Controls.Add(this.coloringBookDetailDialogTlp);
			this.Controls.Add(this.coloringBookDetailDialogCancelBtn);
			this.Controls.Add(this.coloringBookDetailDialogSaveBtn);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ColoringBookPageDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "ColoringBookPageDialog";
			this.Load += new System.EventHandler(this.ColoringBookPageDialog_Load);
			this.coloringBookDetailDialogTlp.ResumeLayout(false);
			this.coloringBookDetailDialogTlp.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.coloringBookDetailDialogPageNumberNud)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button coloringBookDetailDialogSaveBtn;
		private System.Windows.Forms.Button coloringBookDetailDialogCancelBtn;
		private System.Windows.Forms.TableLayoutPanel coloringBookDetailDialogTlp;
		private System.Windows.Forms.Label coloringBookDetailDialogPageNumberLbl;
		private System.Windows.Forms.Label coloringBookDetailDialogPageDescriptionLbl;
		private System.Windows.Forms.Label coloringBookDetailDialogNoteLbl;
		private System.Windows.Forms.Label coloringBookDetailDialogStartDateLbl;
		private System.Windows.Forms.Label coloringBookDetailDialogFinishDateLbl;
		private System.Windows.Forms.Label coloringBookDetailDialogArtSuplliesLbl;
		private System.Windows.Forms.TextBox coloringBookDetailDialogNoteTB;
		private System.Windows.Forms.NumericUpDown coloringBookDetailDialogPageNumberNud;
		private System.Windows.Forms.TextBox coloringBookDetailDialogPageDescriptionTB;
		private System.Windows.Forms.CheckedListBox coloringBookDetailDialogArtSuplliesClb;
		private TimeManagement.FormsLibrary.NullableDateTimePicker coloringBookDetailDialogStartDateDtp;
		private TimeManagement.FormsLibrary.NullableDateTimePicker coloringBookDetailDialogFinishDateDtp;
	}
}