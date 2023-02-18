using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Domain_;
using Common.cache;

namespace WindowsFormsApp1
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void UsuarioTxt_Enter(object sender, EventArgs e)
        {
            if (UsuarioTxt.Text == "Usuario")
            {
                UsuarioTxt.Text = "";
                UsuarioTxt.ForeColor = Color.LightGray;
            }
        }

        private void UsuarioTxt_Leave(object sender, EventArgs e)
        {
            if (UsuarioTxt.Text == "")
            {
                UsuarioTxt.Text = "Usuario";
                UsuarioTxt.ForeColor = Color.DimGray;
            }
        }

        private void ContraseñaTxt_Enter(object sender, EventArgs e)
        {
            if (ContraseñaTxt.Text == "Contraseña")
            {
                ContraseñaTxt.Text = "";
                ContraseñaTxt.ForeColor = Color.LightGray;
                ContraseñaTxt.UseSystemPasswordChar = true;

            }
        }

        private void ContraseñaTxt_Leave(object sender, EventArgs e)
        {
            if (ContraseñaTxt.Text == "")
            {
                ContraseñaTxt.Text = "Contraseña";
                ContraseñaTxt.ForeColor = Color.DimGray;
                ContraseñaTxt.UseSystemPasswordChar = false;
            }
        }

        private void CerrarBttn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizarbttn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void LoginBttn_Click(object sender, EventArgs e)
        {
            if (UsuarioTxt.Text != "Usuario")
            {
                if (ContraseñaTxt.Text != "Contraseña")
                {
                    ModelUser user = new ModelUser();
                    var validLogin = user.LoginUser(UsuarioTxt.Text, ContraseñaTxt.Text);
                    if (validLogin == true)
                    {
                        Form USB = new USB();
                        USB.Show();
                        USB.FormClosed += LogOut;
                        this.Hide();

                    }
                    else
                    {
                        msgError("El usuario o la contraseña son incorrectos.\n      pruebe de nuevo.");
                        ContraseñaTxt.Text = "Contraseña";
                        UsuarioTxt.Focus();
                    }
                }
                else { msgError("Porfavor ingrese su contraseña."); }
            }
            else { msgError("Porfavor ingrese su nombre de usuario."); }
        }
        private void msgError(string msg)
        {
            ErrorMsglbl.Text = "      " + msg;
            ErrorMsglbl.Visible = true;
        }

        private void LogOut(object sender, FormClosedEventArgs e)
        {
            ContraseñaTxt.Text = "Contraseña";
            ContraseñaTxt.UseSystemPasswordChar = false;
            UsuarioTxt.Text = "Usuario";
            ErrorMsglbl.Visible = false;
            this.Show();
        }

        private void LinkRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form Registro = new FormRegistro();
            Registro.Show();
            this.Hide();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void linkContraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var recuperarContrasenia = new FormRecuperarContrasenia();
            recuperarContrasenia.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
