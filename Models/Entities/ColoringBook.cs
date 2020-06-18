using System;
using System.Collections.Generic;
using System.Text;

namespace Eli.ColoringDiary.Models.Entities
{
	public class ColoringBook
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public string Author { get; set; }
		public int TotalPages { get; set; }
	}
}
