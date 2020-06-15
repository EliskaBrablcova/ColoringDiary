using Eli.ColoringDiary.FormsLibrary;
using Eli.ColoringDiary.Repository;
using Models.ViewModels;
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
	public partial class MainForm : Form
	{
		private IArtSupplyRepository _artSupplyRepo;
		private IList<int> _artSuppliesIds;

		public MainForm()
		{
			InitializeComponent();
			_artSupplyRepo = new ArtSupplyFileRepository("data\\artSupplies.json");
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			reloadAll();
		}

		private void reloadAll()
		{
			reloadArtSupplies();
		}

		private void reloadArtSupplies()
		{
			var artSupplies = _artSupplyRepo.GetAll();
			saveIds(artSupplies);
			display(artSupplies);
		}
		private void saveIds(List<ArtSupplyVM> artSupplies)
		{
			var ids = new List<int>();
			foreach (var artSupply in artSupplies)
			{
				ids.Add(artSupply.ID);
			}
			_artSuppliesIds = ids;
		}

		private void display(List<ArtSupplyVM> artSupplies)
		{
			artSuppliesLv.Items.Clear();
			foreach (var artSupply in artSupplies)
			{
				addRow(artSupply);
			}
		}

		private void addRow(ArtSupplyVM artSupply)
		{
			var texts = new[]
			{
				artSupply.Name,
				artSupply.Brand,
				artSupply.Type,

			};
			var viewItem = new ListViewItem(texts);
			artSuppliesLv.Items.Add(viewItem);
		}

		private void addNewSupplyBtn_Click(object sender, EventArgs e)
		{
			var item = _artSupplyRepo.GetForAdd();
			var dialog = new ArtSuppliesDialog(item, false, _artSupplyRepo.GetAllTypes());
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				_artSupplyRepo.Add(dialog.Item);
				reloadArtSupplies();
			}
		}

		private void editSupplyBtn_Click(object sender, EventArgs e)
		{
			var selected = artSuppliesLv.SelectedIndices;
			if (selected.Count == 1)
			{
				var selectedIndex = selected[0];
				var item = _artSupplyRepo.GetForEdit(_artSuppliesIds[selectedIndex]);
				if (item == null)
				{
					return;
				}
				var dialog = new ArtSuppliesDialog(item, true, _artSupplyRepo.GetAllTypes());
				var result = dialog.ShowDialog();
				if (result == DialogResult.OK)
				{
					_artSupplyRepo.Edit(dialog.Item);
					reloadArtSupplies();
				}
			}
		}

		private void deleteSupplyBtn_Click(object sender, EventArgs e)
		{
			deleteArtSupply();
		}

		private void artSuppliesLv_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				deleteArtSupply();
			}
		}

		private void deleteArtSupply()
		{
			var selected = artSuppliesLv.SelectedIndices;
			if (selected.Count == 1)
			{
				var selectedIndex = selected[0];
				var item = _artSupplyRepo.GetForEdit(_artSuppliesIds[selectedIndex]);
				if (item == null)
				{
					return;
				}
				var dialog = new CustomMessageBox("Warning", $"Do you really want to delete {item.Name}?");
				var result = dialog.ShowDialog();
				if (result == DialogResult.OK)
				{
					_artSupplyRepo.Delete(_artSuppliesIds[selectedIndex]);
					reloadArtSupplies();
				}
			}
		}
	}
}
