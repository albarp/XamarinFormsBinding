using Acr.UserDialogs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamarinFormsBinding.Models;
using XamarinFormsBinding.Services;

namespace XamarinFormsBinding.PageModels
{
    public class ContactListPageModel : FreshMvvm.FreshBasePageModel
    {
        public List<Contact> ContactList { get; set; }

        private IDataService _dataService;
        private IUserDialogs _userDialogs;

        public ContactListPageModel(IDataService dataService, IUserDialogs userDialogs)
        {
            _dataService = dataService;
            _userDialogs = userDialogs;
        }

        public override void Init(object initData)
        {
            base.Init(initData);

            _userDialogs.ShowLoading();

            ContactList = _dataService.GetContacts();

            _userDialogs.HideLoading();
        }

        public Contact SelectedContact
        {
            get { return null; }
            set
            {
                CoreMethods.PushPageModel<ContactPageModel>(value);
                RaisePropertyChanged();
            }
        }
    }
}
