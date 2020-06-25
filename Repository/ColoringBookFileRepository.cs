using Eli.ColoringDiary.Models.Entities;
using Eli.ColoringDiary.Models.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Eli.ColoringDiary.Repository
{
	public class ColoringBookFileRepository : IColoringBookRepository
	{
		private string _fileName;

		public ColoringBookFileRepository(string fileName)
		{
			if (fileName == null)
			{
				throw new ArgumentNullException(nameof(fileName));
			}
			_fileName = fileName;
		}

		public void Add(ColoringBook coloringBook)
		{
			if (coloringBook == null)
			{
				throw new ArgumentNullException(nameof(coloringBook));
			}
			var items = readFromFile();
			coloringBook.ID = getNewId(items);
			items.Add(coloringBook);
			saveToFile(items);
		}

		public void Delete(int id)
		{
			var items = readFromFile();
			var position = getPositionById(items, id);
			if (position != null)
			{
				items.RemoveAt(position.Value);
				saveToFile(items);
			}
		}

		public void Edit(ColoringBook coloringBook)
		{
			var items = readFromFile();
			var item = getItemById(items, coloringBook.ID);
			if (item != null)
			{
				item.Name = coloringBook.Name;
				item.Author = coloringBook.Author;
				item.TotalPages = coloringBook.TotalPages;
				saveToFile(items);
			}
		}


		public List<ColoringBookVM> GetAll()
		{
			var items = readFromFileOrdered();
			var result = new List<ColoringBookVM>();
			foreach (var item in items)
			{
				var coloringBook = new ColoringBookVM
				{
					ID = item.ID,
					Name = item.Name,
					Author = item.Author,
					TotalPages = item.TotalPages,
					TotalPagesColored = 0, //todo

				};
				result.Add(coloringBook);
			}
			return result;
		}

		public ColoringBook GetForAdd()
		{
			return new ColoringBook();
		}

		public ColoringBook GetForEdit(int id)
		{
			var items = readFromFile();
			return getItemById(items, id);
		}

		private List<ColoringBook> readFromFileOrdered()
		{
			var items = readFromFile();
			return items.OrderBy(c => c.Name).ThenBy(c => c.Author).ThenBy(c => c.ID).ToList();
		}
		private List<ColoringBook> readFromFile()
		{
			//TODO toto Eli ještě neviděla
			ensureCreated();
			using (var sr = new StreamReader(_fileName))
			{
				return JsonConvert.DeserializeObject<List<ColoringBook>>(sr.ReadToEnd());
			}
		}

		private void ensureCreated()
		{
			if (!File.Exists(_fileName))
			{
				saveToFile(new List<ColoringBook>());
			}
		}

		private void saveToFile(List<ColoringBook> items)
		{
			//TODO toto Eli ještě neviděla
			using (var sw = new StreamWriter(_fileName))
			{
				sw.Write(JsonConvert.SerializeObject(items));
			}
		}

		private int getNewId(List<ColoringBook> items)
		{
			var id = 0;
			foreach (var item in items)
			{
				if (item.ID > id)
				{
					id = item.ID;
				}
			}
			return id + 1;
		}
		private int? getPositionById(List<ColoringBook> items, int id)
		{
			for (int i = 0; i < items.Count; i++)
			{
				var item = items[i];
				if (item.ID == id)
				{
					return i;
				}
			}
			return null;
		}
		
		private ColoringBook getItemById(List<ColoringBook> items, int id)
		{
			var position = getPositionById(items, id);
			if (position == null)
			{
				return null;
			}
			return items[position.Value];
		}

	}
}
