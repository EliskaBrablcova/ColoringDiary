using System;
using System.Collections.Generic;
using System.Text;

namespace Eli.ColoringDiary.Models.ViewModels
{
	public class TaskVM
	{
		public int ID { get; set; }
		public string Type { get; set; }
		public bool Completed { get; set; }
		public string Text { get; set; }
	}
}
