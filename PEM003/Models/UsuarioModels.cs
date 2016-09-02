using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PEM003.Models
{
    public class UsuarioModels
    {
        public int idUsuario { set; get; }
        public string nombreUsuario { set; get; }
        public string claveUsuario { set; get; }
        public char estadoUsuario { set; get; }
    }
}