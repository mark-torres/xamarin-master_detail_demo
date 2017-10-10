using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MasterDetailDemo
{
	public partial class MainPage : MasterDetailPage
	{
		public MainPage()
		{
			InitializeComponent();
			sideMenuPage.ListMasterItems.ItemSelected += OnItemSelected;
		}

		void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var item = e.SelectedItem as MasterPageItem;
			if (item != null) {
				Detail = new NavigationPage( (Page)Activator.CreateInstance(item.TargetType) );
				// remove item selection
				sideMenuPage.ListMasterItems.SelectedItem = null;
				// This property controls whether the master or detail page is presented.
				// It should be set to true to display the master page, and to false to display the detail page.
				IsPresented = false;
			}
		}
	}
}
