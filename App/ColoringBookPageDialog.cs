using Eli.ColoringDiary.Models.Entities;
using Eli.ColoringDiary.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eli.ColoringDiary.App
{
	public partial class ColoringBookPageDialog : Form
	{
		public ColoringBookPage Item { get; }
		private IList<int> _artSuppliesIds;
		public ColoringBookPageDialog(ColoringBookPage item, bool isEdit, IList<ArtSupplyVM> artSupplies)
		{
			InitializeComponent();
			if (item == null)
			{
				throw new ArgumentNullException(nameof(item));
			}
			if (artSupplies == null)
			{
				throw new ArgumentNullException(nameof(artSupplies));
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
			_artSuppliesIds = new List<int>(artSupplies.Count);
			foreach (var artSupply in artSupplies)
			{
				coloringBookDetailDialogArtSuplliesClb.Items.Add($"{artSupply.Name} ({artSupply.Brand})");
				_artSuppliesIds.Add(artSupply.ID);
			}
		}

		private void setControls()
		{
			coloringBookDetailDialogPageNumberNud.Value = Item.PageNumber;
			coloringBookDetailDialogPageDescriptionTB.Text = Item.PageDescription;
			coloringBookDetailDialogNoteTB.Text = Item.Note;
			coloringBookDetailDialogStartDateDtp.Value = Item.StartDate;
			coloringBookDetailDialogFinishDateDtp.Value = Item.FinishDate;
			if (Item.ArtSuppliesUsed != null)
			{
				foreach (var id in Item.ArtSuppliesUsed)
				{
					setChecked(id);
				}
			}
		}

		private void setItem()
		{
			Item.PageNumber = (int)coloringBookDetailDialogPageNumberNud.Value;
			Item.PageDescription = coloringBookDetailDialogPageDescriptionTB.Text;
			Item.Note = coloringBookDetailDialogNoteTB.Text;
			Item.StartDate = coloringBookDetailDialogStartDateDtp.Value?.Date;
			Item.FinishDate = coloringBookDetailDialogFinishDateDtp.Value?.Date;
			Item.ArtSuppliesUsed = getUsedArtSupplies();
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
		private void setChecked(int id)
		{
			for (int i = 0; i < _artSuppliesIds.Count; i++)
			{
				if (id == _artSuppliesIds[i])
				{
					coloringBookDetailDialogArtSuplliesClb.SetItemChecked(i, true);
					break;
				}
			}
		}

		private List<int> getUsedArtSupplies()
		{
			var artSuppliesUsed = new List<int>(coloringBookDetailDialogArtSuplliesClb.CheckedItems.Count);
			foreach (int position in coloringBookDetailDialogArtSuplliesClb.CheckedIndices)
			{
				artSuppliesUsed.Add(_artSuppliesIds[position]);
			}
			return artSuppliesUsed;
		}
	}
}
