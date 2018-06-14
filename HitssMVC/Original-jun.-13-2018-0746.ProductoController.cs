using HitssMVC.ServicioHits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HitssMVC.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        Service1Client productos = new Service1Client();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult InsertProducto()
        {

            return View();
        }
        [HttpPost]
        public ActionResult InsertProducto(Producto pro)
        {
            productos.InsertProducto(pro);
            return View();
        }

        public ActionResult GetProducto()
        {
            List<Producto> list = productos.GetProductos().ToList();
            ViewBag.List = list;

            return View();
        }
        /*
        public ActionResult GetProductosDelimitador()
        {

            return View();
        }*/
        public ActionResult UpdateProducto()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UpdateProducto(Producto pro)
        {
            Producto prod = new Producto();
            productos.UpdateProducto(pro);
            return View();
        }
        [HttpPost]
        public ActionResult BuscarProducto()
        {

            return View();
        }
        public ActionResult BuscarProducto(int id)
        {
            List<Producto> list = productos.BuscarProducto(id).ToList();
            ViewBag.List = list;

            return View();
        }

        public ActionResult deleteProdcuto()
        {
            return View();
        }
        [HttpPost]
        public ActionResult deleteContacto(Producto pro)
        {
            productos.deleteProducto(pro.Id_producto);
            return View();
        }

    }
}
}