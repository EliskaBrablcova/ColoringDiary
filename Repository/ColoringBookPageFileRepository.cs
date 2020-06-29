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
	public class ColoringBookPageFileRepository : IColoringBookPageRepository
	{
		private string _fileName;
		private IArtSupplyRepository _artSupplyRepo;

		public ColoringBookPageFileRepository(string fileName, IArtSupplyRepository artSupplyRepo)
		{
			if (fileName == null)
			{
				throw new ArgumentNullException(nameof(fileName));
			}
			_fileName = fileName;

			if (artSupplyRepo == null)
			{
				throw new ArgumentNullException(nameof(artSupplyRepo));
			}
			_artSupplyRepo = artSupplyRepo;
		}

		public void Add(ColoringBookPage coloringBookPage)
		{
			if (coloringBookPage == null)
			{
				throw new ArgumentNullException(nameof(coloringBookPage));
			}
			var items = readFromFile();
			coloringBookPage.ID = getNewId(items);
			items.Add(coloringBookPage);
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

		public void Edit(ColoringBookPage coloringBookPage)
		{
			var items = readFromFile();
			var item = getItemById(items, coloringBookPage.ID);
			if (item != null)
			{
				item.PageNumber = coloringBookPage.PageNumber;
				item.PageDescription = coloringBookPage.PageDescription;
				item.Note = coloringBookPage.Note;
				item.StartDate = coloringBookPage.StartDate;
				item.FinishDate = coloringBookPage.FinishDate;
				item.ArtSuppliesUsed = coloringBookPage.ArtSuppliesUsed;
				saveToFile(items);
			}
		}

		public List<ColoringBookPageVM> GetAll(int coloringBookId)
		{
			var items = readFromFileOrdered();
			var result = new List<ColoringBookPageVM>();
			foreach (var item in items)
			{
				if (item.BookID != coloringBookId)
				{
					continue;
				}
				var coloringBookPage = new ColoringBookPageVM
				{
					ID = item.ID,
					PageNumber = item.PageNumber,
					PageDescription = item.PageDescription,
					Note = item.Note,
					StartDate = item.StartDate,
					FinishDate = item.FinishDate,
					ArtSuppliesUsed = getArtSuppliesNames(item.ArtSuppliesUsed),

				};
				result.Add(coloringBookPage);
			}
			return result;
		}

		private List<string> getArtSuppliesNames(List<int> artSuppliesUsed)
		{
			var names = new List<string>();
			foreach (var artSupply in _artSupplyRepo.Get(artSuppliesUsed))
			{
				names.Add(artSupply.Name);
			}
			names.Sort();
			return names;
		}

		public ColoringBookPage GetForAdd(int coloringBookId)
		{
			var coloringBookPage = new ColoringBookPage();
			coloringBookPage.BookID = coloringBookId;
			coloringBookPage.PageNumber = getNewPageNbr(coloringBookId);
			return coloringBookPage;
		}

		private int getNewPageNbr(int coloringBookId)
		{
			var pageNbr = 0;
			foreach (var page in readFromFile())
			{
				if (page.BookID == coloringBookId && page.PageNumber > pageNbr)
				{
					pageNbr = page.PageNumber;
				}
			}
			return pageNbr + 1;
		}

		public ColoringBookPage GetForEdit(int id)
		{
			var items = readFromFile();
			return getItemById(items, id);
		}

		public bool HasPages(int coloringBookId)
		{
			var items = readFromFile();
			foreach (var page in items)
			{
				if (page.BookID == coloringBookId)
				{
					return true;
				}
			}
			return false;
		}

		public void DeleteAllPages(int coloringBookId)
		{
			var oldItems = readFromFile();
			var newItems = new List<ColoringBookPage>(oldItems.Count);
			foreach (var page in oldItems)
			{
				if (page.BookID != coloringBookId)
				{
					newItems.Add(page);
				}
			}
			saveToFile(newItems);
		}

		private List<ColoringBookPage> readFromFile()
		{
			ensureCreated();
			using (var sr = new StreamReader(_fileName))
			{
				return JsonConvert.DeserializeObject<List<ColoringBookPage>>(sr.ReadToEnd());
			}
		}

		private List<ColoringBookPage> readFromFileOrdered()
		{
			var items = readFromFile();
			return items.OrderBy(c => c.PageNumber).ThenBy(c => c.ID).ToList();
		}

		private void ensureCreated()
		{
			if (!File.Exists(_fileName))
			{
				saveToFile(new List<ColoringBookPage>());
			}
		}

		private void saveToFile(List<ColoringBookPage> items)
		{
			using (var sw = new StreamWriter(_fileName))
			{
				sw.Write(JsonConvert.SerializeObject(items));
			}
		}

		private int getNewId(List<ColoringBookPage> items)
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

		private int? getPositionById(List<ColoringBookPage> items, int id)
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

		private ColoringBookPage getItemById(List<ColoringBookPage> items, int id)
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
