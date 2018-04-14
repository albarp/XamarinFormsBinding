using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinFormsBinding.Pages
{
    public class BasePage : ContentPage
    {
        public BasePage()
        {
            ToolbarItems.Add(new ToolbarItem("", "Home.png", () => {
                //Application.Current.MainPage = new NavigationPage(new LaunchPage)
            }));
        }
    }
}
