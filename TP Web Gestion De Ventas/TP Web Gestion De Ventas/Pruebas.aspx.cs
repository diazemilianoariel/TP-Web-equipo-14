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
    public partial class Pruebas : System.Web.UI.Page
    {
        List<Articulo> articuloList;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ArticuloManager articuloManager = new ArticuloManager();
                articuloList = articuloManager.Listar();
                grdListaCompleta.DataSource = articuloList;
                grdListaCompleta.DataBind();
            }
        }

        protected void btnRestar_Click(object sender, EventArgs e)
        {
            int cantidad = int.Parse(lblPrueba.Text);
            if (cantidad <= 0)
                cantidad = 0;
            else
                cantidad--;
            lblPrueba.Text = cantidad.ToString();
        }

        protected void btnSumar_Click(object sender, EventArgs e)
        {
            int cantidad = int.Parse(lblPrueba.Text);
            if (cantidad >= 99)
                cantidad = 99;
            else
                cantidad++;
            lblPrueba.Text = cantidad.ToString();
        }
    }
}