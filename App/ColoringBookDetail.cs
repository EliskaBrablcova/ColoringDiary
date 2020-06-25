using Eli.ColoringDiary.FormsLibrary;
using Eli.ColoringDiary.Models.Entities;
using Eli.ColoringDiary.Models.ViewModels;
using Eli.ColoringDiary.Repository;
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
	public partial class ColoringBookDetail : Form
	{

		private IColoringBookPageRepository _coloringBookPageRepo;
		private IColoringBookRepository _coloringBookRepo;
		private IList<int> _coloringBookPageIds;
		private int _coloringBookId;

		public ColoringBookDetail(int coloringBookId, IColoringBookRepository coloringBookRepo, IColoringBookPageRepository coloringBookPageRepo)
		{
			InitializeComponent();
			if (coloringBookRepo == null)
			{
				throw new ArgumentNullException(nameof(coloringBookRepo));
			}
			if (coloringBookPageRepo == null)
			{
				throw new ArgumentNullException(nameof(coloringBookPageRepo));
			}
			_coloringBookRepo = coloringBookRepo;
			_coloringBookPageRepo = coloringBookPageRepo;
			var coloringBook = _coloringBookRepo.GetForEdit(coloringBookId);
			if (coloringBook == null)
			{
				throw new ArgumentException("Book does not exist.", nameof(coloringBookId));
			}
			_coloringBookId = coloringBook.ID;
			coloringBookDetailBookNameLbl.Text = coloringBook.Name;
			coloringBookDetailBookAuthorLbl.Text = coloringBook.Author;
			Text = $"{coloringBook.Name} by {coloringBook.Author}";
		}

		private void ColoringBookDetail_Load(object sender, EventArgs e)
		{
			reloadColoringBookPages();
		}

		private void reloadColoringBookPages()
		{
			var coloringBookPages = _coloringBookPageRepo.GetAll(_coloringBookId);
			saveIds(coloringBookPages);
			display(coloringBookPages);
			setColoringBookPagesButtonStates();
		}

		private void saveIds(List<ColoringBookPageVM> coloringBookPages)
		{
			var ids = new List<int>();
			foreach (var coloringBookPage in coloringBookPages)
			{
				ids.Add(coloringBookPage.ID);
			}
			_coloringBookPageIds = ids;
		}

		private void display(List<ColoringBookPageVM> coloringBookPages)
		{
			coloringBookDetailLv.Items.Clear();
			foreach (var coloringBookPage in coloringBookPages)
			{
				addRow(coloringBookPage);
			}
		}

		private void addRow(ColoringBookPageVM coloringBookPage)
		{
			var texts = new[]
			{
				coloringBookPage.PageNumber.ToString(),
				coloringBookPage.PageDescription,
				coloringBookPage.Note,
				coloringBookPage.StartDate.ToString(),
				coloringBookPage.FinishDate.ToString(),
				//coloringBookPage.ArtSuppliesUsed,
			};
			var viewItem = new ListViewItem(texts);
			coloringBookDetailLv.Items.Add(viewItem);
		}

		private void setColoringBookPagesButtonStates()
		{
			var selected = coloringBookDetailLv.SelectedIndices;
			if (selected.Count == 1)
			{
				setColoringBookPagesButtonStates(true);
			}
			else
			{
				setColoringBookPagesButtonStates(false);
			}
		}

		private void setColoringBookPagesButtonStates(bool enabled)
		{
			coloringBookDetailDeletePageBtn.Enabled = enabled;
			coloringBookDetailEditPageBtn.Enabled = enabled;
		}

		private void coloringBookDetailAddNewPageBtn_Click(object sender, EventArgs e)
		{
			var item = _coloringBookPageRepo.GetForAdd(_coloringBookId);
			var dialog = new ColoringBookPageDialog(item, false);
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				_coloringBookPageRepo.Add(dialog.Item);
				reloadColoringBookPages();
			}
		}

		private void coloringBookDetailEditPageBtn_Click(object sender, EventArgs e)
		{
			var selected = coloringBookDetailLv.SelectedIndices;
			if (selected.Count == 1)
			{
				var selectedIndex = selected[0];
				var item = _coloringBookPageRepo.GetForEdit(_coloringBookPageIds[selectedIndex]);
				if (item == null)
				{
					return;
				}
				var dialog = new ColoringBookPageDialog(item, true);
				var result = dialog.ShowDialog();
				if (result == DialogResult.OK)
				{
					_coloringBookPageRepo.Edit(dialog.Item);
					reloadColoringBookPages();
				}
			}
		}

		private void coloringBookDetailDeletePageBtn_Click(object sender, EventArgs e)
		{
			deleteColoringBookPage();
		}

		private void deleteColoringBookPage()
		{
			var selected = coloringBookDetailLv.SelectedIndices;
			if (selected.Count == 1)
			{
				var selectedIndex = selected[0];
				var item = _coloringBookPageRepo.GetForEdit(_coloringBookPageIds[selectedIndex]);
				if (item == null)
				{
					return;
				}
				var dialog = new CustomMessageBox("Warning", $"Do you really want to delete page {item.PageDescription}?");
				var result = dialog.ShowDialog();
				if (result == DialogResult.OK)
				{
					_coloringBookPageRepo.Delete(_coloringBookPageIds[selectedIndex]);
					reloadColoringBookPages();
				}
			}
		}

		private void coloringBookDetailLv_SelectedIndexChanged(object sender, EventArgs e)
		{
			setColoringBookPagesButtonStates();
		}

		private void coloringBookDetailLv_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				deleteColoringBookPage();
			}
		}
	}
}
