using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PEM003.Models;

namespace PEM003.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public JsonResult ObtenerProductos( ProductoModels producto)
        {
            var listProducto = new List<producto>();
            var produ1 = new producto() { idProducto = 1, nombreProducto = "peras", precioProducto = 12 };
            var produ2 = new producto() { idProducto = 1, nombreProducto = "manzanas", precioProducto = 12 };
            var produ3 = new producto() { idProducto = 1, nombreProducto = "kiwi", precioProducto = 12 };

            listProducto.Add(produ1);
            listProducto.Add(produ2);
            listProducto.Add(produ3);

            return Json(listProducto, JsonRequestBehavior.AllowGet);
        }

        public JsonResult ObtenerUsuarios()
        {
            var listUsuario = new List<UsuarioModels>();
            var usu1 = new UsuarioModels() { idUsuario=1, nombreUsuario="pepito", claveUsuario="1234", estadoUsuario='A' };
            var usu2 = new UsuarioModels() { idUsuario=2, nombreUsuario="jaimito", claveUsuario="12344", estadoUsuario='A' };
            var usu3 = new UsuarioModels() { idUsuario=3, nombreUsuario="dedo", claveUsuario="1234x", estadoUsuario='I' };
            
            listUsuario.Add(usu1);
            listUsuario.Add(usu2);
            listUsuario.Add(usu3);

            return Json(listUsuario, JsonRequestBehavior.AllowGet);
        }

        public JsonResult ObtenerCategorias()
        {
            var listUsuario = new List<CategoriaModels>();
            var cat1 = new CategoriaModels() {idCategoria=1, nombreCategoria="Gacesosas", descripcion="Toda las gaseosas", estado='A' };
            var cat2 = new CategoriaModels() {idCategoria =3, nombreCategoria = "Lacteos", descripcion = "Toda las lacteos", estado = 'A' };
            var cat3 = new CategoriaModels() { idCategoria =3, nombreCategoria = "medicina", descripcion = "Toda las medicamentos", estado = 'A' };

            listUsuario.Add(cat1);
            listUsuario.Add(cat2);
            listUsuario.Add(cat3);

            return Json(listUsuario, JsonRequestBehavior.AllowGet);
        }

        public JsonResult ObtenerSucursal()
        {
            var listSucursal= new List<Sucursal>();
            var suc1 = new Sucursal() { idSucursal=1, nombreSucursal="Santa Cruz", direccion="Avenida las americas", telefono="78888999" };
            var suc2 = new Sucursal() { idSucursal = 2, nombreSucursal = "La paz", direccion = "Avenida las mercado", telefono = "334343434" };
            var suc3 = new Sucursal() { idSucursal = 3, nombreSucursal = "Cochabanba", direccion = "Avenida las noel  keff", telefono = "2020222" };

            listSucursal.Add(suc1);
            listSucursal.Add(suc2);
            listSucursal.Add(suc3);

            return Json(listSucursal, JsonRequestBehavior.AllowGet);
        }
    }
}
