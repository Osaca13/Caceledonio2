using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace Caceledonio
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Usuario : Page
    {
        private string _nombre;
        private string _email;
        private string _direccion;
        

        public Usuario()
        {
            this.InitializeComponent();
        }

        private void LeerNombre_TextChanged(object sender, TextChangedEventArgs e)
        {
            _nombre = NombreUsuarioTextBox.Text.ToString();
        }

        private void LeerEmail_TextChanged(object sender, TextChangedEventArgs e)
        {
            _email = EmailUsuarioTextBox.Text.ToString();

        }

        private void LeerDireccion_TextChanged(object sender, TextChangedEventArgs e)
        {
            _direccion = DireccionUsuarioTextBox.Text.ToString();

        }

        private void LeerDias_CalendarView(CalendarView sender, CalendarViewSelectedDatesChangedEventArgs args)
        {
            //IList<DateTimeOffset> _diassele = ;

            DiasTextBlock.Text = _nombre + "\r\n " +
                                 _email + "\r\n " +
                                 _direccion + "\r\n ";

            //foreach (DateTimeOffset fechas in _diassele)
            //{
            //    DiasTextBlock.Text += fechas.Day+
            //                          "/"+
            //                          fechas.Month+
            //                          "/"+
            //                          fechas.Year+"\r\n";
            //}

            
                                
        }

        

        private void Usuario_Pago_Click(object sender, RoutedEventArgs e)
        {
           

                 
        }

        private void Usuario_DateChanged(CalendarDatePicker sender, CalendarDatePickerDateChangedEventArgs args)
        {
            string anho = HorarioUsuarioCalendarPicker.Date.Value.Day.ToString()+
                          "/"+
                          HorarioUsuarioCalendarPicker.Date.Value.Month.ToString()+
                          "/" +
                          HorarioUsuarioCalendarPicker.Date.Value.Year.ToString();

            DiasTextBlock.Text = _nombre + "\r\n " +
                                 _email + "\r\n " +
                                 _direccion + "\r\n " + anho;
                                 
        }
    }
}
