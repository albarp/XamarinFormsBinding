using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace XamarinFormsBinding.Models
{
    public class Contact : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Name { get; set; }


        public string Number { get; set; }

    }
}
