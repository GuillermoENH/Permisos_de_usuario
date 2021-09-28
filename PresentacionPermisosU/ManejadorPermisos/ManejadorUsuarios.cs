using AccesoDatos;
using EntidadesPermisos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejadorPermisos
{
    public class ManejadorUsuarios
    {
        Conexion c = new Conexion("localhost", "root", "12345", "agenciaautomotriz", 3306);

        public string Guardar(Usuario usuario)
        {
            return c.Comando(string.Format("insert into usuarios values(null,'{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                 usuario._Nombre, usuario._Contrasenia, usuario._ApellidoP, usuario._ApellidoM, usuario._FechaNacimiento, usuario._RFC, usuario._Id_Tipo));
        }

        public void Mostrar(DataGridView tabla, string dato)
        {
            tabla.DataSource = c.Mostrar(string.Format("select * from usuarios where nombre like '%{0}%'", dato), "usuarios").Tables["usuarios"];
            tabla.AutoResizeColumns();
        }

        public string Editar(Usuario usuario)
        {
            return c.Comando(string.Format("update usuarios set nombre='{0}', contrasenia='{1}', apellidop='{2}', apellidom='{3}', fechanacimiento='{4}', rfc='{5}', id_tipo='{6}' where idusuario='{7}'", usuario._Nombre, usuario._Contrasenia, usuario._ApellidoP, usuario._ApellidoM, usuario._FechaNacimiento, usuario._RFC, usuario._Id_Tipo, usuario._IdUsuario));
        }

        public string Borrar(Usuario usuario)
        {
            string r = "";
            DialogResult rs = MessageBox.Show("Está seguro de eliminar " + usuario._Nombre, "Atencion!", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                r = c.Comando(string.Format("delete from usuarios where idusuario = {0}", usuario._IdUsuario));
            }
            return r;
        }

        public List<DatosPermiso> LlenarCombo()
        {
            return c.LlenarCombo("select id, nombre from permisos");
        }
    }
}
