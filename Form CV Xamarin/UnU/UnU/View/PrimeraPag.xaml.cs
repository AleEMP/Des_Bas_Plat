using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace UnU.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrimeraPag : ContentPage
    {
        public PrimeraPag()
        {
            InitializeComponent();
        }

        private async void Button1_Clicked(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(EntryParaNombre.Text) ||
                string.IsNullOrWhiteSpace(EntryParaApellido.Text)||
                string.IsNullOrWhiteSpace(EntryParaDirecc.Text) ||
                string.IsNullOrWhiteSpace(EntryParaCorreo.Text) ||
                string.IsNullOrWhiteSpace(EntryParaCont.Text) ||
                string.IsNullOrWhiteSpace(EntryParaExpe1.Text) ||
                string.IsNullOrWhiteSpace(EntryParaExpe2.Text) ||
                string.IsNullOrWhiteSpace(EntryParaExpe3.Text) ||
                string.IsNullOrWhiteSpace(EntryParaIngles.Text) ||
                string.IsNullOrWhiteSpace(EntryParaEdu.Text) ||
                string.IsNullOrWhiteSpace(EntryParaAptitud1.Text) ||
                string.IsNullOrWhiteSpace(EntryParaAptitud2.Text) ||
                string.IsNullOrWhiteSpace(EntryParaAptitud3.Text) ||
                string.IsNullOrWhiteSpace(EntryParaDescr.Text))

            {
                await DisplayAlert("Error", "Por favor, completa todos los campos.", "Aceptar");
            }
            else {
                string nombre = EntryParaNombre.Text;
                string apellido = EntryParaApellido.Text;
                string direcc = EntryParaDirecc.Text;
                string correo = EntryParaCorreo.Text;
                string contacto = EntryParaCont.Text;
                string expe1 = EntryParaExpe1.Text;
                string expe2 = EntryParaExpe2.Text;
                string expe3 = EntryParaExpe3.Text;
                string ingles = EntryParaIngles.Text;
                string educacion = EntryParaEdu.Text;
                string aptitud1 = EntryParaAptitud1.Text;
                string aptitud2 = EntryParaAptitud2.Text;
                string aptitud3 = EntryParaAptitud3.Text;
                string descripcion = EntryParaDescr.Text;

                await Application.Current.MainPage.Navigation.PushAsync(new SegundaPag(nombre, apellido, direcc, correo, contacto, expe1, expe2, expe3, ingles, educacion, aptitud1, aptitud2, aptitud3, descripcion));
            }
        }
    }
}
