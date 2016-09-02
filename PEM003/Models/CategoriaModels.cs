using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PEM003.Models
{
    public class CategoriaModels
    {
        public int idCategoria { set; get; }
        public string nombreCategoria { set; get; }
        public string descripcion { set; get; }
        public char estado { set; get; }
    }
}