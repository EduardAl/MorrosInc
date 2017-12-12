using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            var navigationPage = new NavigationPage(new Materias.Matematica())
            {
                BarBackgroundColor = Color.Red,
                BarTextColor = Color.Black
            };
            InitializeComponent();

            StackMatematica.GestureRecognizers.Add(
                new TapGestureRecognizer()
                {
                    Command = new Command(() =>
                    {
                        ((NavigationPage)this.Parent).PushAsync(new Materias.Matematica());
                    })
                });
        }   
    }
}
