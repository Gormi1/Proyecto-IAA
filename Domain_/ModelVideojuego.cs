using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess_;
using System.Data;
using System.Data.SqlClient;
using Common.cache;

namespace Domain_
{
    public class ModelVideojuego
    {
        private DataVideojuego dataVideojuego = new DataVideojuego();
        //mostrar datos de sql
        public DataTable MostrarVJ()
        {
            DataTable tabla = new DataTable();
            tabla = dataVideojuego.MostrarVideojuegos();
            return tabla;
        }
        //insertar datos de sql
        public void InsertarVideojuego(string nombre, string precio, string genero, string distribuidora, string fisico)
        {
            dataVideojuego.InsertarVideojuegos(nombre, Convert.ToDouble(precio), genero, distribuidora, fisico);
        }
        //editar datos de sql
        public void EditarVideojuego(string nombre, string precio, string genero, string distribuidora, 
            string fisico, string códigoVenta)
        {
            dataVideojuego.EditarVideojuego(nombre, Convert.ToDouble(precio), genero, distribuidora, fisico, 
                Convert.ToInt32(códigoVenta));
        }
        //eliminar datos de sql
        public void EliminarVideojuego(string códigoVenta)
        {
            dataVideojuego.EliminarVideojuego(Convert.ToInt32(códigoVenta));
        }
    }
}
