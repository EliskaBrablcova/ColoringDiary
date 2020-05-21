using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Entities
{
	public class WIP
	{
		public int ID { get; set; }
		public string BookName { get; set; }
		public string Author { get; set; }
		public int PageNumber { get; set; }
		public string PageDescription { get; set; }
		public DateTime StartDate { get; set; }
		public string Note { get; set; }
	}
}
