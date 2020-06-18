using System;
using System.Collections.Generic;
using System.Text;

namespace Eli.ColoringDiary.Models.ViewModels
{
	public class ColoringBookDetailVM
	{
		public ColoringBookVM Book { get; set; }
		public List<ColoringBookPageVM> Pages { get; set; }
	}
}
