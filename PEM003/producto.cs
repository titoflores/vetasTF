//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PEM003
{
    using System;
    using System.Collections.Generic;
    
    public partial class producto
    {
        public producto()
        {
            this.detalle = new HashSet<detalle>();
        }
    
        public int idProducto { get; set; }
        public string nombreProducto { get; set; }
        public Nullable<double> precioProducto { get; set; }
    
        public virtual ICollection<detalle> detalle { get; set; }
    }
}
