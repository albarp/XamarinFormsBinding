using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamarinFormsBinding.Models;

namespace XamarinFormsBinding.Services
{
    class DataService : IDataService
    {
        public async Task<List<Contact>> GetContacts()
        {
            await Task.Delay(TimeSpan.FromSeconds(5));

            return new List<Contact>
            {
                new Contact{Name="AAAA", Number="123456"},
                new Contact{Name="BBBB", Number="789456"}
            };
        }
    }
}
