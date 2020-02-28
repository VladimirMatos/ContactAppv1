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
    public partial class ContactViewPage : ContentPage
    {
        public ContactViewPage(Contact contact = null)
        {
            InitializeComponent();
            BindingContext = new ContactDetailViewModel();
            if (contact != null)
                ((ContactDetailViewModel)BindingContext).Contact = contact;
        }
    }
}