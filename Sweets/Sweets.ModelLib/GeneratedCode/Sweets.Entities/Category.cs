﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Sweets.Entities
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	public class Category
	{
		public virtual int ID
		{
			get;
			set;
		}

		public virtual string CategoryName
		{
			get;
			set;
		}

		public virtual DateTime DateOfChange
		{
			get;
			set;
		}

		public virtual ICollection<Product> Products
		{
			get;
			set;
		}

	}
}
