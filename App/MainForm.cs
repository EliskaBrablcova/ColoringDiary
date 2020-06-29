using Eli.ColoringDiary.FormsLibrary;
using Eli.ColoringDiary.Repository;
using Eli.ColoringDiary.Models.ViewModels;
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
		private IColoringBookRepository _coloringBookRepo;
		private IList<int> _coloringBooksIds;
		private IColoringBookPageRepository _coloringBookPageRepo;

		public MainForm()
		{
			InitializeComponent();
			_artSupplyRepo = new ArtSupplyFileRepository("data\\artSupplies.json");
			_coloringBookPageRepo = new ColoringBookPageFileRepository("data\\coloringBookPages.json", _artSupplyRepo);
			_coloringBookRepo = new ColoringBookFileRepository("data\\coloringBooks.json", _coloringBookPageRepo);

		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			reloadAll();
		}

		private void reloadAll()
		{
			reloadArtSupplies();
			reloadColoringBooks();
		}
		private void reloadColoringBooks()
		{
			var coloringBooks = _coloringBookRepo.GetAll();
			saveIds(coloringBooks);
			display(coloringBooks);
			setColoringBooksButtonStates();
		}

		private void reloadArtSupplies()
		{
			var artSupplies = _artSupplyRepo.GetAll();
			saveIds(artSupplies);
			display(artSupplies);
			setArtSuppliesButtonStates();
		}

		private void saveIds(List<ColoringBookVM> coloringBooks)
		{
			var ids = new List<int>();
			foreach (var coloringBook in coloringBooks)
			{
				ids.Add(coloringBook.ID);
			}
			_coloringBooksIds = ids;
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

		private void display(List<ColoringBookVM> coloringBooks)
		{
			coloringBooksLv.Items.Clear();
			foreach (var coloringBook in coloringBooks)
			{
				addRow(coloringBook);
			}
		}


		private void display(List<ArtSupplyVM> artSupplies)
		{
			artSuppliesLv.Items.Clear();
			foreach (var artSupply in artSupplies)
			{
				addRow(artSupply);
			}
		}

		private void addRow(ColoringBookVM coloringBook)
		{
			var texts = new[]
			{
				coloringBook.Name,
				coloringBook.Author,
				coloringBook.TotalPages.ToString(),
				$"{coloringBook.TotalPagesColored} ({coloringBook.TotalPagesColoredPercent:#,##0.##} %)",

			};
			var viewItem = new ListViewItem(texts);
			coloringBooksLv.Items.Add(viewItem);
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

		private void addNewBookBtn_Click(object sender, EventArgs e)
		{
			var item = _coloringBookRepo.GetForAdd();
			var dialog = new ColoringBookDialog(item, false);
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				_coloringBookRepo.Add(dialog.Item);
				reloadColoringBooks();
			}
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

		private void editBookBtn_Click(object sender, EventArgs e)
		{
			var selected = coloringBooksLv.SelectedIndices;
			if (selected.Count == 1)
			{
				var selectedIndex = selected[0];
				var item = _coloringBookRepo.GetForEdit(_coloringBooksIds[selectedIndex]);
				if (item == null)
				{
					return;
				}
				var dialog = new ColoringBookDialog(item, true);
				var result = dialog.ShowDialog();
				if (result == DialogResult.OK)
				{
					_coloringBookRepo.Edit(dialog.Item);
					reloadColoringBooks();
				}
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

		private void deleteBookBtn_Click(object sender, EventArgs e)
		{
			deleteColoringBook();
		}

		private void deleteSupplyBtn_Click(object sender, EventArgs e)
		{
			deleteArtSupply();
		}
		private void coloringBooksLv_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				deleteColoringBook();
			}
		}

		private void artSuppliesLv_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				deleteArtSupply();
			}
		}

		private void deleteColoringBook()
		{
			var selected = coloringBooksLv.SelectedIndices;
			if (selected.Count == 1)
			{
				var selectedIndex = selected[0];
				var item = _coloringBookRepo.GetForEdit(_coloringBooksIds[selectedIndex]);
				if (item == null)
				{
					return;
				}
				var text = $"Do you really want to delete {item.Name}?";
				if (_coloringBookPageRepo.HasPages(item.ID))
				{
					text += " It contains pages!";
				}
				var dialog = new CustomMessageBox("Warning", text);
				var result = dialog.ShowDialog();
				if (result == DialogResult.OK)
				{
					_coloringBookPageRepo.DeleteAllPages(item.ID);
					_coloringBookRepo.Delete(item.ID);
					reloadColoringBooks();
				}
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

		private void coloringBooksLv_SelectedIndexChanged(object sender, EventArgs e)
		{
			setColoringBooksButtonStates();
		}

		private void artSuppliesLv_SelectedIndexChanged(object sender, EventArgs e)
		{
			setArtSuppliesButtonStates();
		}

		private void setArtSuppliesButtonStates()
		{
			var selected = artSuppliesLv.SelectedIndices;
			if (selected.Count == 1)
			{
				setArtSuppliesButtonStates(true);
			}
			else
			{
				setArtSuppliesButtonStates(false);
			}
		}

		private void setColoringBooksButtonStates()
		{
			var selected = coloringBooksLv.SelectedIndices;
			if (selected.Count == 1)
			{
				setColoringBooksButtonStates(true);
			}
			else
			{
				setColoringBooksButtonStates(false);
			}
		}

		private void setColoringBooksButtonStates(bool enabled)
		{
			deleteBookBtn.Enabled = enabled;
			editBookBtn.Enabled = enabled;
			detailBookBtn.Enabled = enabled;
		}

		private void setArtSuppliesButtonStates(bool enabled)
		{
			deleteSupplyBtn.Enabled = enabled;
			editSupplyBtn.Enabled = enabled;
		}

		private void detailBookBtn_Click(object sender, EventArgs e)
		{
			var selected = coloringBooksLv.SelectedIndices;
			if (selected.Count == 1)
			{
				var selectedIndex = selected[0];
				var item = _coloringBookRepo.GetForEdit(_coloringBooksIds[selectedIndex]);
				if (item == null)
				{
					return;
				}
				new ColoringBookDetail(item.ID, _coloringBookRepo, _coloringBookPageRepo, _artSupplyRepo).ShowDialog();
				reloadColoringBooks();
			}
		}
	}
}
