using D_App_Multi;
using D_App_Multi.Helper;
using D_App_Multi.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace D_App_Multi
{
    public partial class App : Application, ILoginManager
    {
        public static App Current;
        public static int val;
        public App()
        {
            InitializeComponent();
            Current = this;
            var isLoggedIn = Properties.ContainsKey("IsLoggedIn") ? (bool)Properties["IsLoggedIn"] : false;
            if (isLoggedIn)
            {
                MainPage = new PrincipalView();
            }
            else
            {
                MainPage = new Login(this);
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        public void ShowMainPage()
        {
            MainPage = new PrincipalView();
        }

        public void Logout()
        {
            Properties["IsLoggedIn"] = false;
            MainPage = new Login(this);
        }
    }
}
