using Models.Entities;
using Models.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Eli.ColoringDiary.Repository
{
	public class ArtSupplyFileRepository : IArtSupplyRepository
	{
		private string _fileName;

		public ArtSupplyFileRepository(string fileName)
		{
			if (fileName == null)
			{
				throw new ArgumentNullException(nameof(fileName));
			}
			_fileName = fileName;
		}

		public void Add(ArtSupply artSupply)
		{
			if (artSupply == null)
			{
				throw new ArgumentNullException(nameof(artSupply));
			}
			var items = readFromFile();
			artSupply.ID = getNewId(items);
			items.Add(artSupply);
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

		public void Edit(ArtSupply artSupply)
		{
			var items = readFromFile();
			var item = getItemById(items, artSupply.ID);
			if (item != null)
			{
				item.Name = artSupply.Name;
				item.Brand = artSupply.Brand;
				item.Type = artSupply.Type;
				saveToFile(items);
			}
		}


		public List<ArtSupplyVM> GetAll()
		{
			var items = readFromFileOrdered();
			var result = new List<ArtSupplyVM>();
			foreach (var item in items)
			{
				var artSupply = new ArtSupplyVM
				{
					ID = item.ID,
					Name = item.Name,
					Brand = item.Brand,
					Type = item.Type,
				};
				result.Add(artSupply);
			}
			return result;
		}

		public ArtSupply GetForAdd()
		{
			return new ArtSupply();
		}

		public ArtSupply GetForEdit(int id)
		{
			var items = readFromFile();
			return getItemById(items, id);
		}

		public List<string> GetAllTypes()
		{
			var items = readFromFile();
			var set = new HashSet<string>();
			var result = new List<string>();
			foreach (var item in items)
			{
				if (!set.Contains(item.Type))
				{
					set.Add(item.Type);
					result.Add(item.Type);
				}
			}
			var defaults = new List<string> 
			{   
				"Pencils",
				"Watercolor pencils",
				"Watercolors",
				"Watercolor markers",
				"Markers",
				"Fineliners",
				"Crayons",
				"Gel pens",
				
			};
			foreach (var item in defaults)
			{
				if (!set.Contains(item))
				{
					set.Add(item);
					result.Add(item);
				}
			}
			result.Sort();
			return result;
		}

		private List<ArtSupply> readFromFileOrdered()
		{
			var items = readFromFile();
			return items.OrderBy(c => c.Type).ThenBy(c => c.Name).ThenBy(c => c.ID).ToList();
		}
		private List<ArtSupply> readFromFile()
		{
			//TODO toto Eli ještě neviděla
			using (var sr = new StreamReader(_fileName))
			{
				return JsonConvert.DeserializeObject<List<ArtSupply>>(sr.ReadToEnd());
			}
		}

		private void saveToFile(List<ArtSupply> items)
		{
			//TODO toto Eli ještě neviděla
			using (var sw = new StreamWriter(_fileName))
			{
				sw.Write(JsonConvert.SerializeObject(items));
			}
		}

		private int getNewId(List<ArtSupply> items)
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
		private int? getPositionById(List<ArtSupply> items, int id)
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
		
		private ArtSupply getItemById(List<ArtSupply> items, int id)
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
