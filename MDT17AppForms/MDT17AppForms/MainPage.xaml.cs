using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MDT17AppForms
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            //BindingContext = new MyDataViewModel();
		}

        public int nCount { get; set; }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                //if (MyViewModelLocator.MyDataVM.MobileClient.CurrentUser == null)
                //{
                //    var token = new JObject();
                //    // Replace access_token_value with actual value of your access token obtained
                //    // using the Facebook or Google SDK.
                //    token.Add("access_token", "");
                //    token.Add("access_token_secret", "");

                //    var user = await MyViewModelLocator.MyDataVM.MobileClient.LoginAsync(Microsoft.WindowsAzure.MobileServices.MobileServiceAuthenticationProvider.Twitter, token);
                //}

                txtResult.Text = $"I've been clicked {nCount++} times";

                var myEvent = new Event { Name = txtName.Text };
                // await MyViewModelLocator.MyDataVM.InsertItem(myEvent);
                await Navigation.PushModalAsync(new ItemDetail(myEvent));

            }
            catch (Exception ex)
            {
                var msg = ex;
                //throw;
            }
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var myEvent = e.SelectedItem as Event;

            Navigation.PushModalAsync(new ItemDetail(myEvent));
        }
    }
}
