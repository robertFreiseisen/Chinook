﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Chinook.Report.Marketing.Models
{
	internal class ItemSecondary<T> : Contracts.Report.Marketing.IItemSecondary<T>
	{
		public string Name { get; set; }

		public T Secondary { get; set; }
	}
}
