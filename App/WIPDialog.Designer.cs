namespace Eli.ColoringDiary.App
{
	partial class WIPDialog
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WIPDialog));
			this.WIPDialogSaveBtn = new System.Windows.Forms.Button();
			this.WIPDialogCancelBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// WIPDialogSaveBtn
			// 
			this.WIPDialogSaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.WIPDialogSaveBtn.Location = new System.Drawing.Point(335, 166);
			this.WIPDialogSaveBtn.Name = "WIPDialogSaveBtn";
			this.WIPDialogSaveBtn.Size = new System.Drawing.Size(75, 23);
			this.WIPDialogSaveBtn.TabIndex = 2;
			this.WIPDialogSaveBtn.Text = "Save";
			this.WIPDialogSaveBtn.UseVisualStyleBackColor = true;
			// 
			// WIPDialogCancelBtn
			// 
			this.WIPDialogCancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.WIPDialogCancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.WIPDialogCancelBtn.Location = new System.Drawing.Point(254, 166);
			this.WIPDialogCancelBtn.MinimumSize = new System.Drawing.Size(75, 23);
			this.WIPDialogCancelBtn.Name = "WIPDialogCancelBtn";
			this.WIPDialogCancelBtn.Size = new System.Drawing.Size(75, 23);
			this.WIPDialogCancelBtn.TabIndex = 3;
			this.WIPDialogCancelBtn.Text = "Cancel";
			this.WIPDialogCancelBtn.UseVisualStyleBackColor = true;
			// 
			// WIPDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(422, 201);
			this.ControlBox = false;
			this.Controls.Add(this.WIPDialogCancelBtn);
			this.Controls.Add(this.WIPDialogSaveBtn);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "WIPDialog";
			this.Text = "WIPDialog";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button WIPDialogSaveBtn;
		private System.Windows.Forms.Button WIPDialogCancelBtn;
	}
}