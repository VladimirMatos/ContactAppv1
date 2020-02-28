using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace UserInterfaceApp
{
    public class AddContactViewModel : INotifyPropertyChanged
    {
        private Contact _contact;
        public Contact Contact 
        { 
            get { return _contact; }
            set { _contact = value; OnPropertyChanged(); } 
        }

        public AddContactViewModel()
        {
            Contact = new Contact();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
