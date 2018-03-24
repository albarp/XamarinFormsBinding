using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace XamarinFormsBinding.Models
{
    public class Contact : INotifyPropertyChanged
    {
        private string _name = string.Empty;
        public string Name {
            get
            {
                return _name;
            }
            set
            {
                if(value != _name)
                {
                    _name = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string _number = string.Empty;
        public string Number
        {
            get
            {
                return _number;
            }
            set
            {
                if (value != _number)
                {
                    _number = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        // This method is called by the Set accessor of each property.
        // The CallerMemberName attribute that is applied to the optional propertyName
        // parameter causes the property name of the caller to be substituted as an argument.
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
