using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using UserInterfaceApp.Views;

namespace UserInterfaceApp
{
    class ContactListViewModel : INotifyPropertyChanged
    {


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ObservableCollection<Contact> _contact;
        public ObservableCollection<Contact> Contacts
        {
            get { return _contact; }
            set { _contact = value; OnPropertyChanged(); }
        }
        public string FirstName { get; set; }
        public string SelectedContact { get; set; }
        private bool _isBusy;
        public bool IsBusy
        {
            get { return _isBusy; }
            set { _isBusy = value; OnPropertyChanged(); }
        }

        async void ChagePageADD()
        {
            await App.Current.MainPage.Navigation.PushAsync(new AddContactPage());
        }
        async void GotoAddContact()
        {
            await App.Current.MainPage.Navigation.PushAsync(new AddContactPage());
        }
        async void GotoEdit()
        {
            await App.Current.MainPage.Navigation.PushAsync(new AddContactPage());
        }
    }  
}
