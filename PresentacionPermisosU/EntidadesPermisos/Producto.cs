using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPermisos
{
    public class Producto
    {
        public int _IdProducto { get; set; }
        public string _Codigobarras { get; set; }
        public string _Nombre { get; set; }
        public string _Descripcion { get; set; }
        public string _Marca { get; set; }

        public Producto(int idproducto, string codigobarras, string nombre, string descripcion, string marca)
        {
            _IdProducto = idproducto;
            _Codigobarras = codigobarras;
            _Nombre = nombre;
            _Descripcion = descripcion;
            _Marca = marca;
        }

        public Producto()
        {

        }
    }
}
