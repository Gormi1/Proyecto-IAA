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
    public partial class FormRecuperarContrasenia : Form
    {
        public FormRecuperarContrasenia()
        {
            InitializeComponent();
        }

        private void BttnSend_Click(object sender, EventArgs e)
        {
            var user = new ModelUser();
            var result = user.recoverPassword(TxtUserRequest.Text);
            lblResult.Text = result;
        }
    }
}
