using Xamarin.Forms;
using XamarinFormsBinding.PageModels;

using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using XamarinFormsBinding.Features;
using XamarinFormsBinding.FeaturesManager;
using XamarinFormsBinding.PlainMVVMViewModel;

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

            FeatureToggleRegistry.Add<PlainMVVMFeature>(false);


            if (Feature.IsEnabled<PlainMVVMFeature>())
            {
                var quoteViewModel = new QuoteViewModel();

                var entry = new Entry();
                // Con OneWayToSource, è la entry che spedisce il suo valore al modello che a sua volta aggiorna la QuoteView
                entry.SetBinding(Entry.TextProperty, "QuoteName", BindingMode.OneWayToSource); 
                entry.HorizontalOptions = LayoutOptions.FillAndExpand;

                var button = new Button();
                button.Text = "Reset Text";
                button.SetBinding(Button.CommandProperty, "ResetQuoteName");

                MainPage = new ContentPage {
                    Content  = new StackLayout{
                        VerticalOptions = LayoutOptions.Center,
                        Children = {
                            entry,
                            new QuoteView(),
                            button
                        }
                    },
                    BindingContext = quoteViewModel
                };
            }
            else
            {
                // FreshMvvmBinding
                var contactList = FreshMvvm.FreshPageModelResolver.ResolvePageModel<ContactListPageModel>();

                var navContainer = new FreshMvvm.FreshNavigationContainer(contactList);

                MainPage = navContainer;
            }
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
