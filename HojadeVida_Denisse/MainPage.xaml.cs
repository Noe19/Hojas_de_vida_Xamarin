using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HojadeVida_Denisse
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void btn_Denisse(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1());
        }

        private void btn_Ivan(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Ivan());
        }
        private void btn_Paul(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Paul());
        }

        private void btn_Noemi(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Noemi());
        }

    }
}
