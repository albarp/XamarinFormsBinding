using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamarinFormsBinding.Models;

namespace XamarinFormsBinding.Services
{
    public interface IDataService
    {
        Task<List<Contact>> GetContacts();
    }
}
