using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UserInterfaceApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddContactPage : ContentPage
    {
        public AddContactPage(Contact contact = null)
        {
            InitializeComponent();

            BindingContext = new AddContactViewModel();

            if (contact != null)
            {
                ((AddContactViewModel)BindingContext).Contact = contact;

            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Contact contact = ((AddContactViewModel)BindingContext).Contact;

            MessagingCenter.Send(this, "AddContactPage", contact);
            
            Navigation.PopAsync();
        }
    }
}