using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Common.cache;

namespace DataAccess_
{
    public class DataProducto : SqlPrincipalConnection
    {
        private SqlPrincipalConnection conexion = new SqlPrincipalConnection();
        SqlCommand comando = new SqlCommand();
        SqlDataReader Leer;
        DataTable tabla = new DataTable();
        //conexiones y metodos conectados al Sql principal
        public DataTable MostrarProductos()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Select * from Otros";
            Leer = comando.ExecuteReader();
            tabla.Load(Leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void InsertarProductos(string nombre, double precio)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into Otros values('" + nombre + "', " + precio + ")";
            comando.ExecuteNonQuery();
        }

        public void EditarProducto(string nombre, double precio, int CódigoVenta)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "UPDATE Otros SET Nombre = '" + nombre + "', Precio = " + precio 
                + " where Código_venta =" + CódigoVenta + "";
            comando.ExecuteNonQuery();
        }
        public void EliminarProducto(int CódigoVenta)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Delete from Otros where Código_venta = " + CódigoVenta +"";
            comando.ExecuteNonQuery();
        }
    }
}
