using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PEM003.Models
{
    public class VentaModels
    {
        public int idVenta { set; get; }
        public DateTime fecha { set; get; }
        public string nombreUsuario { set; get; }
        public float total { set; get; }
        public List<ProductoModels> producto { set; get; }
    }
}