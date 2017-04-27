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

        private void Button_Clicked(object sender, EventArgs e)
        {
            txtResult.Text = $"I've been clicked {nCount++} times";

            MyViewModelLocator.MyDataVM.Items.Add(new Event { Name = txtName.Text });

            int i = 0;
            int crashme = 4 / i;
            i--;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var myEvent = e.SelectedItem as Event;

            Navigation.PushModalAsync(new ItemDetail(myEvent));
        }
    }
}
