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
		private int _coloringBookId;
		public ColoringBookDetail(ColoringBook coloringBook)
		{
			InitializeComponent();
			if (coloringBook == null)
			{
				throw new ArgumentNullException(nameof(coloringBook));
			}
			_coloringBookId = coloringBook.ID;
			coloringBookDetailBookNameLbl.Text = coloringBook.Name;
			coloringBookDetailBookAuthorLbl.Text = coloringBook.Author;
			Text = $"{coloringBook.Name} by {coloringBook.Author}";
		}
	}
}
