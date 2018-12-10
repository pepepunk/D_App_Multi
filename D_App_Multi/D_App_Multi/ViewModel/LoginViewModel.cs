using D_App_Multi.Model;
using D_App_Multi.Service;
using D_App_Multi.View;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace D_App_Multi.ViewModel
{
    public class LoginViewModel
    {
        public string usr { get; set; }
        public string pass { get; set; }
        public bool isBusy { get; set; }
        public Command IniciarSessionCommand { get; set; }
        UsuarioService usuarioService = new UsuarioService();
        private INavigation _navigation;
        public LoginViewModel(INavigation navigation)
        {
            IniciarSessionCommand = new Command(async () => await Loggin(), () => !isBusy);
            _navigation = navigation;
        }

        private async Task Loggin()
        {
            isBusy = true;
            var usuario = usuarioService.GetUserByUserPasswordAsync(usr, pass);
            await Task.Delay(2000);
            isBusy = false;
            if (usuario!=null)
            {
                await _navigation.PushAsync(new LoggCorrect());
            }
            else
            {
                await _navigation.PushAsync(new LoggFail());
            }
        }
    }
}
