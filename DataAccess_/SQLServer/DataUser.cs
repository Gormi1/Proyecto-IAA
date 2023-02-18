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
    public class DataUser : SqlPrincipalConnection
    {
        private SqlPrincipalConnection conexion = new SqlPrincipalConnection();
        SqlCommand comando = new SqlCommand();
        SqlDataReader Leer;
        DataTable tabla = new DataTable();

        //metodo de inicio de sesión
        public bool Login(string user, string pass)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from Empleados where Usuario = @user and Contraseña_Encriptada = @pass";
            comando.Parameters.AddWithValue("@user", user);
            string passEncriptada = Encrypt.GetSha256(pass);
            comando.Parameters.AddWithValue("@pass", passEncriptada);
            comando.CommandType = CommandType.Text;
            SqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    UserLoginCache.id_Empleado = reader.GetInt32(0);
                    UserLoginCache.Usuario = reader.GetString(1);
                    UserLoginCache.Contraseña = reader.GetString(7);
                    UserLoginCache.Email = reader.GetString(2);
                    UserLoginCache.Nombre = reader.GetString(3);
                    UserLoginCache.Apellido = reader.GetString(4);
                    UserLoginCache.Telefono = reader.GetString(5);
                    UserLoginCache.Dirección = reader.GetString(6);
                    UserLoginCache.Cargo = reader.GetString(9);
                    UserLoginCache.Dirección = reader.GetString(8);
                }
                return true;
            }
            else
                return false;
        }
        //registro conectado a la base de datos principal
        public string Register(string user, string pass, string name, string lastname, string phone, string direction, string email, string cargo)
        {
            string passEncriptada = Encrypt.GetSha256(pass);
            conexion.AbrirConexion();

            string consulta = "Insert into Empleados([Usuario], [Email], [Nombre], [apellido], [Telefono], [Dirección], [Contraseña_Encriptada], [Contraseña], [Cargo]) " +
                "Values ('" + user + "', '" + email + "', '" + name + "', '" + lastname + "', '" + phone + "', '" + direction + "', '" + passEncriptada + "', '"+ pass + "', '" + cargo + "')";
            SqlCommand comandos = new SqlCommand(consulta, conexion.AbrirConexion());
            comandos.ExecuteNonQuery();

            conexion.CerrarConexion();
            return consulta;
        }

        public string recoverPassword(string userRequesting)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from Empleados where Usuario = @user or Email = @mail";
            comando.Parameters.AddWithValue("@user", userRequesting);
            comando.Parameters.AddWithValue("@mail", userRequesting);
            comando.CommandType = CommandType.Text;
            SqlDataReader reader = comando.ExecuteReader();

            if (reader.Read() == true)
            {
                string userName = reader.GetString(3);
                string userMail = reader.GetString(2);
                string accountPassword = reader.GetString(8);

                var mailService = new MailServices.SystemSupportMail();
                mailService.sendMail(
                    subject: "SYSTEM: petición de recuperación de contraseña",
                    body: "Hola, " + userName + "\n pediste recuperar tu contraseña\n" +
                    "tu actual contraseña es: " + accountPassword +
                    "\n pedimos que cambies tu contraseña lo mas antes posible cuando entres al sistema.",
                    recipientMail: new List<string> { userMail }
                    );
                conexion.CerrarConexion();
                return "Hola, " + userName + "\n pediste recuperar tu contraseña\n" +
                    "porfavor revisa tu correo ( " + userMail + " ) " +
                    "\n pedimos que cambies tu contraseña lo mas antes posible cuando entres al sistema.";
            }
            else {
                conexion.CerrarConexion();
                return "lo sentimos, no tiene una cuenta con este usuario o este correo electrónico";
            }
        }
        
        //metodo de Niveles de seguridad
        public void AnyMethod()
        {
            if(UserLoginCache.Cargo == Cargos.Administrador)
            {

            }
            if(UserLoginCache.Cargo == Cargos.Gerente || UserLoginCache.Cargo == Cargos.Vendedor)
            {

            }
        }
        //Metodo para Postrar La tabla desde sql
        public DataTable MostrarEmpleados()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Select * from Empleados";
            Leer = comando.ExecuteReader();
            tabla.Load(Leer);
            conexion.CerrarConexion();
            return tabla;
        }
        
    }
}

