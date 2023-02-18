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
    public class ModelProducto
    {
        private DataProducto dataProducto = new DataProducto();
        //mostrar tabla de Sql
        public DataTable MostrarProd()
        {
            DataTable tabla = new DataTable();
            tabla = dataProducto.MostrarProductos();
            return tabla;
        }
        //Insertar datos en sql
        public void InsertarProducto(string nombre, string precio)
        {
            dataProducto.InsertarProductos(nombre, Convert.ToDouble(precio));
        }
        //Editar datos en sql
        public void EditarProducto(string nombre, string precio, string códigoVenta)
        {
            dataProducto.EditarProducto(nombre, Convert.ToDouble(precio), Convert.ToInt32(códigoVenta));
        }
        //Eliminar datos en sql
        public void EliminarProducto(string códigoVenta)
        {
            dataProducto.EliminarProducto(Convert.ToInt32(códigoVenta));
        }
    }
}
