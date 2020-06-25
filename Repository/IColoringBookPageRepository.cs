using Eli.ColoringDiary.Models.Entities;
using Eli.ColoringDiary.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eli.ColoringDiary.Repository
{
	public interface IColoringBookPageRepository
	{
		void Add(ColoringBookPage coloringBookPage);
		void Edit(ColoringBookPage coloringBookPage);
		void Delete(int id);
		List<ColoringBookPageVM> GetAll(int coloringBookId);
		ColoringBookPage GetForAdd(int coloringBookId);
		ColoringBookPage GetForEdit(int id);
	}
}
