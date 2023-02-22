using Common.cache;
using Domain_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class USB : Form
    {
        public List<UsbInfo> l;
        public USB()
        {
            InitializeComponent();
        }

        private void USB_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var drives = DriveInfo.GetDrives().Where(drive => drive.IsReady && drive.DriveType == DriveType.Removable);
            if (drives.FirstOrDefault() != null)
            {
                FormPrincipal mainMenu = new FormPrincipal();
                MessageBox.Show("Welcome " + UserLoginCache.Nombre);
                mainMenu.Show();
                this.Hide();
            }
            else
            {
                FormLogin login = new FormLogin();
                if (MessageBox.Show("No se encontró la llave", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK) { 
                    this.Close();
                }

            }

        }
    }
}
