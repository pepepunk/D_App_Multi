
using Firebase.Auth;
using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace D_App_Multi.Service
{
    public class FirebaseConfig
    {
        private const string apiKey= "AIzaSyBDkUiYDezQL6xByjMkDyqAEL92ywO09kI";
        private const string firebaseUrl = "https://dietapp-cd385.firebaseio.com/";
        FirebaseConfig configuracion;
        private static FirebaseClient firebaseClient;

        public FirebaseConfig()
        {

        }

        public async Task<bool> Login(string email, string password)
        {
            bool autorizado = false;
            try
            {
                await Task.Delay(2000);
                var auth = new FirebaseAuthProvider(new Firebase.Auth.FirebaseConfig(apiKey));
                var token = auth.SignInWithEmailAndPasswordAsync(email, password).Result;

                firebaseClient = new FirebaseClient(
                    firebaseUrl,
                    new FirebaseOptions
                    {
                        AuthTokenAsyncFactory=()=>Task.FromResult(token.FirebaseToken)
                    });
                autorizado = true;
            }
            catch (Exception)
            {

                autorizado = false;
            }
            return autorizado;
        }
    }
}
