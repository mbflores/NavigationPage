
using NavigationPage.Model;
using Xamarin.Forms;

namespace NavigationPage
{
    public partial class MainPage : TabbedPage
	{
		public MainPage()
		{
			InitializeComponent();
            ActivityService services = new ActivityService();
           
            
		    lstViews.ItemsSource = services.GetActivities();
            
		}

	    private void LstView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
	    {
	        var selected = (Activity) e.SelectedItem;
	        var user = new UserService();
	        var selectedUser = user.GetUser(selected.UserId);
	        Navigation.PushAsync(new Page2(selectedUser));
	    }
	}
}
