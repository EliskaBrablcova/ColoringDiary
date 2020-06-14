﻿using Models.Entities;
using Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Eli.ColoringDiary.Repository
{
	public interface IArtSupplyRepository
	{
		void Add(ArtSupply artSupply);
		void Edit(ArtSupply artSupply);
		void Delete(int id);
		List<ArtSupplyVM> GetAll();
		ArtSupply GetForAdd();
		ArtSupply GetForEdit(int id);
		List<string> GetAllTypes();
	}
}
