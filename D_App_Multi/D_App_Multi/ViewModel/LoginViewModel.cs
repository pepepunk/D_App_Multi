using D_App_Multi.Helper;
using D_App_Multi.Model;
using D_App_Multi.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace D_App_Multi.ViewModel
{
    public class LoginViewModel:PropertyChangedService
    {
        public string email { get; set; }
        public string password { get; set; }
        
        public Command IniciarSesionCommand { get; set; }

        FirebaseConfig config = new FirebaseConfig();
        ILoginManager iml = null;
        public LoginViewModel(ILoginManager ilm)
        {
            iml = ilm;
            IniciarSesionCommand = new Command(async () => await Login(), () => !IsBusy);
        }

        private async Task Login()
        {
            if (string.IsNullOrEmpty(email))
            {
                await App.Current.MainPage.DisplayAlert("Alerta", "Email requerido", "Ok");
            }
            else if(string.IsNullOrEmpty(password)){
                await App.Current.MainPage.DisplayAlert("Alerta", "Contraseña requerida", "Ok");
            }
            else
            {
                IsBusy = true;
                var _login = await config.Login(email, password);

                App.Current.Properties["IsLoggedIn"] = _login;
                if (_login)
                {
                    iml.ShowMainPage();
                }
                IsBusy = false;
            }
            
        }
    }
}
