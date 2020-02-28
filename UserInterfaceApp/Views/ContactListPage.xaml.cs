using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterfaceApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UserInterfaceApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactListPage : ContentPage
    {
        public ContactListPage()
        {
            InitializeComponent();
        }

        
        private void TapGestureRecognizer_Tapped_Edit(object sender, EventArgs e)
        {
            TappedEventArgs tappedEventArgs = (TappedEventArgs)e;
            Contact contact = ((ContactListViewModel)BindingContext).Contacts.Where(emp => emp.Phone == (int)tappedEventArgs.Parameter).FirstOrDefault();

            Navigation.PushAsync(new AddContactPage(contact));
        }

        private void TapGestureRecognizer_Tapped_Remove(object sender, EventArgs e)
        {
            TappedEventArgs tappedEventArgs = (TappedEventArgs)e;
            Contact contact = ((ContactListViewModel)BindingContext).Contacts.Where(emp => emp.Phone == (int)tappedEventArgs.Parameter).FirstOrDefault();

            ((ContactListViewModel)BindingContext).Contacts.Remove(contact);
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Navigation.PushAsync(new ContactViewPage((Contact)e.SelectedItem));
        }

    }
}