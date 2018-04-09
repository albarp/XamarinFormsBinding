using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using Xamarin.Forms;
using XamarinFormsBinding.Models;
using XamarinFormsBinding.Services;

namespace XamarinFormsBinding.PageModels
{
    public class QuoteListPageModel : FreshMvvm.FreshBasePageModel
    {
        private IDataService _databaseService;

        public QuoteListPageModel(IDataService databaseService)
        {
            _databaseService = databaseService;
        }

        public ObservableCollection<Quote> Quotes { get; set; }

        public override void Init(object initData)
        {
            Quotes = new ObservableCollection<Quote>(_databaseService.GetQuotes());
        }

        protected override void ViewIsAppearing(object sender, EventArgs e)
        {
            Debug.WriteLine("View is appearing");
            base.ViewIsAppearing(sender, e);
        }

        protected override void ViewIsDisappearing(object sender, EventArgs e)
        {
            base.ViewIsDisappearing(sender, e);
        }

        public override void ReverseInit(object returnedData)
        {
            var newQuote = returnedData as Quote;
            if (!Quotes.Contains(newQuote))
            {
                Quotes.Add(newQuote);
            }
        }

        public Command AddQuote
        {
            get
            {
                return new Command(async () => {
                    await CoreMethods.PushPageModel<QuotePageModel>();
                });
            }
        }

    }
}
