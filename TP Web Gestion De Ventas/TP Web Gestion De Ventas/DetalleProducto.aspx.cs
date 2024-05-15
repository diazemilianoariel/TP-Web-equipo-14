using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;
using DataManager;
using Dominio;
using System.Drawing;


namespace TP_Web_Gestion_De_Ventas
{
	public partial class DetalleProducto : System.Web.UI.Page
	{
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            {
                
              
                    int idProducto = Convert.ToInt32(Request.QueryString["id"]);

                    
                    ArticuloManager am = new ArticuloManager();
                    Articulo art = am.Listar().Find(x => x.id == idProducto);

                    if (art != null)
                    {
                       
                        txtNombre.Text = art.nombre;
                        txtDescripcion.Text = art.descripcion;
                        txtImporte.Text = art.precio.ToString();
                        TextBox1.Text = art.marca.descripcion;
                        TextBox2.Text = art.codigo;

                        
                        List<string> urls = new List<string>();
                        urls.Add(art.ImagenUrl);
                        repRepetidor.DataSource = urls;
                        repRepetidor.DataBind();
                    }
               
                
               
            }
        }

    }
}