using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MasterDetailDemo
{
	public partial class SideMenuPage : ContentPage
	{
		public ListView ListMasterItems {get {return listMasterItems;}}

		public SideMenuPage()
		{
			InitializeComponent();

			// populate the items
			var masterPageItems = new List<MasterPageItem>();
			masterPageItems.Add(new MasterPageItem{
				Title = "Home",
				IconSource = "ic_home_black.png",
				TargetType = typeof(HomePage)
			});
			masterPageItems.Add(new MasterPageItem{
				Title = "Settings",
				IconSource = "ic_settings_black.png",
				TargetType = typeof(SettingsPage)
			});

			listMasterItems.ItemsSource = masterPageItems;
		}
	}
}
