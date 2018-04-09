using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinFormsBinding.PageModels
{
    public class MenuPageModel : FreshMvvm.FreshBasePageModel
    {
        public List<string> MenuItems { get; set; }

        public MenuPageModel()
        {

        }

        public override void Init(object initData)
        {
            base.Init(initData);

            MenuItems = new List<string>
            {
                "Quotes", "Contancts"
            };
        }

        public Command ShowQuotes
        {
            get
            {
                return new Command(async () =>
                {
                    await CoreMethods.PushPageModel<QuoteListPageModel>();
                });
            }
        }
    }
}
