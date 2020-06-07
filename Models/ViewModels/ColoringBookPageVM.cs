﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Models.ViewModels
{
	public class ColoringBookPageVM
	{
		public int ID { get; set; }
		public int PageNumber { get; set; }
		public string PageDescription { get; set; }
		public string Note { get; set; }
		public DateTime? StartDate { get; set; }
		public DateTime? FinnishDate { get; set; }
		public List<string> ArtSuppliesUsed { get; set; }
	}
}
