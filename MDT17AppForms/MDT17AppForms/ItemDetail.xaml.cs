using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MDT17AppForms
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ItemDetail : ContentPage
	{
        public ItemDetail()
        {
            InitializeComponent();
        }
		public ItemDetail (Event myData)
		{
			InitializeComponent ();
            BindingContext = myData;
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
     
            await MyViewModelLocator.MyDataVM.UpdateItem(BindingContext as Event);

            await Navigation.PopModalAsync();
        }
    }
}
