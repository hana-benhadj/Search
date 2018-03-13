using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Search
{
	public partial class MainPage : ContentPage
	{
        List<ShopList> L;

        public MainPage()
		{
			InitializeComponent();
            L = new List<ShopList>
            {
               new ShopList { Title = "Gucci Hand Bag", Type="Almost new", Price ="30000", Image ="sac11.png" },
               new ShopList {Title ="Mango Hand Bag", Type="Almost new", Price ="30000" ,Image ="sac22.png" },
               new ShopList {Title ="Guess Hand Bag", Type="Almost new", Price ="30000",Image ="sac33.png"},
            };
            ListViewSearch.ItemsSource = L;


        }
       
        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            //thats all you need to make a search 
            
            if (string.IsNullOrEmpty(e.NewTextValue))
            {
                ListViewSearch.ItemsSource = L;
            }

            else
            {
                ListViewSearch.ItemsSource = L.Where(x => x.Title.ToLower().StartsWith(e.NewTextValue.ToLower()));
            }
        }
    }
}
