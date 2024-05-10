using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        public int id { get; set; }
        [DisplayName("Código")]     // son annotations =)
        public string codigo { get; set; }
        [DisplayName("Nombre")]
        public string nombre {  get; set; }
        [DisplayName("Descripción")]
        public string descripcion {  get; set; }
        [DisplayName("Precio")]
        public decimal precio {  get; set; }

        [DisplayName("Marca")]
        public Marca marca {  get; set; }
        [DisplayName("Categoria")]
        public Categoria categoria {  get; set; }
        [DisplayName("Imagen URL")]
        public string ImagenUrl {  get; set; }

        public List<Imagen> imagenes {  get; set; }
    }
}
