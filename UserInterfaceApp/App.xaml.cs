using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using UserInterfaceApp.Views;

namespace UserInterfaceApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new NavigationPage(new ContactListPage());
        }
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
