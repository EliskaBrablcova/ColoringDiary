using System;
using System.Collections.Generic;
using System.Text;

namespace Eli.ColoringDiary.Models.Entities
{
	public class Task
	{
		public int ID { get; set; }
		public string Type { get; set; }
		public bool Completed { get; set; }
		public string Text { get; set; }
	}
}
