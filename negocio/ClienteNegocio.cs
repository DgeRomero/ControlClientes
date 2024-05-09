using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class ClienteNegocio
    {
        //select U.nombre, precio, admin, A.Descripcion from ARTICULOS A, USERS U where U.id = 1
        public List<Cliente> listar()
        {
            List<Cliente> lista = new List<Cliente>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select U.nombre Nombre, Precio, A.Descripcion Articulos, U.Admin Pagado, U.Id Id from ARTICULOS A, USERS U");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Cliente aux = new Cliente();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Articulos = (string)datos.Lector["Articulos"];
                    aux.Pagado = (bool)datos.Lector["Pagado"];
                    aux.Precio = (decimal)datos.Lector["Precio"];

                    lista.Add(aux);
                }
                
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            } 
        }
    }
}
