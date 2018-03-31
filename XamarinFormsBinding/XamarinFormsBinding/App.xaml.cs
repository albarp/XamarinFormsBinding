using Xamarin.Forms;
using XamarinFormsBinding.PageModels;

using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace XamarinFormsBinding
{
	public partial class App : Application
	{
		public App ()
		{
            AppCenter.Start("android=944f3bf7-bf13-4adc-b420-c91b11d93be3;" +
                  "uwp={Your UWP App secret here};" +
                  "ios={Your iOS App secret here}",
                  typeof(Analytics), typeof(Crashes));

            InitializeComponent();

            // FreshMvvmBinding
            var contactList = FreshMvvm.FreshPageModelResolver.ResolvePageModel<ContactListPageModel>();

            var navContainer = new FreshMvvm.FreshNavigationContainer(contactList);

            MainPage = navContainer;
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
