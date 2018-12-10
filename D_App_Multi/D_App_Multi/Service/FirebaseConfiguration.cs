using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using D_App_Multi.Model;
using System.Linq;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
//using Firebase.Xamarin;
//using Firebase.Xamarin.Database;
//using Firebase.Xamarin.Auth;


namespace D_App_Multi.Service
{
    public class FirebaseConfiguration
    {

        private const string databaseSecret = "JnAmHWVyS2J8DRp0Y7lL5MAX9Svokg9zJyntjBOS";

        private const string databaseUrl= "https://dietapp-cd385.firebaseio.com/";

        //private FirebaseClient client;
        //private FirebaseAuth userAuth;
        //FirebaseAuthProvider firebaseAuthProvider;


        public FirebaseConfiguration()
        {
            
        }

        public List<T> GetUsers<T>(string node)
        {
            List<T> usuarios = new List<T>();
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create($"{databaseUrl+node}/.json");
            var response = (HttpWebResponse)httpWebRequest.GetResponse();
            var streamReader = new StreamReader(response.GetResponseStream()).ReadToEnd();
            var data = JObject.Parse(streamReader);
            foreach (var item in data)
            {
                usuarios.Add(JsonConvert.DeserializeObject<T>(item.Value.ToString()));
            }
            return usuarios;
        }

        
    }
}
