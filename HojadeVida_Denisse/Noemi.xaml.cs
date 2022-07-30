using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HojadeVida_Denisse
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Noemi : ContentPage
	{
		public Noemi ()
		{
			InitializeComponent ();
		}

		private void Button_Regresar_Clicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new MainPage());
		}
	}
}