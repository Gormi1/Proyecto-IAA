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
    public partial class FormProductos : Form
    {
        ModelProducto Producto = new ModelProducto();
        private string idProducto = null;
        private bool Editar = false;
        public FormProductos()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            MostrarProductos();
            ManagePermisions();
        }
        private void MostrarProductos()
        {

            ModelProducto ProductoRefresh = new ModelProducto();
            ProductoDGV.DataSource = ProductoRefresh.MostrarProd();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //insertar
            if (Editar == false)
            {
                try
                {
                    Producto.InsertarProducto(NombreTxt.Text, PrecioTxt.Text);
                    MessageBox.Show("Elemento agregado Correctamente.");
                    MostrarProductos();
                    LimpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se ha podido agregar elemnto por: " + ex);
                }
            }
            //editar
            if (Editar == true)
            {
                try
                {
                    Producto.EditarProducto(NombreTxt.Text, PrecioTxt.Text, idProducto);
                    MessageBox.Show("Elemento Editados Correctamente.");
                    MostrarProductos();
                    LimpiarForm();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se ha podido agregar elemnto por: " + ex);
                }
            }
        }

        private void EditarBttn_Click(object sender, EventArgs e)
        {
            if (ProductoDGV.SelectedRows.Count > 0)
            {
                Editar = true;
                NombreTxt.Text = ProductoDGV.CurrentRow.Cells["Nombre"].Value.ToString();
                PrecioTxt.Text = ProductoDGV.CurrentRow.Cells["Precio"].Value.ToString();
                idProducto = ProductoDGV.CurrentRow.Cells["Código_venta"].Value.ToString();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void LimpiarForm()
        {
            NombreTxt.Text = "Nombre";
            PrecioTxt.Text = "Precio";
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

        private void EliminarBttn_Click(object sender, EventArgs e)
        {
            if (ProductoDGV.SelectedRows.Count > 0)
            {
                idProducto = ProductoDGV.CurrentRow.Cells["Código_venta"].Value.ToString();
                Producto.EliminarProducto(idProducto);
                MessageBox.Show("Fila elimanada correctamente");
                MostrarProductos();
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
    }
}
