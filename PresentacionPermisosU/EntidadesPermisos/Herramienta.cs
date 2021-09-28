using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPermisos
{
    public class Herramienta
    {
        public int _IdHerramienta { get; set; }
        public string _CodigoHerramienta { get; set; }
        public string _Nombre { get; set; }
        public string _Medida { get; set; }
        public string _Marca { get; set; }
        public string _Descripcion { get; set; }

        public Herramienta(int idherramienta, string codigoherramienta, string nombre, string medida, string marca, string descripcion)
        {
            _IdHerramienta = idherramienta;
            _CodigoHerramienta = codigoherramienta;
            _Nombre = nombre;
            _Medida = medida;
            _Marca = marca;
            _Descripcion = descripcion;
        }

        public Herramienta()
        {

        }
    }
}
