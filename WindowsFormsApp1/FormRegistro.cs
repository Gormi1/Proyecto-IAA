using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Domain_;

namespace WindowsFormsApp1
{
    public partial class FormRegistro : Form
    {
        public FormRegistro()
        {
            InitializeComponent();
        }

        private void CerrarBttn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizarbttn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormRegistro_Load(object sender, EventArgs e)
        {

        }

        private void LinkRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form Login = new FormLogin();
            Login.Show();
            this.Hide();
        }

        private void LoginBttn_Click(object sender, EventArgs e)
        {
            ModelUser User = new ModelUser();
            if(UsuarioTxt.Text != "Usuario" || ContraseñaTxt.Text != "Contraseña" || NombreTxt.Text != "Nombre(s)" ||
               ApellidosTxt.Text != "Apellidos" || TeléfonoTxt.Text != "Télefono" || DirecciónTxt.Text != "Dirección" ||
               EmailTxt.Text != "E-mail" || CargoCB.Text != "Cargo")
            {
                User.RegisterUser(UsuarioTxt.Text, ContraseñaTxt.Text, NombreTxt.Text, ApellidosTxt.Text, TeléfonoTxt.Text,
               DirecciónTxt.Text, EmailTxt.Text, CargoCB.Text);
                MessageBox.Show("Se ha registrado correctamente.");
            }
            else
            {
                msgError("Llene los datos correctamente por favor.");
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

        private void NombreTxt_Enter(object sender, EventArgs e)
        {
            if (NombreTxt.Text == "Nombre(s)")
            {
                NombreTxt.Text = "";
                NombreTxt.ForeColor = Color.LightGray;
            }
        }

        private void NombreTxt_Leave(object sender, EventArgs e)
        {
            if (NombreTxt.Text == "")
            {
                NombreTxt.Text = "Nombre(s)";
                NombreTxt.ForeColor = Color.DimGray;
            }
        }

        private void ApellidosTxt_Enter(object sender, EventArgs e)
        {
            if (ApellidosTxt.Text == "Apellidos")
            {
                ApellidosTxt.Text = "";
                ApellidosTxt.ForeColor = Color.LightGray;
            }
        }

        private void ApellidosTxt_Leave(object sender, EventArgs e)
        {
            if (ApellidosTxt.Text == "")
            {
                ApellidosTxt.Text = "Apellidos";
                ApellidosTxt.ForeColor = Color.DimGray;
            }
        }

        private void EmailTxt_Enter(object sender, EventArgs e)
        {
            if (EmailTxt.Text == "E-mail")
            {
                EmailTxt.Text = "";
                EmailTxt.ForeColor = Color.LightGray;
            }
        }

        private void EmailTxt_Leave(object sender, EventArgs e)
        {
            if (EmailTxt.Text == "")
            {
                EmailTxt.Text = "E-mail";
                EmailTxt.ForeColor = Color.DimGray;
            }
        }

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

        private void TeléfonoTxt_Enter(object sender, EventArgs e)
        {
            if (TeléfonoTxt.Text == "Télefono")
            {
                TeléfonoTxt.Text = "";
                TeléfonoTxt.ForeColor = Color.LightGray;
            }
        }

        private void TeléfonoTxt_Leave(object sender, EventArgs e)
        {
            if (TeléfonoTxt.Text == "")
            {
                TeléfonoTxt.Text = "Télefono";
                TeléfonoTxt.ForeColor = Color.DimGray;
            }
        }

        private void DirecciónTxt_Enter(object sender, EventArgs e)
        {
            if (DirecciónTxt.Text == "Dirección")
            {
                DirecciónTxt.Text = "";
                DirecciónTxt.ForeColor = Color.LightGray;
            }
        }

        private void DirecciónTxt_Leave(object sender, EventArgs e)
        {
            if (DirecciónTxt.Text == "")
            {
                DirecciónTxt.Text = "Dirección";
                DirecciónTxt.ForeColor = Color.DimGray;
            }
        }
        private void msgError(string msg)
        {
            ErrorMsglbl.Text = "      " + msg;
            ErrorMsglbl.Visible = true;
        }
    }
}
