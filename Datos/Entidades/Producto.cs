using Datos.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Datos.Entidades
{
    public class Producto
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Existencia { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaIngreso { get; set; }
        public Modelos Modelos { get; set; }


    }
}
