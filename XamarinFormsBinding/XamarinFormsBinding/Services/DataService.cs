using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamarinFormsBinding.Models;

namespace XamarinFormsBinding.Services
{
    class DataService : IDataService
    {
        private List<Quote> _quotes;

        public DataService()
        {
            _quotes = InitQuotes();
        }

        public List<Quote> GetQuotes()
        {
            return _quotes;
        }

        public async Task<List<Contact>> GetContacts()
        {
            await Task.Delay(TimeSpan.FromSeconds(5));

            return new List<Contact>
            {
                new Contact{Name="AAAA", Number="123456"},
                new Contact{Name="BBBB", Number="789456"}
            };
        }

        private List<Quote> InitQuotes()
        {
            return new List<Quote> {
                new Quote { Id = 1, CustomerName = "Xam Consulting", Total = "$350.00" },
                new Quote { Id = 2, CustomerName = "Michael Ridland", Total = "$3503.00" },
                new Quote { Id = 3, CustomerName = "Thunder Apps", Total = "$3504.00" },
            };
        }

        public async Task<bool> UpdateQuote(Quote quote)
        {
            await Task.Delay(3000);

            if(quote.Id == 0)
            {
                quote.Id = _quotes.Count + 1;

                _quotes.Add(quote);
            }
            else
            {
                var oldQuote = _quotes.Find(q => q.Id == quote.Id);

                oldQuote.CustomerName = quote.CustomerName;
                oldQuote.QuoteAmount = quote.QuoteAmount;
            }

            _quotes.Add(quote);

            return true;
        }
    }
}
