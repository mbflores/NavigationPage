using System.Collections.Generic;
using NavigationPage.Model;

namespace NavigationPage
{
	public class ActivityService
	{
		public IEnumerable<Activity> GetActivities()
		{
			return new List<Activity>
			{
				new Activity { UserId = 1, Description = "Your Facebook friend Jenny Dalby is on Instagram.", ImageUrl = "NavigationPage.Images.Slide1.JPG"},
				new Activity { UserId = 2, Description = "Jonv started following you", ImageUrl = "NavigationPage.Images.Slide2.JPG" },
				new Activity { UserId = 3, Description = "RachelMartin liked your photo.", ImageUrl = "NavigationPage.Images.Slide3.JPG" },
				new Activity { UserId = 4, Description = "Your Facebook friend Nivan Jay is on Instagram.", ImageUrl = "NavigationPage.Images.Slide4.JPG" },
				new Activity { UserId = 5, Description = "SanazZ sent a photo posted by @brookeisep.", ImageUrl = "NavigationPage.Images.Slide5.JPG" },
				new Activity { UserId = 6, Description = "NextLab started following you.", ImageUrl = "NavigationPage.Images.Slide6.JPG" },
				new Activity { UserId = 7, Description = "Your Facebook friend Alex B is on Instagram.", ImageUrl = "NavigationPage.Images.Slide7.JPG" },
				new Activity { UserId = 8, Description = "Your Facebook friend Tara Chang is on Instagram." , ImageUrl = "NavigationPage.Images.Slide8.JPG" },
				new Activity { UserId = 9, Description = "Your Facebook friend Tom K is on Instagram.", ImageUrl = "NavigationPage.Images.Slide9.JPG" },
			};
		}
	}
}
