using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace XamarinFormsBinding.PlainMVVMViewModel
{
    public class QuoteViewModel : INotifyPropertyChanged
    {
        private string _quoteName;
        public string QuoteName
        {
            get { return _quoteName; }
            set
            {
                _quoteName = value;
                NotifyPropertyChanged();
            }
        }

        public QuoteViewModel()
        {
            QuoteName = "First quote";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
           
        public Command ResetQuoteName
        {
            get
            {
                return new Command( () => {
                    QuoteName = "First quote";
                });
            }
        }
    }
}
