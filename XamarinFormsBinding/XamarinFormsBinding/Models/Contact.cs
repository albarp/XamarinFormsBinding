using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace XamarinFormsBinding.Models
{
    public class Contact : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Name { get; set; }

        public int Id { get; internal set; }

        public string Phone { get; internal set; }
    }
}
