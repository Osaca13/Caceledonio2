using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caceledonio
{
    public class ClientesCollection
    {

            public int ClienteId { get; set; }
            public string ClienteFoto { get; set; }
            public string ClienteNombre { get; set; }
            public string ClienteCorreo { get; set; }
            public string ClienteDireccion { get; set; }
        
    }

    public class Clientesmanager
    {
        public static ObservableCollection<ClientesCollection> ClientesDatos()
        {
            var clientes = new ObservableCollection<ClientesCollection>
            {
                new ClientesCollection { ClienteId = 1,ClienteFoto="Assets/female.ico",  ClienteNombre = "Pepita Gonzalez", ClienteCorreo = "pepe@gmail.com", ClienteDireccion = "calle Barcelona 23, 2a. 08227, Terrassa" },
               // new ClientesCollection { ClienteId = 2, ClienteNombre = "Alberto Aureo", ClienteCorreo = "ar@gmail.com", ClienteDireccion = "calle Egido 9, 2a. 08227, Terrassa" },
               // new ClientesCollection { ClienteId = 3, ClienteNombre = "Rosalinda Berteu", ClienteCorreo = "pepe@gmail.com", ClienteDireccion = "calle Anton 145, 2a. 08227, Girona" }
            };



            return clientes;
        }
            
       
    }
}
