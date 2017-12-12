using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Materias
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Matematica : ContentPage
    {
        List<Temas> temas;
        public Matematica()
        {
            InitializeComponent();
            InitPag();
        }
        private void InitPag()
        {
            temas = new List<Temas>
            {
                new Temas { Name = "Básicas", ImagenSource = "Basicas.png" },
                new Temas { Name = "Geometría", ImagenSource = "Recurso.png" },
                new Temas { Name = "Gráficas y Funciones", ImagenSource = "Funciones.png" }
            };
            foreach (var tema in temas)
            {
                PickerTemas.Items.Add(tema.Name);
            }
            PickerTemas.SelectedIndex = 0;
        }
        int tapCount;
        void OnTapGestureRecognizerTapped(object sender, EventArgs args)
        {
            Double tapposition = sv.ScrollY;
            tapCount++;
            var imageSender = (Image)sender;
            // watch the monkey go from color to black&white!
            if (tapCount % 2 == 0)
            {
                sv.RotationY = 0;
                sv.RotationX = 0;
            }
            else
            {
                 sv.RotationY = 180;
                 sv.RotationX = 180;
            }
        }
        private void PickerTemas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int position = PickerTemas.SelectedIndex;
            if (position > -1)
            {
                Foto.Source = temas[position].ImagenSource;
            }
        }
    }
}