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
    public class ManejadorProducto
    {
        Conexion c = new Conexion("localhost", "root", "12345", "agenciaautomotriz", 3306);
        public string Guardar(Producto producto)
        {
            return c.Comando(string.Format("insert into producto values(null,'{0}','{1}','{2}','{3}')",
                 producto._Codigobarras, producto._Nombre, producto._Descripcion, producto._Marca));
        }

        public void Mostrar(DataGridView tabla, string dato)
        {
            tabla.DataSource = c.Mostrar(string.Format("select * from producto where nombre like '%{0}%'", dato), "productos").Tables["productos"];
            tabla.AutoResizeColumns();
        }

        public string Editar(Producto producto)
        {
            return c.Comando(string.Format("update producto set codigobarras='{0}', nombre='{1}', descripcion='{2}', marca='{3}' where idproducto='{4}'", producto._Codigobarras, producto._Nombre, producto._Descripcion, producto._Marca, producto._IdProducto));
        }

        public string Borrar(Producto producto)
        {
            string r = "";
            DialogResult rs = MessageBox.Show("Está seguro de eliminar " + producto._Nombre, "Atencion!", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                r = c.Comando(string.Format("delete from producto where idproducto = {0}", producto._IdProducto));
            }
            return r;
        }
    }
}
