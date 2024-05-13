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
        public List<Cliente> listar(string id = "")
        {
            List<Cliente> lista = new List<Cliente>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                if(id != "")
                    datos.setearConsulta("select Nombre, Articulos, Precio, Pagado, Id from CLIENTES where Id =" + id);
                else
                    datos.setearConsulta("select Nombre, Articulos, Precio, Pagado, Id from CLIENTES");
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
        public void agregar(Cliente nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into CLIENTES (Nombre, Articulos, Precio, Pagado) values (@nombre, @articulos, @precio, @pagado)");
                datos.setearParametro("@nombre", nuevo.Nombre);
                datos.setearParametro("@articulos", nuevo.Articulos);
                datos.setearParametro("@precio", nuevo.Precio);
                datos.setearParametro("@pagado", nuevo.Pagado);
                datos.ejecutarAccion();
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
        public void modificar(Cliente client)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update CLIENTES set Nombre = @nombre, Articulos = @articulos, Precio = @precio, Pagado = @pagado where Id = @id");
                datos.setearParametro("@nombre", client.Nombre);
                datos.setearParametro("@articulos", client.Articulos);
                datos.setearParametro("@precio", client.Precio);
                datos.setearParametro("@pagado", client.Pagado);
                datos.setearParametro("@id", client.Id);

                datos.ejecutarAccion();
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
        public void eliminar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("delete from CLIENTES where Id = @id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        
    }
}
