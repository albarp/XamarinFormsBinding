using System;
using System.Collections.Generic;
using System.Text;
using XamarinFormsBinding.Models;

namespace XamarinFormsBinding.PageModels
{
    public class ContactListPageModel : FreshMvvm.FreshBasePageModel
    {
        public List<Contact> ContactList { get; set; }

        public ContactListPageModel()
        {

        }

        public override void Init(object initData)
        {
            base.Init(initData);

            ContactList = new List<Contact>
            {
                new Contact{Name="AAAA", Number="123456"},
                new Contact{Name="BBBB", Number="789456"}
            };
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
