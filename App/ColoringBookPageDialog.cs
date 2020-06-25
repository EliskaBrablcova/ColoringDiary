using Eli.ColoringDiary.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eli.ColoringDiary.App
{
	public partial class ColoringBookPageDialog : Form
	{
		public ColoringBookPage Item { get; }

		public ColoringBookPageDialog(ColoringBookPage item, bool isEdit)
		{
			InitializeComponent();
			if (item == null)
			{
				throw new ArgumentNullException(nameof(item));
			}
			Item = item;
			if (isEdit)
			{
				Text = "Edit Page";
			}
			else
			{
				Text = "Add new page";
			}
		}

		private void setControls()
		{
			coloringBookDetailDialogPageNumberNud.Value = Item.PageNumber;
			coloringBookDetailDialogPageDescriptionTB.Text = Item.PageDescription;
			coloringBookDetailDialogNoteTB.Text = Item.Note;
			//coloringBookDetailDialogStartDateDtp.Value = Item.StartDate;
			//coloringBookDetailDialogFinishDateDtp.Value = Item.FinishDate;
			//coloringBookDetailDialogArtSuplliesClb.Items = Item.ArtSuppliesUsed;

		}

		private void setItem()
		{
			Item.PageNumber = (int)coloringBookDetailDialogPageNumberNud.Value;
			Item.PageDescription = coloringBookDetailDialogPageDescriptionTB.Text;
			Item.Note = coloringBookDetailDialogNoteTB.Text;
			Item.StartDate = coloringBookDetailDialogStartDateDtp.Value.Date;
			Item.FinishDate = coloringBookDetailDialogFinishDateDtp.Value.Date;
			//Item.ArtSuppliesUsed = coloringBookDetailDialogArtSuplliesClb.Items;
		}

		private void ColoringBookPageDialog_Load(object sender, EventArgs e)
		{
			setControls();
		}

		private void coloringBookDetailDialogSaveBtn_Click(object sender, EventArgs e)
		{
			setItem();
			DialogResult = DialogResult.OK;
			Close();
		}
	}
}
