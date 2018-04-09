using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace XamarinFormsBinding.Models
{
    public class Quote : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string CustomerName { get; set; }

        public int QuoteAmount { get; set; }
        public int Id { get; internal set; }
        public string Total { get; internal set; }
    }
}
