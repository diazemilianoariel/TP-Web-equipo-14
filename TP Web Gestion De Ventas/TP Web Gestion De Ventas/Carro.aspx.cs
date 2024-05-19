using DataManager;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_Web_Gestion_De_Ventas
{
    public partial class Carro : System.Web.UI.Page
    {
        public List<Articulo> articuloList;
        public List<Articulo> articulosDelCarro;


        protected void Page_Load(object sender, EventArgs e)
        {
            articulosDelCarro = new List<Articulo>();

            ArticuloManager articuloManager = new ArticuloManager();
            articuloList = articuloManager.Listar();

            if (Session["lista_completa"] == null)
                Session.Add("lista_completa", articuloList);
            else
                articuloList = (List<Articulo>)Session["lista_completa"];

            if (Session["articulosDelcarro"] == null)
                Session.Add("articulosDelCarro", articulosDelCarro);
            else
                articulosDelCarro = (List<Articulo>)Session["articulosDelCarro"];

            refreshCarro();
        }

        protected void refreshCarro()
        {
            Carrito carritoAux = new Carrito();
            Articulo articuloAux = new Articulo();
            decimal montoTotal = 0;

            if (Session["carrito"] != null) //es decir, estuve agregando cosas...
            {
                carritoAux = (Carrito)Session["carrito"];
                articulosDelCarro.Clear();
                foreach (KeyValuePair<int, int> item in carritoAux.items)
                {

                    //if (!(articulosDelCarro.Exists(x=>x.id==item.Key)))     //si no existe lo agrego
                    //{
                        articuloAux = articuloList.Find(x => x.id.Equals(item.Key));
                        articuloAux.cantidad = item.Value;
                        articulosDelCarro.Add(articuloAux);
                    //}
                }
                refreshSubtotal();
            }
            foreach(Articulo arti in articulosDelCarro)
            {
                montoTotal = montoTotal + arti.subtotal;
            }
            lblMontoTotal.Text = montoTotal.ToString();

            Repeater1.DataSource = articulosDelCarro;
            Repeater1.DataBind();
            
        }

        protected void refreshSubtotal()
        {
            Carrito carritoAux=new Carrito();
            Articulo articuloAux=new Articulo();

            carritoAux = (Carrito)Session["carrito"];

            foreach(KeyValuePair<int,int>item in carritoAux.items)
            {
                articuloAux=articuloList.Find(x=>x.id.Equals(item.Key));
                articuloAux.cantidad=item.Value;
                articuloAux.subtotal = articuloAux.cantidad * articuloAux.precio;    
            }
        }


        protected void btnRestar_Click(object sender, EventArgs e)
        {
            Carrito carritoAux = new Carrito();

            int id = int.Parse(((Button)sender).CommandArgument);

            carritoAux = (Carrito)Session["carrito"];
            carritoAux.restarAlCarrito(id);
            Session["carrito"] = carritoAux;
            refreshCarro();
            Response.Redirect(Request.RawUrl);
        }

        protected void btnSumar_Click(object sender, EventArgs e)
        {
            Carrito carritoAux = new Carrito();

            int id = int.Parse(((Button)sender).CommandArgument);

            carritoAux = (Carrito)Session["carrito"];
            carritoAux.sumarAlCarrito(id);
            Session["carrito"] = carritoAux;
            refreshCarro();
            Response.Redirect(Request.RawUrl);
        }
    }
}