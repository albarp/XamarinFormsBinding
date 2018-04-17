using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinFormsBinding
{
    public class LaunchPage : ContentPage
    {
        public LaunchPage(App app)
        {
            Title = "Select Sample";
            var list = new ListView();
            list.ItemsSource = new List<string>
            {
                "Basic Navigation",
                "Master Detail",
                "Tabbed Navigation",
                "Custom Navigation",
                "Tabbed (FO) Navigation",
                "Multiple Navigation"
            };

            list.ItemTapped += (object sender, ItemTappedEventArgs e) => {
                if ((String)e.Item == "Basic Navigation")
                    app.LoadBasicNav();
            };

            this.Content = list;
        }
    }
}
