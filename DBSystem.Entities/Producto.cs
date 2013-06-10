using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace DBSystem.BusinessEntities
{
    public class Producto
    {
        public Int32  Id  { get; set; }
        public Int32 CategoriaId { get; set; }
        public string Codigo { get; set; }
        public string  Descripcion { get; set; }
        public decimal  Precio { get; set; }
        public decimal Stock { get; set; }
        public bool  Descontinuado { get; set; }
    }
}
