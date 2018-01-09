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
    

    public sealed partial class Productos : Page
    {

        public List<Catalogo> CatalogoItem;
        private string _naranjasCaja;
        private string _mandarinasCaja;
        private List<String> _carrito = new List<String>();
        private int conteo = 0;
        

        public List<Catalogo> CatalogoItems
        {
            get { return CatalogoItem; }
            set { CatalogoItem = value; }
            // Text= "{x:Bind ProdCantidad1}"
        }



        public Productos()
        {
            this.InitializeComponent();
            CatalogoItem = CatalogoManager.CatalogoList();
            this.DataContext = CatalogoItems;
            
        }

        private void NaranjasClick(object sender, RoutedEventArgs e)
        {
            var selected = (MenuFlyoutItem)sender;
            _naranjasCaja = selected.Text;
            
            _carrito.Add(_naranjasCaja);
            int numero = _carrito.IndexOf(_naranjasCaja);

            conteo = _carrito.Count;
            DisplayResult();
        }

        private void MandarinasClick(object sender, RoutedEventArgs e)
        {
            var selected = (MenuFlyoutItem)sender;
            _mandarinasCaja = selected.Text;
            _carrito.Add(_mandarinasCaja.ToString());
            int numero = _carrito.IndexOf(_mandarinasCaja);
            conteo = _carrito.Count;
            DisplayResult();
        }

        private void DisplayResult()
        {
            //string texto2 = ResultTextBlock.Text;
            //texto = texto2 +"\r\n"+ _carrito.Last();
            //ResultTextBlock.Text = texto;
            //ResultTextBlock.TextWrapping = TextWrapping.Wrap;
            //ResultTextBlock.TextAlignment = TextAlignment.Justify;
            TextBlockCarrito.Text = _carrito.Count.ToString();
           
        }

        private void ButtonCambiar_Click(object sender, RoutedEventArgs e)
        {
            //ResultTextBlock.Text = "";
            _carrito.Remove(_mandarinasCaja);
         
            
        }

        private void GridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var catalogo = (Catalogo)e.ClickedItem;
            TextBlockCarrito.Text = "Selected: " + catalogo.ProdId;

        }
    }
}
