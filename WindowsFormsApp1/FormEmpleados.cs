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

namespace WindowsFormsApp1
{
    public partial class FormEmpleados : Form
    {
        ModelUser user = new ModelUser();
        public FormEmpleados()
        {
            InitializeComponent();
        }

        private void FormEmpleados_Load(object sender, EventArgs e)
        {
            MostrarEmpleados();
        }

        private void MostrarEmpleados()
        {
            VideojuegosDGV.DataSource = user.MostrarEmple();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
