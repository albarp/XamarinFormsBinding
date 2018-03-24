using System;
using System.Collections.Generic;
using System.Text;
using XamarinFormsBinding.Models;

namespace XamarinFormsBinding.PageModels
{
    public class ContactPageModel : FreshMvvm.FreshBasePageModel
    {
        public Contact Contact { get; set; }

        public override void Init(object initData)
        {
            base.Init(initData);

            Contact = (Contact)initData;
        }
    }
}
