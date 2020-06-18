using System;
using System.Collections.Generic;
using System.Text;

namespace Eli.ColoringDiary.Models.ViewModels
{
	public class WIPVM
	{
		public ColoringBookVM Book { get; set; }
		public int PageID { get; set; }
		public int PageNumber { get; set; }
		public string PageDescription { get; set; }
		public DateTime StartDate { get; set; }
		public string Note { get; set; }
	}
}
