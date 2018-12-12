using D_App_Multi.Helper;
using D_App_Multi.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace D_App_Multi.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PrincipalView : ContentPage
	{
		public PrincipalView ()
		{
			InitializeComponent ();
            
            BindingContext = new PrincipalViewModel();
		}
	}
}