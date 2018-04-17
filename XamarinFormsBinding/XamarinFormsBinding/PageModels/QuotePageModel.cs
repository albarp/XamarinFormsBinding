using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XamarinFormsBinding.Models;
using XamarinFormsBinding.Services;

namespace XamarinFormsBinding.PageModels
{
    public class QuotePageModel : FreshMvvm.FreshBasePageModel
    {
        IDataService _dataService;

        public Quote Quote { get; set; }

        public QuotePageModel(IDataService dataService)
        {
            _dataService = dataService;
        }

        public override void Init(object initData)
        {
            base.Init(initData);

            Quote = initData as Quote;

            if (Quote == null)
                Quote = new Quote();
        }

        public Command SaveQuote
        {
            get
            {
                return new Command(async () => {
                    _dataService.UpdateQuote(Quote);
                    await CoreMethods.PopPageModel();
                });
            }
        }
    }
}
