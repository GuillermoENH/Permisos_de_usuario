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
    public class ManejadorHerramientas
    {
        Conexion c = new Conexion("localhost", "root", "12345", "agenciaautomotriz", 3306);
        public string Guardar(Herramienta herramienta)
        {
            return c.Comando(string.Format("insert into herramientas values(null,'{0}','{1}','{2}','{3}','{4}')",
                 herramienta._CodigoHerramienta, herramienta._Nombre, herramienta._Medida, herramienta._Marca, herramienta._Descripcion));
        }

        public void Mostrar(DataGridView tabla, string dato)
        {
            tabla.DataSource = c.Mostrar(string.Format("select * from herramientas where nombre like '%{0}%'", dato), "herramientas").Tables["herramientas"];
            tabla.AutoResizeColumns();
        }

        public string Editar(Herramienta herramienta)
        {
            return c.Comando(string.Format("update herramientas set CodigoHerramienta='{0}', nombre='{1}', medida='{2}', marca='{3}', descripcion='{4}' where idherramienta='{5}'", herramienta._CodigoHerramienta, herramienta._Nombre, herramienta._Medida, herramienta._Marca, herramienta._Descripcion, herramienta._IdHerramienta));
        }

        public string Borrar(Herramienta herramienta)
        {
            string r = "";
            DialogResult rs = MessageBox.Show("Está seguro de eliminar " + herramienta._Nombre, "Atencion!", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                r = c.Comando(string.Format("delete from herramientas where IdHerramienta = {0}", herramienta._IdHerramienta));
            }
            return r;
        }
    }
}
