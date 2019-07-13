using QuieroPizza.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuieroPizza.Web.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
           var producto1 = new ProductoModel();
            producto1.Id = 1;
            producto1.Description = "Pizza 6 Quesos";
            var producto2 = new ProductoModel();
            producto2.Id = 2;
            producto2.Description = "Pizza 4 Estaciones ";
            var producto3 = new ProductoModel();
            producto3.Id = 3;
            producto3.Description = "Pizza 6 Jamon y Queso";

            var ListaProductos = new List<ProductoModel>();
            ListaProductos.Add(producto1);
            ListaProductos.Add(producto2);
            ListaProductos.Add(producto3);



            return View(ListaProductos);
        }
    }
}