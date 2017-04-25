using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MDT17AppForms
{
    public static class MyViewModelLocator
    {
        static MyDataViewModel _model;
        public static MyDataViewModel MyDataVM => _model ?? (_model = new MyDataViewModel());
    }


	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            MainPage = new MasterDetailPage
            {
                Detail = new MainPage { Title = "Main Page" },
                Master = new MyMenu { Title = "Menu"}
            };

			//MainPage = new MDT17AppForms.MainPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
