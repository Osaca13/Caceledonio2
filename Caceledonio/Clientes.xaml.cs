using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public sealed partial class Clientes : Page
    {
        public ObservableCollection<ClientesCollection> ClientesItem;
        private string _nombre;
        private string _email;
        private string _direccion;
        

        public ObservableCollection<ClientesCollection> ClientesItems
        {
            get { return ClientesItem; }
            set { ClientesItem = value; }
            // Text= "{x:Bind ProdCantidad1}"


        }

        public Clientes()
        {
            this.InitializeComponent();
            ClientesItem = Clientesmanager.ClientesDatos();
            this.DataContext = ClientesItems;
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

       

        private void Agregar(object sender, RoutedEventArgs e)
        {
            int numero = ClientesItems.Count;
            _nombre = NombreUsuarioTextBox.Text.ToString();
            _email = EmailUsuarioTextBox.Text.ToString();
            _direccion = DireccionUsuarioTextBox.Text.ToString();
            NombreUsuarioTextBox.Text = "";
            EmailUsuarioTextBox.Text = "";
            DireccionUsuarioTextBox.Text = "";
            ClientesItems.Add(new ClientesCollection() { ClienteId = ++numero, ClienteFoto="Assets/female.ico", ClienteNombre = _nombre, ClienteCorreo = _email, ClienteDireccion = _direccion });
        }
    }
}
