using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain_;
using Common.cache;

namespace WindowsFormsApp1
{
    public partial class FormVideojuegos : Form
    {
        ModelVideojuego videojuego = new ModelVideojuego();
        private string idVideojuego = null;
        private bool Editar = false;
        public FormVideojuegos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormVideojuegos_Load(object sender, EventArgs e)
        {
            MostrarVideojuegos();
            ManagePermisions();
        }

        private void MostrarVideojuegos()
        {

            ModelVideojuego videojuegoRefresh = new ModelVideojuego();
            VideojuegosDGV.DataSource = videojuegoRefresh.MostrarVJ();
        }

        
        private void EditarBttn_Click(object sender, EventArgs e)
        {
            if (VideojuegosDGV.SelectedRows.Count > 0)
            {
                Editar = true;
                NombreTxt.Text = VideojuegosDGV.CurrentRow.Cells["Nombre"].Value.ToString();
                PrecioTxt.Text = VideojuegosDGV.CurrentRow.Cells["Precio"].Value.ToString();
                GeneroTxt.Text = VideojuegosDGV.CurrentRow.Cells["Genero"].Value.ToString();
                DistribuidoraTxt.Text = VideojuegosDGV.CurrentRow.Cells["Distribuidora"].Value.ToString();
                FisicoCB.Text = VideojuegosDGV.CurrentRow.Cells["Físico"].Value.ToString();
                idVideojuego = VideojuegosDGV.CurrentRow.Cells["Código_venta"].Value.ToString();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void LimpiarForm()
        {
            NombreTxt.Clear();
            PrecioTxt.Clear();
            GeneroTxt.Clear();
            DistribuidoraTxt.Clear();
            FisicoCB.Text = "Es físico?";
        }

        private void NombreTxt_Enter(object sender, EventArgs e)
        {
            if (NombreTxt.Text == "Nombre")
            {
                NombreTxt.Text = "";
                NombreTxt.ForeColor = Color.LightGray;
            }
        }

        private void NombreTxt_Leave(object sender, EventArgs e)
        {
            if (NombreTxt.Text == "")
            {
                NombreTxt.Text = "Nombre";
                NombreTxt.ForeColor = Color.DimGray;
            }
        }

        private void PrecioTxt_Enter(object sender, EventArgs e)
        {
            if (PrecioTxt.Text == "Precio")
            {
                PrecioTxt.Text = "";
                PrecioTxt.ForeColor = Color.LightGray;
            }
        }

        private void PrecioTxt_Leave(object sender, EventArgs e)
        {
            if (PrecioTxt.Text == "")
            {
                PrecioTxt.Text = "Precio";
                PrecioTxt.ForeColor = Color.DimGray;
            }
        }

        private void GeneroTxt_Enter(object sender, EventArgs e)
        {
            if (GeneroTxt.Text == "Género")
            {
                GeneroTxt.Text = "";
                GeneroTxt.ForeColor = Color.LightGray;
            }
        }

        private void GeneroTxt_Leave(object sender, EventArgs e)
        {
            if (GeneroTxt.Text == "")
            {
                GeneroTxt.Text = "Género";
                GeneroTxt.ForeColor = Color.DimGray;
            }
        }

        private void DistribuidoraTxt_Enter(object sender, EventArgs e)
        {
            if (DistribuidoraTxt.Text == "Distribuidora")
            {
                DistribuidoraTxt.Text = "";
                DistribuidoraTxt.ForeColor = Color.LightGray;
            }
        }

        private void DistribuidoraTxt_Leave(object sender, EventArgs e)
        {
            if (DistribuidoraTxt.Text == "")
            {
                DistribuidoraTxt.Text = "Distribuidora";
                DistribuidoraTxt.ForeColor = Color.DimGray;
            }
        }

        private void FisicoCB_Enter(object sender, EventArgs e)
        {
            if (FisicoCB.Text == "Es físico?")
            {
                FisicoCB.Text = "";
                FisicoCB.ForeColor = Color.LightGray;
            }
        }

        private void FisicoCB_Leave(object sender, EventArgs e)
        {
            if (FisicoCB.Text == "")
            {
                FisicoCB.Text = "Es físico?";
                FisicoCB.ForeColor = Color.DimGray;
            }
        }

        private void EliminarBttn_Click(object sender, EventArgs e)
        {
            if (VideojuegosDGV.SelectedRows.Count > 0)
            {
                idVideojuego = VideojuegosDGV.CurrentRow.Cells["Código_venta"].Value.ToString();
                videojuego.EliminarVideojuego(idVideojuego);
                MessageBox.Show("Fila elimanada correctamente");
                MostrarVideojuegos();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void ManagePermisions()
        {
            if (UserLoginCache.Cargo == Cargos.Administrador)
            {
                GuardarBttn.Enabled = true;
                EditarBttn.Enabled = true;
                EliminarBttn.Enabled = true;
            }
            if (UserLoginCache.Cargo == Cargos.Gerente)
            {
                GuardarBttn.Enabled = true;
                EditarBttn.Enabled = true;
                EliminarBttn.Enabled = false;
            }
            if (UserLoginCache.Cargo == Cargos.Vendedor)
            {
                GuardarBttn.Enabled = false;
                EditarBttn.Enabled = false;
                EliminarBttn.Enabled = false;
            }
        }

        private void GuardarBttn_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    videojuego.InsertarVideojuego(NombreTxt.Text, PrecioTxt.Text, GeneroTxt.Text, DistribuidoraTxt.Text, FisicoCB.Text);
                    MessageBox.Show("Elemento agregado Correctamente.");
                    MostrarVideojuegos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se ha podido agregar elemnto por: " + ex);
                }
            }
            if (Editar == true)
            {
                try
                {
                    videojuego.EditarVideojuego(NombreTxt.Text, PrecioTxt.Text, GeneroTxt.Text, DistribuidoraTxt.Text, FisicoCB.Text, idVideojuego);
                    MessageBox.Show("Elemento Editado Correctamente.");
                    MostrarVideojuegos();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se ha podido Editar elemnto por: " + ex);
                }
            }
        }
    }
}
