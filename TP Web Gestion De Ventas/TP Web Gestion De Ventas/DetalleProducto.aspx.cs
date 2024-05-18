using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataManager;
using Dominio;
using System.Drawing;


namespace TP_Web_Gestion_De_Ventas
{
    public partial class DetalleProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Articulo arti = new Articulo();
            List<Articulo> listaArticulos = new List<Articulo>();
            int idProducto = Convert.ToInt32(Request.QueryString["id"]);
            if (!IsPostBack)
            {

                if (Session["listaArticulos"] == null)
                {
                    ArticuloManager am = new ArticuloManager();
                    listaArticulos = am.Listar();
                    Session.Add("listaArticulos", listaArticulos);
                }
                else
                {
                    listaArticulos = (List<Articulo>)Session["listaArticulos"];
                }

                arti=listaArticulos.Find(x=> x.id == idProducto);

                if (arti != null)
                {

                    txtNombre.Text = arti.nombre;
                    txtDescripcion.Text = arti.descripcion;
                    txtImporte.Text = arti.precio.ToString();
                    TextBox1.Text = arti.marca.descripcion;
                    TextBox2.Text = arti.codigo;


                    List<string> urls = new List<string>();
                    urls.Add(arti.ImagenUrl);
                    repRepetidor.DataSource = urls;
                    repRepetidor.DataBind();
                }
            }
        }

    }
}