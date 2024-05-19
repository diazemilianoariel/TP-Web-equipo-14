
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Carrito
    {
        public Dictionary<int, int> items;  //el diccionario sera compuesto por: {id,cantidad ; id,cantidad}
        //public List<Articulo> articulos;
        //public int cant {  get; set; }

        public Carrito()    //instancio el diccionario de articulos para ir cargando...
        {
            items = new Dictionary<int, int>();
            //cant = 0;
        }

        //metodo subtotal y total deben ir en la pagina del carrito para tener info de los articulos...

        public void sumarAlCarrito(int id_articulo)
        {
            if (items.ContainsKey(id_articulo))     //pregunto si el articulo ya fue cargado al carrito alguna vez
            {
                items[id_articulo]++;
            }
            else
            {
                items.Add(id_articulo, 1);
            }
        }

        public void restarAlCarrito(int id_articulo)
        {
            if (items.ContainsKey(id_articulo))
            {
                if (items[id_articulo] <= 0)        //si no tiene cantidad, vuela
                {
                    items.Remove(id_articulo);
                }
                else
                {
                    items[id_articulo]--;
                    if (items[id_articulo] == 0)    //si luego de decrementar, no tiene cantidad, vuela
                    {
                        items.Remove(id_articulo);
                    }
                }
            }
        }

        public void borrarDelCarrito(int id_articulo)
        {
            items.Remove(id_articulo);
        }

        public int cantidadDE(int id_articulo)
        {
            return items[id_articulo];
        }

        public int cantidadTotal()
        {
            //todo...
            int cantidad = 0;
            foreach(KeyValuePair<int, int> item in items)
            {
                cantidad = cantidad + item.Value;
            }
            return cantidad;
        }
    }
}
