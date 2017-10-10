using System;
namespace MasterDetailDemo
{
	public class MasterPageItem
	{
		public string Title{get; set;}
		public string IconSource {get; set;}
		public Type TargetType {get; set;}

		public MasterPageItem()
		{
			Title = "";
			IconSource = "";
			TargetType = null;
		}
	}
}
