using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejadorPermisos
{
    public class ManejadorLogin
    {
        LoginDatos _login = new LoginDatos();
        public int ObtenerLogins(string user, string password)
        {
            int contar = 0;
            try
            {
                contar = _login.ObtenerLogins(user, password);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fallo el login" + ex.Message);
            }
            return contar;
        }
    }
}
