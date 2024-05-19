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

            if (!IsPostBack)
            {
                ArticuloManager articuloManager = new ArticuloManager();
                articuloList = articuloManager.Listar();
                Session.Add("lista_completa", articuloList);
                //Repeater1.DataSource = articuloList;
                //Repeater1.DataBind();
            }
            else
            {
                articuloList = (List<Articulo>)Session["lista_completa"];
                //Repeater1.DataSource = articuloList;
                //Repeater1.DataBind();
            }

            //here session carro...

            refreshCarro();



        }

        protected void refreshCarro()
        {
            Carrito carritoAux = new Carrito();
            Articulo articuloAux = new Articulo();

            if (Session["carrito"] != null) //es decir, estuve agregando cosas...
            {
                carritoAux = (Carrito)Session["carrito"];
                foreach (KeyValuePair<int, int> item in carritoAux.items)
                {
                    if (!(articulosDelCarro.Exists(x=>x.id==item.Key)))     //si no existe lo agrego
                    {
                        articuloAux = articuloList.Find(x => x.id.Equals(item.Key));
                        articuloAux.cantidad = item.Value;
                        articulosDelCarro.Add(articuloAux);
                    }
                }
                refreshSubtotal();
            }

            //refreshSubtotal();

            Repeater1.DataSource = articulosDelCarro;
            Repeater1.DataBind();
            //Response.Redirect(Request.RawUrl);  //actualizo pantalla
        }

        protected void refreshSubtotal()
        {
            //to do...
            Carrito carritoAux=new Carrito();
            Articulo articuloAux=new Articulo();

            carritoAux = (Carrito)Session["carrito"];

            foreach(KeyValuePair<int,int>item in carritoAux.items)
            {
                articuloAux=articuloList.Find(x=>x.id.Equals(item.Key));
                articuloAux.cantidad=item.Value;
                articuloAux.subtotal = articuloAux.cantidad * articuloAux.precio;
                //articulosDelCarro[item.Key] = articuloAux;     
            }



            //int cantParcial = articuloList.Find(x => x.id == id).cantidad;
            //decimal price = articuloList.Find(x => x.id == id).precio;

            //articuloList.Find(x => x.id == id).subtotal = cantParcial * price;
        }

        protected void btnSumar_Click1(object sender, EventArgs e)
        {
            Carrito carritoAux = new Carrito();
            int id = int.Parse(((Button)sender).CommandArgument);
            //articuloList.Find(x => x.id == id).cantidad++;

            carritoAux = (Carrito)Session["carrito"];
            carritoAux.sumarAlCarrito(id);
            Session["carrito"] = carritoAux;

            refreshCarro();
        }

        protected void btnRestar_Click1(object sender, EventArgs e)
        {

            Carrito carritoAux = new Carrito();
            int id = int.Parse(((Button)sender).CommandArgument);
            //articuloList.Find(x => x.id == id).cantidad++;

            carritoAux = (Carrito)Session["carrito"];
            carritoAux.restarAlCarrito(id);
            Session["carrito"] = carritoAux;

            refreshCarro();



            //int id = int.Parse(((Button)sender).CommandArgument);
            //if (articuloList.Find(x => x.id == id).cantidad > 0)
            //{
            //    articuloList.Find(x => x.id == id).cantidad--;

            //    int cantParcial = articuloList.Find(x => x.id == id).cantidad;
            //    decimal price = articuloList.Find(x => x.id == id).precio;

            //    articuloList.Find(x => x.id == id).subtotal = cantParcial * price;

            //    Repeater1.DataSource = articuloList;
            //    Repeater1.DataBind();
            //    //Session["lista_completa"] = articuloList;
            //}
        }
    }
}