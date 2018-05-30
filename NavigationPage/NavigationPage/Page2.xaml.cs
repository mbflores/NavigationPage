using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NavigationPage.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavigationPage
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page2 : ContentPage
	{
		public Page2 (User user=null)
		{
			InitializeComponent ();
		    if (user == null)
		    {
		        throw new ArgumentNullException();
		    }

		    BindingContext = user;
		}
	}
}