namespace Eli.ColoringDiary.App
{
	partial class TaskDialog
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskDialog));
			this.checkItemDialogTlp = new System.Windows.Forms.TableLayoutPanel();
			this.taskTextTB = new System.Windows.Forms.TextBox();
			this.taskTextLbl = new System.Windows.Forms.Label();
			this.taskCompletedLbl = new System.Windows.Forms.Label();
			this.taskCompletedCB = new System.Windows.Forms.CheckBox();
			this.taskTypeLbl = new System.Windows.Forms.Label();
			this.taskTypeCB = new System.Windows.Forms.ComboBox();
			this.TaskCancelBtn = new System.Windows.Forms.Button();
			this.TaskSaveBtn = new System.Windows.Forms.Button();
			this.checkItemDialogTlp.SuspendLayout();
			this.SuspendLayout();
			// 
			// checkItemDialogTlp
			// 
			this.checkItemDialogTlp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.checkItemDialogTlp.ColumnCount = 2;
			this.checkItemDialogTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
			this.checkItemDialogTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.checkItemDialogTlp.Controls.Add(this.taskTextTB, 1, 2);
			this.checkItemDialogTlp.Controls.Add(this.taskTextLbl, 0, 2);
			this.checkItemDialogTlp.Controls.Add(this.taskCompletedLbl, 0, 0);
			this.checkItemDialogTlp.Controls.Add(this.taskCompletedCB, 1, 0);
			this.checkItemDialogTlp.Controls.Add(this.taskTypeLbl, 0, 1);
			this.checkItemDialogTlp.Controls.Add(this.taskTypeCB, 1, 1);
			this.checkItemDialogTlp.Location = new System.Drawing.Point(12, 12);
			this.checkItemDialogTlp.Name = "checkItemDialogTlp";
			this.checkItemDialogTlp.RowCount = 3;
			this.checkItemDialogTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.checkItemDialogTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.checkItemDialogTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.checkItemDialogTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.checkItemDialogTlp.Size = new System.Drawing.Size(311, 153);
			this.checkItemDialogTlp.TabIndex = 15;
			// 
			// taskTextTB
			// 
			this.taskTextTB.Dock = System.Windows.Forms.DockStyle.Fill;
			this.taskTextTB.Location = new System.Drawing.Point(107, 53);
			this.taskTextTB.Multiline = true;
			this.taskTextTB.Name = "taskTextTB";
			this.taskTextTB.Size = new System.Drawing.Size(201, 97);
			this.taskTextTB.TabIndex = 12;
			// 
			// taskTextLbl
			// 
			this.taskTextLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.taskTextLbl.Location = new System.Drawing.Point(3, 50);
			this.taskTextLbl.Name = "taskTextLbl";
			this.taskTextLbl.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.taskTextLbl.Size = new System.Drawing.Size(98, 103);
			this.taskTextLbl.TabIndex = 10;
			this.taskTextLbl.Text = "Text";
			// 
			// taskCompletedLbl
			// 
			this.taskCompletedLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.taskCompletedLbl.Location = new System.Drawing.Point(3, 0);
			this.taskCompletedLbl.Name = "taskCompletedLbl";
			this.taskCompletedLbl.Size = new System.Drawing.Size(98, 25);
			this.taskCompletedLbl.TabIndex = 5;
			this.taskCompletedLbl.Text = "Completed";
			this.taskCompletedLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// taskCompletedCB
			// 
			this.taskCompletedCB.AutoSize = true;
			this.taskCompletedCB.Dock = System.Windows.Forms.DockStyle.Fill;
			this.taskCompletedCB.Location = new System.Drawing.Point(107, 3);
			this.taskCompletedCB.Name = "taskCompletedCB";
			this.taskCompletedCB.Size = new System.Drawing.Size(201, 19);
			this.taskCompletedCB.TabIndex = 11;
			this.taskCompletedCB.UseVisualStyleBackColor = true;
			// 
			// taskTypeLbl
			// 
			this.taskTypeLbl.AutoSize = true;
			this.taskTypeLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.taskTypeLbl.Location = new System.Drawing.Point(3, 25);
			this.taskTypeLbl.Name = "taskTypeLbl";
			this.taskTypeLbl.Size = new System.Drawing.Size(98, 25);
			this.taskTypeLbl.TabIndex = 13;
			this.taskTypeLbl.Text = "Task Type";
			this.taskTypeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// taskTypeCB
			// 
			this.taskTypeCB.Dock = System.Windows.Forms.DockStyle.Fill;
			this.taskTypeCB.FormattingEnabled = true;
			this.taskTypeCB.Location = new System.Drawing.Point(107, 28);
			this.taskTypeCB.Name = "taskTypeCB";
			this.taskTypeCB.Size = new System.Drawing.Size(201, 21);
			this.taskTypeCB.TabIndex = 14;
			// 
			// TaskCancelBtn
			// 
			this.TaskCancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.TaskCancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.TaskCancelBtn.Location = new System.Drawing.Point(167, 173);
			this.TaskCancelBtn.MinimumSize = new System.Drawing.Size(75, 23);
			this.TaskCancelBtn.Name = "TaskCancelBtn";
			this.TaskCancelBtn.Size = new System.Drawing.Size(75, 23);
			this.TaskCancelBtn.TabIndex = 16;
			this.TaskCancelBtn.Text = "Cancel";
			this.TaskCancelBtn.UseVisualStyleBackColor = true;
			// 
			// TaskSaveBtn
			// 
			this.TaskSaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.TaskSaveBtn.Location = new System.Drawing.Point(248, 173);
			this.TaskSaveBtn.Name = "TaskSaveBtn";
			this.TaskSaveBtn.Size = new System.Drawing.Size(75, 23);
			this.TaskSaveBtn.TabIndex = 17;
			this.TaskSaveBtn.Text = "Save";
			this.TaskSaveBtn.UseVisualStyleBackColor = true;
			// 
			// TaskDialog
			// 
			this.AcceptButton = this.TaskSaveBtn;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.TaskCancelBtn;
			this.ClientSize = new System.Drawing.Size(335, 208);
			this.ControlBox = false;
			this.Controls.Add(this.TaskSaveBtn);
			this.Controls.Add(this.TaskCancelBtn);
			this.Controls.Add(this.checkItemDialogTlp);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(317, 172);
			this.Name = "TaskDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "TaskDialog";
			this.checkItemDialogTlp.ResumeLayout(false);
			this.checkItemDialogTlp.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel checkItemDialogTlp;
		private System.Windows.Forms.TextBox taskTextTB;
		private System.Windows.Forms.Label taskTextLbl;
		private System.Windows.Forms.Label taskCompletedLbl;
		private System.Windows.Forms.CheckBox taskCompletedCB;
		private System.Windows.Forms.Label taskTypeLbl;
		private System.Windows.Forms.ComboBox taskTypeCB;
		private System.Windows.Forms.Button TaskCancelBtn;
		private System.Windows.Forms.Button TaskSaveBtn;
	}
}