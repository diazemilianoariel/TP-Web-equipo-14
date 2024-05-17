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
        public List<Articulo> articuloList;

        public Dictionary<int, int> articuloDictionary = new Dictionary<int, int>
        {
            {1, 10},
            {2, 20},
            {3, 30}
        };


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ArticuloManager articuloManager = new ArticuloManager();
                articuloList = articuloManager.Listar();
                //grdListaCompleta.DataSource = articuloList;
                //grdListaCompleta.DataBind();
                Session.Add("lista_completa", articuloList);
                Repeater1.DataSource = articuloList;
                Repeater1.DataBind();
                //    grilla.DataSource = articuloList;
                //    grilla.DataBind();
                //
            }
            else
            {
                articuloList = (List<Articulo>)Session["lista_completa"];
                //Repeater1.DataSource = articuloList;
                //Repeater1.DataBind();
            }
        }

        protected void btnRestar_Click(object sender, EventArgs e)
        {

            //lblPrueba.Text="PEPE RESTOOOO";
            //int cantidad = int.Parse(lblPrueba.Text);
            //if (cantidad <= 0)
            //    cantidad = 0;
            //else
            //    cantidad--;
            //lblPrueba.Text = cantidad.ToString();
        }

        protected void btnSumar_Click(object sender, EventArgs e)
        {

            //lblPrueba.Text="PEPE SUMOOO";
            //int cantidad = int.Parse(lblPrueba.Text);
            //if (cantidad >= 99)
            //    cantidad = 99;
            //else
            //    cantidad++;
            //lblPrueba.Text = cantidad.ToString();
        }

        protected void btnSumar_Click1(object sender, EventArgs e)
        {

            int id = int.Parse(((Button)sender).CommandArgument);
            articuloList.Find(x => x.id == id).cantidad++;
            Repeater1.DataSource = articuloList;
            Repeater1.DataBind();
            Session["lista_completa"] = articuloList;
        }

        protected void btnRestar_Click1(object sender, EventArgs e)
        {
            int id = int.Parse(((Button)sender).CommandArgument);
            if (articuloList.Find(x => x.id == id).cantidad > 0)
            {
                articuloList.Find(x => x.id == id).cantidad--;
                Repeater1.DataSource = articuloList;
                Repeater1.DataBind();
                Session["lista_completa"] = articuloList;
            }
        }



        //protected void sumarCantidad_Click(object sender, EventArgs e)
        //{
        //    int cantidad = int.Parse(lblPrueba.Text);
        //    if (cantidad >= 99)
        //        cantidad = 99;
        //    else
        //        cantidad++;
        //    lblPrueba.Text = cantidad.ToString();
        //} 
    }
}