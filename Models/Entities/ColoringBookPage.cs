using System;
using System.Collections.Generic;
using System.Text;

namespace Eli.ColoringDiary.Models.Entities
{
	public class ColoringBookPage
	{
		public int ID { get; set; }
		public int BookID { get; set; }
		public int PageNumber { get; set; }
		public string PageDescription { get; set; }
		public string Note { get; set; }
		public DateTime? StartDate { get; set; }
		public DateTime? FinishDate { get; set; }
		public List<int> ArtSuppliesUsed { get; set; }

	}
}
