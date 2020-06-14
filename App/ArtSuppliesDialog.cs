using Models.Entities;
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
	public partial class ArtSuppliesDialog : Form
	{
		public ArtSupply Item { get; }
		public ArtSuppliesDialog(ArtSupply item, bool isEdit, List<string> types)
		{
			InitializeComponent();
			if (item == null)
			{
				throw new NullReferenceException(nameof(item));
			}
			Item = item;
			if (isEdit)
			{
				Text = "Art Supply Editation";
			}
			else
			{
				Text = "Art Supply Addition";
			}
			if (types != null)
			{
				foreach (var type in types)
				{
					artSuppliesDialogTypeCB.Items.Add(type);
				}
			}
		}

		private void setControls()
		{
			artSuppliesDialogNameTB.Text = Item.Name;
			artSuppliesDialogBrandTB.Text = Item.Brand;
			artSuppliesDialogTypeCB.Text = Item.Type;
		}

		private void setItem()
		{
			Item.Name = artSuppliesDialogNameTB.Text;
			Item.Brand = artSuppliesDialogBrandTB.Text;
			Item.Type = artSuppliesDialogTypeCB.Text;
		}

		private void ArtSuppliesDialog_Load(object sender, EventArgs e)
		{
			setControls();
		}

		private void artSuppliesDialogSaveBtn_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			setItem();
			Close();
		}
	}
}
