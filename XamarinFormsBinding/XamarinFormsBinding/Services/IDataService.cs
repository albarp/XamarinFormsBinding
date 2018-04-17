using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamarinFormsBinding.Models;

namespace XamarinFormsBinding.Services
{
    public interface IDataService
    {
        List<Contact> GetContacts();

        List<Quote> GetQuotes();

        void UpdateQuote(Quote quote);
    }
}
