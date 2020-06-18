using Eli.ColoringDiary.Models.Entities;
using Eli.ColoringDiary.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eli.ColoringDiary.Repository
{
	public interface IColoringBookRepository
	{
		void Add(ColoringBook coloringBook);
		void Edit(ColoringBook coloringBook);
		void Delete(int id);
		List<ColoringBookVM> GetAll();
		ColoringBook GetForAdd();
		ColoringBook GetForEdit(int id);
	}
}
