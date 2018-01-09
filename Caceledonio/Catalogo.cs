using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caceledonio
{
    public class Catalogo
    {
        public int ProdId { get; set; }
        public string ProdDescripcion { get; set; }
        
        public string ProdContenido { get; set; }
        
        public double ProdPrecio { get; set; }
    }
    public class CatalogoManager
    {
        public static List<Catalogo> CatalogoList()
        {
            var productos = new List<Catalogo>
            {
                new Catalogo { ProdId = 1, ProdDescripcion = "Assets/mandarinas2.jpg", ProdContenido = "10 kg Mandarinas de Mesa", ProdPrecio = 19.95 },
                new Catalogo { ProdId = 2, ProdDescripcion = "Assets/mandarinas2.jpg", ProdContenido = "20 kg Mandarinas de Mesa", ProdPrecio = 30.95 },
                new Catalogo { ProdId = 3, ProdDescripcion = "Assets/mandarinas2.jpg", ProdContenido = "30 kg Mandarinas de Mesa", ProdPrecio = 49.95 },
                new Catalogo { ProdId = 4, ProdDescripcion = "Assets/mandarinas2.jpg", ProdContenido = "40 kg Mandarinas de Mesa", ProdPrecio = 67.95 },
                new Catalogo { ProdId = 5, ProdDescripcion = "Assets/mandarinas1.jpg", ProdContenido = "10 kg Mandarinas de Zumo", ProdPrecio = 14.95 },
                new Catalogo { ProdId = 6, ProdDescripcion = "Assets/mandarinas1.jpg", ProdContenido = "20 kg Mandarinas de Zumo", ProdPrecio = 22.95 },
                new Catalogo { ProdId = 7, ProdDescripcion = "Assets/mandarinas1.jpg", ProdContenido = "30 kg Mandarinas de Zumo", ProdPrecio = 34.95 },
                new Catalogo { ProdId = 8, ProdDescripcion = "Assets/mandarinas1.jpg", ProdContenido = "40 kg Mandarinas de Zumo", ProdPrecio = 45.95 },
                new Catalogo { ProdId = 9, ProdDescripcion = "Assets/Naranja-Mesa.jpg", ProdContenido = "10 kg Naranjas de Mesa", ProdPrecio = 16.95 },
                new Catalogo { ProdId = 10, ProdDescripcion = "Assets/Naranja-Mesa.jpg", ProdContenido = "20 kg Naranjas de Mesa", ProdPrecio = 27.95 },
                new Catalogo { ProdId = 11, ProdDescripcion = "Assets/Naranja-Mesa.jpg", ProdContenido = "30 kg Naranjas de Mesa", ProdPrecio = 41.95 },
                new Catalogo { ProdId = 12, ProdDescripcion = "Assets/Naranja-Mesa.jpg", ProdContenido = "40 kg Naranjas de Mesa", ProdPrecio = 54.95 },
                new Catalogo { ProdId = 13, ProdDescripcion = "Assets/naranjazumo3.jpg", ProdContenido = "10 kg Naranjas de Zumo", ProdPrecio = 14.95 },
                new Catalogo { ProdId = 14, ProdDescripcion = "Assets/naranjazumo3.jpg", ProdContenido = "20 kg Naranjas de Zumo", ProdPrecio = 22.95 },
                new Catalogo { ProdId = 15, ProdDescripcion = "Assets/naranjazumo3.jpg", ProdContenido = "30 kg Naranjas de Zumo", ProdPrecio = 34.45 },
                new Catalogo { ProdId = 16, ProdDescripcion = "Assets/naranjazumo3.jpg", ProdContenido = "40 kg Naranjas de Zumo", ProdPrecio = 45.95 },

                new Catalogo { ProdId = 17, ProdDescripcion = "Assets/mesaconnaranjas1.jpg", ProdContenido = "5 kg Naranja mesa + 5 kg Naranja zumo", ProdPrecio = 15.95 },
                new Catalogo { ProdId = 18, ProdDescripcion = "Assets/mesaconnaranjas1.jpg", ProdContenido = "10 kg Naranja mesa + 10 kg Naranja zumo", ProdPrecio = 25.95 },
                new Catalogo { ProdId = 19, ProdDescripcion = "Assets/mesaconnaranjas1.jpg", ProdContenido = "10 kg Naranja mesa + 20 kg Naranja zumo", ProdPrecio = 36.95 },
                new Catalogo { ProdId = 20, ProdDescripcion = "Assets/mesaconnaranjas1.jpg", ProdContenido = "20 kg Naranja mesa + 10 kg Naranja zumo", ProdPrecio = 38.95 },
                new Catalogo { ProdId = 21, ProdDescripcion = "Assets/mesaconnaranjas1.jpg", ProdContenido = "20 kg Naranja mesa + 20 kg Naranja zumo", ProdPrecio = 50.45 },
             

                new Catalogo { ProdId = 22, ProdDescripcion = "Assets/naranjasymandarinas.jpg", ProdContenido = "10 kg Naranja zumo + 10 kg Mandarina zumo", ProdPrecio = 22.95 },
                new Catalogo { ProdId = 23, ProdDescripcion = "Assets/naranjasymandarinas.jpg", ProdContenido = "20 kg Naranja zumo + 10 kg Mandarina zumo", ProdPrecio = 34.95 },
                new Catalogo { ProdId = 24, ProdDescripcion = "Assets/naranjasymandarinas.jpg", ProdContenido = "20 kg Naranja zumo + 20 kg Mandarina zumo", ProdPrecio = 45.45 },

                new Catalogo { ProdId = 25, ProdDescripcion = "Assets/naranjasymandarinas.jpg", ProdContenido = "5 kg Naranja mesa + 5 kg Mandarina mesa", ProdPrecio = 18.45 },
                new Catalogo { ProdId = 26, ProdDescripcion = "Assets/naranjasymandarinas.jpg", ProdContenido = "10 kg Naranja mesa + 10 kg Mandarina mesa", ProdPrecio = 30.95 },
                new Catalogo { ProdId = 27, ProdDescripcion = "Assets/naranjasymandarinas.jpg", ProdContenido = "20 kg Naranja mesa + 10 kg Mandarina mesa", ProdPrecio = 44.95 },
                new Catalogo { ProdId = 28, ProdDescripcion = "Assets/naranjasymandarinas.jpg", ProdContenido = "20 kg Naranja mesa + 20 kg Mandarina mesa", ProdPrecio = 61.95 },

                new Catalogo { ProdId = 29, ProdDescripcion = "Assets/naranjasymandarinas.jpg", ProdContenido = "10 kg Naranja mesa + 10 kg Mandarina mesa + 10 kg Naranja zumo", ProdPrecio = 42.45 }
            };

            return productos;




        }
    }
}
