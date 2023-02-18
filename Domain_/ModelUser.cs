using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccess_;
using Common.cache;

namespace Domain_
{
    public class ModelUser
    {
        private DataUser userData = new DataUser();
        //metodo de inicio de sesión
        public bool LoginUser(string user, string pass)
        {
            return userData.Login(user, pass);
        }
        //metodo de recuperacion de contraseña
        public string recoverPassword(string userRequesting)
        {
            return userData.recoverPassword(userRequesting);
        }
        //metodo de registro a pa base de datos principal
        public string RegisterUser(string user, string pass,  string name, 
            string lastname, string phone, string direction, string email, string cargo)
        {
            return userData.Register(user, pass, name, lastname, phone, direction, email, cargo);
        }
       
        //Metodo para mostrar tabla de sql
        public DataTable MostrarEmple()
        {
            DataTable tabla = new DataTable();
            tabla = userData.MostrarEmpleados();
            return tabla;
        }

    }
}
