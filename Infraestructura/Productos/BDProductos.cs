using Datos.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace Infraestructura.Productos
{
    public class BDProductos
    {
       // List<string> listaproductos = new List<string>();

        public static List<Producto> listaproductos = new List<Producto>();


        #region TratamientoJson
        //private static string RUTA = Path.GetFullPath("ProductData.json").Replace(@"\DCPHONE\bin\Debug\ProductData.json", string.Empty) + @"\Infraestructura\Resources\ProductData.json";

        private static string RUTA = Path.GetFullPath("ProductData.json").Replace(@"\DCPHONE\bin\Debug\ProductData.json", @"\Infraestructura\Resources\ProductData.json");
        private static string DIRPATH = Directory.GetCurrentDirectory();

        public void Serializar()
        {
            string resultado = JsonConvert.SerializeObject(listaproductos, Formatting.Indented);
           //Console.WriteLine("Hola Mundo esta es la ruta de Serializacion   " + RUTA + "  Y estos son los datos ya serializados ===" + texto);
            File.WriteAllText(RUTA, resultado);
        }

        public void Deserealizar()
        {
              //Console.WriteLine("Hola Mundo Esta es una Deserealizacion   "+ RUTA, "\n" + DIRPATH);
                string resultado = File.ReadAllText(RUTA);
                listaproductos = JsonConvert.DeserializeObject<List<Producto>>(resultado);
        }

        #endregion

        #region Catalogo 
        
        public void Insertar(Producto p )
        {
            //Console.WriteLine(np);
            listaproductos.Add(p);
            Serializar();
        }


        public void Eliminar(int id)
        {
            listaproductos.RemoveAt(id);
            Serializar();
        }

        public void Update(Producto np,int id) {


            listaproductos.Insert(id,np);
            Serializar();

        }

        public List<Producto> GetProductos()
        {
            Deserealizar();
            return listaproductos;
        }


        

      

 



        #endregion





    }
}

