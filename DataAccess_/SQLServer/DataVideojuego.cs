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
    public class DataVideojuego : SqlPrincipalConnection
    {
        private SqlPrincipalConnection conexion = new SqlPrincipalConnection();
        SqlCommand comando = new SqlCommand();
        SqlDataReader Leer;
        DataTable tabla = new DataTable();

        public DataTable MostrarVideojuegos()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Select * from Videojuego";
            Leer = comando.ExecuteReader();
            tabla.Load(Leer);
            conexion.CerrarConexion();
            return tabla;
        }
        //Conexiones y metodos conectados a la base de datos principal
        public void InsertarVideojuegos(string nombre, double precio, 
            string genero, string distribuidora, string fisico)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into Videojuego values('" + nombre + "', " + precio + ", '" + genero 
                + "', '" + distribuidora + "', '" + fisico + "')";
            comando.ExecuteNonQuery();
        }

        public void EditarVideojuego(string nombre, double precio, string genero, 
            string distribuidora, string fisico, int códigoVenta)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "UPDATE Videojuego SET Nombre = '" + nombre + "', Precio = " 
                + precio + ", Genero = '" + genero + "', Distribuidora = '" + distribuidora
                + "', Físico = '" + fisico + "' where Código_venta = " + códigoVenta + "";
            comando.ExecuteNonQuery();
        }

        public void EliminarVideojuego(int códigoVenta)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Delete from Videojuego where Código_venta = " + códigoVenta + "";
            comando.ExecuteNonQuery();
        }
    }
}
