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
	public partial class ColoringBookDialog : Form
	{
		public ColoringBook Item { get; }
		public ColoringBookDialog(ColoringBook item, bool isEdit)
		{
			InitializeComponent();
			if (item == null)
			{
				throw new ArgumentNullException(nameof(item));
			}
			Item = item;
			if (isEdit)
			{
				Text = "Coloring Book Editation";
			}
			else
			{
				Text = "Add new Coloring Book";
			}
		}
		
		private void setControls()
		{
			coloringBookDialogAuthorTb.Text = Item.Author;
			coloringBookDialogNameTb.Text = Item.Name;
			coloringBookDialogPagesTotalNud.Value = Item.TotalPages;
		}

		private void setItem()
		{
			Item.Author = coloringBookDialogAuthorTb.Text;
			Item.Name = coloringBookDialogNameTb.Text;
			Item.TotalPages = (int)coloringBookDialogPagesTotalNud.Value;
		}

		private void coloringBookDialogSaveBtn_Click(object sender, EventArgs e)
		{
			setItem();
			DialogResult = DialogResult.OK;
			Close();
		}

		private void ColoringBookDialog_Load(object sender, EventArgs e)
		{
			setControls();
		}
	}
}
