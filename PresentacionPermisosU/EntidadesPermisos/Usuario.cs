using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPermisos
{
    public class Usuario
    {
        public int _IdUsuario { get; set; }
        public string _Nombre { get; set; }
        public string _Contrasenia { get; set; }
        public string _ApellidoP { get; set; }
        public string _ApellidoM { get; set; }
        public string _FechaNacimiento { get; set; }
        public string _RFC { get; set; }
        public int _Id_Tipo { get; set; }

        public Usuario(int idusuario, string nombre, string contrasenia, string apellidop, string apellidom, string fechanacimiento, string rfc, int id_tipo)
        {
            _IdUsuario = idusuario;
            _Contrasenia = contrasenia;
            _Nombre = nombre;
            _ApellidoP = apellidop;
            _ApellidoM = apellidom;
            _FechaNacimiento = fechanacimiento;
            _RFC = rfc;
            _Id_Tipo = id_tipo;
        }

        public Usuario()
        {

        }
    }
}
