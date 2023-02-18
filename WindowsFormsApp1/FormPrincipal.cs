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
using Common.cache;

namespace WindowsFormsApp1
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            LoadUserData();
            ManagePermisions();
        }

        private void ManagePermisions()
        {
            if (UserLoginCache.Cargo == Cargos.Administrador)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                EmpleadosBttn.Enabled = true;
            }
            if (UserLoginCache.Cargo == Cargos.Gerente)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                EmpleadosBttn.Enabled = false;
            }
            if (UserLoginCache.Cargo == Cargos.Vendedor)
            {
                button1.Enabled = false;
                button2.Enabled = true;
                button3.Enabled = true;
                EmpleadosBttn.Enabled = false;
            }
        }
        private void LoadUserData()
        {
            Nombrelbl.Text = UserLoginCache.Nombre;
            Emaillbl.Text = UserLoginCache.Email;
            CargoLbl.Text = UserLoginCache.Cargo;
        }

        #region Funcionalidades del formulario
        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(50, 40, 45));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

       

        private void CerrarBttn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("estas seguro de querer salir?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            Application.Exit();
        }

        //Captura de la posición y tamaño de la pantalla
        int lx, ly, sw, sh;

        private void MaximizarBttn_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            MaximizarBttn.Visible = false;
            RestaurarBttn.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void RestaurarBttn_Click(object sender, EventArgs e)
        {
            MaximizarBttn.Visible = true;
            RestaurarBttn.Visible = false;
            this.Size = new Size(sw,sh);
            this.Location = new Point(lx, ly);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormSobreMi>();
            button1.BackColor = Color.FromArgb(55, 45, 50);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormVideojuegos>();
            button2.BackColor = Color.FromArgb(55, 45, 50);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormProductos>();
            button3.BackColor = Color.FromArgb(55, 45, 50);
        }

        private void panelBarraDeTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void LogOutBttn_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            if (MessageBox.Show("estas seguro de querer cerrar seción?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                this.Close();
                login.Show();
            }
                
        }

        private void EmpleadosBttn_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormEmpleados>();
            button3.BackColor = Color.FromArgb(55, 45, 50);
        }


        private void MinimizarBttn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion
        
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelFormularios.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelFormularios.Controls.Add(formulario);
                panelFormularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            else
            {
                formulario.BringToFront();
            }
        }
        private void CloseForms(Object sender,FormClosedEventArgs e)
        {
            if (Application.OpenForms["SubForm1"] == null)
                button1.BackColor = Color.FromArgb(50, 40, 45);
            if (Application.OpenForms["SubForm2"] == null)
                button2.BackColor = Color.FromArgb(50, 40, 45);
            if (Application.OpenForms["SubForm3"] == null)
                button3.BackColor = Color.FromArgb(50, 40, 45);
            if (Application.OpenForms["SubForm4"] == null)
                EmpleadosBttn.BackColor = Color.FromArgb(50, 40, 45);
        }
    }
}
