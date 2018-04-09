using Xamarin.Forms;
using XamarinFormsBinding.PageModels;

using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using XamarinFormsBinding.Features;
using XamarinFormsBinding.FeaturesManager;
using XamarinFormsBinding.PlainMVVMViewModel;
using XamarinFormsBinding.Services;
using Acr.UserDialogs;

namespace XamarinFormsBinding
{
	public partial class App : Application
	{
        private void SetupIOC()
        {
            FreshMvvm.FreshIOC.Container.Register<IDataService, DataService>();
            FreshMvvm.FreshIOC.Container.Register(UserDialogs.Instance);
        }

		public App ()
		{
            AppCenter.Start("android=944f3bf7-bf13-4adc-b420-c91b11d93be3;" +
                  "uwp={Your UWP App secret here};" +
                  "ios={Your iOS App secret here}",
                  typeof(Analytics), typeof(Crashes));

            SetupIOC();

            InitializeComponent();

            FeatureToggleRegistry.Add<PlainMVVMFeature>(false);
            FeatureToggleRegistry.Add<SingleNavFeature>(true);



            if (Feature.IsEnabled<PlainMVVMFeature>())
            {
                SetupPlainMVVM();
            }
            else if(Feature.IsEnabled<SingleNavFeature>())
            {
                SetupSingleNav();
            }
        }

        private void SetupSingleNav()
        {
            // FreshMvvmBinding
            //var contactList = FreshMvvm.FreshPageModelResolver.ResolvePageModel<ContactListPageModel>();

            //var navContainer = new FreshMvvm.FreshNavigationContainer(contactList);

            //MainPage = navContainer;

            var mainMenu = FreshMvvm.FreshPageModelResolver.ResolvePageModel<MenuPageModel>();

            var navContainer = new FreshMvvm.FreshNavigationContainer(mainMenu);

            MainPage = navContainer;
        }

        private void SetupPlainMVVM()
        {
            var quoteViewModel = new QuoteViewModel();

            var entry = new Entry();
            // Con OneWayToSource, è la entry che spedisce il suo valore al modello che a sua volta aggiorna la QuoteView
            entry.SetBinding(Entry.TextProperty, "QuoteName", BindingMode.OneWayToSource);
            entry.HorizontalOptions = LayoutOptions.FillAndExpand;

            var button = new Button();
            button.Text = "Reset Text";
            button.SetBinding(Button.CommandProperty, "ResetQuoteName");

            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
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
