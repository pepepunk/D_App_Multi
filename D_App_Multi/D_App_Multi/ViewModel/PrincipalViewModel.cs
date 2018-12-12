using D_App_Multi.Helper;
using D_App_Multi.View;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace D_App_Multi.ViewModel
{
    class PrincipalViewModel:CarouselPage
    {
        ContentPage login;
        public PrincipalViewModel(ILoginManager ilm)
        {
            login = new Login(ilm);
            MessagingCenter.Subscribe<ContentPage>(this, "Login", (sender) =>
            {
                this.SelectedItem = login;
            });
        }
        
        public Command CerrarSesionCommand { get; set; }
        public PrincipalViewModel()
        {
            CerrarSesionCommand = new Command(async () => await LogOutAsync(), () => !IsBusy);
        }

        private async Task LogOutAsync()
        {
            IsBusy = true;
            App.Current.Logout();
            IsBusy = false;
        }
    }
}
