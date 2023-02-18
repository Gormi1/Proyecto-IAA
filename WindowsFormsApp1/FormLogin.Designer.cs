
namespace WindowsFormsApp1
{
    partial class FormLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.UsuarioTxt = new System.Windows.Forms.TextBox();
            this.ContraseñaTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkContraseña = new System.Windows.Forms.LinkLabel();
            this.LoginBttn = new System.Windows.Forms.Button();
            this.minimizarbttn = new System.Windows.Forms.PictureBox();
            this.CerrarBttn = new System.Windows.Forms.PictureBox();
            this.ErrorMsglbl = new System.Windows.Forms.Label();
            this.LinkRegistro = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizarbttn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarBttn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 330);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(66, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(780, 330);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.LightGray;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 336;
            this.lineShape2.X2 = 698;
            this.lineShape2.Y1 = 191;
            this.lineShape2.Y2 = 191;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.LightGray;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 337;
            this.lineShape1.X2 = 699;
            this.lineShape1.Y1 = 112;
            this.lineShape1.Y2 = 112;
            // 
            // UsuarioTxt
            // 
            this.UsuarioTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.UsuarioTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsuarioTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioTxt.ForeColor = System.Drawing.Color.DimGray;
            this.UsuarioTxt.Location = new System.Drawing.Point(336, 91);
            this.UsuarioTxt.Name = "UsuarioTxt";
            this.UsuarioTxt.Size = new System.Drawing.Size(363, 20);
            this.UsuarioTxt.TabIndex = 2;
            this.UsuarioTxt.Text = "Usuario";
            this.UsuarioTxt.Enter += new System.EventHandler(this.UsuarioTxt_Enter);
            this.UsuarioTxt.Leave += new System.EventHandler(this.UsuarioTxt_Leave);
            // 
            // ContraseñaTxt
            // 
            this.ContraseñaTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.ContraseñaTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ContraseñaTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContraseñaTxt.ForeColor = System.Drawing.Color.DimGray;
            this.ContraseñaTxt.Location = new System.Drawing.Point(336, 170);
            this.ContraseñaTxt.Name = "ContraseñaTxt";
            this.ContraseñaTxt.Size = new System.Drawing.Size(363, 20);
            this.ContraseñaTxt.TabIndex = 3;
            this.ContraseñaTxt.Text = "Contraseña";
            this.ContraseñaTxt.Enter += new System.EventHandler(this.ContraseñaTxt_Enter);
            this.ContraseñaTxt.Leave += new System.EventHandler(this.ContraseñaTxt_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(472, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login";
            // 
            // linkContraseña
            // 
            this.linkContraseña.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.linkContraseña.AutoSize = true;
            this.linkContraseña.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkContraseña.LinkColor = System.Drawing.Color.LightGray;
            this.linkContraseña.Location = new System.Drawing.Point(432, 278);
            this.linkContraseña.Name = "linkContraseña";
            this.linkContraseña.Size = new System.Drawing.Size(168, 17);
            this.linkContraseña.TabIndex = 5;
            this.linkContraseña.TabStop = true;
            this.linkContraseña.Text = "¿Perdiste tu contraseña?";
            this.linkContraseña.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkContraseña_LinkClicked);
            // 
            // LoginBttn
            // 
            this.LoginBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.LoginBttn.FlatAppearance.BorderSize = 0;
            this.LoginBttn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.LoginBttn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.LoginBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBttn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBttn.ForeColor = System.Drawing.Color.LightGray;
            this.LoginBttn.Location = new System.Drawing.Point(335, 235);
            this.LoginBttn.Name = "LoginBttn";
            this.LoginBttn.Size = new System.Drawing.Size(364, 40);
            this.LoginBttn.TabIndex = 6;
            this.LoginBttn.Text = "Acceder";
            this.LoginBttn.UseVisualStyleBackColor = false;
            this.LoginBttn.Click += new System.EventHandler(this.LoginBttn_Click);
            // 
            // minimizarbttn
            // 
            this.minimizarbttn.Image = ((System.Drawing.Image)(resources.GetObject("minimizarbttn.Image")));
            this.minimizarbttn.Location = new System.Drawing.Point(731, 3);
            this.minimizarbttn.Name = "minimizarbttn";
            this.minimizarbttn.Size = new System.Drawing.Size(20, 20);
            this.minimizarbttn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizarbttn.TabIndex = 7;
            this.minimizarbttn.TabStop = false;
            this.minimizarbttn.Click += new System.EventHandler(this.minimizarbttn_Click);
            // 
            // CerrarBttn
            // 
            this.CerrarBttn.Image = ((System.Drawing.Image)(resources.GetObject("CerrarBttn.Image")));
            this.CerrarBttn.Location = new System.Drawing.Point(757, 3);
            this.CerrarBttn.Name = "CerrarBttn";
            this.CerrarBttn.Size = new System.Drawing.Size(20, 20);
            this.CerrarBttn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CerrarBttn.TabIndex = 8;
            this.CerrarBttn.TabStop = false;
            this.CerrarBttn.Click += new System.EventHandler(this.CerrarBttn_Click);
            // 
            // ErrorMsglbl
            // 
            this.ErrorMsglbl.AutoSize = true;
            this.ErrorMsglbl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorMsglbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.ErrorMsglbl.Image = ((System.Drawing.Image)(resources.GetObject("ErrorMsglbl.Image")));
            this.ErrorMsglbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ErrorMsglbl.Location = new System.Drawing.Point(334, 199);
            this.ErrorMsglbl.Name = "ErrorMsglbl";
            this.ErrorMsglbl.Size = new System.Drawing.Size(97, 16);
            this.ErrorMsglbl.TabIndex = 9;
            this.ErrorMsglbl.Text = "Error Al Conectar";
            this.ErrorMsglbl.Visible = false;
            // 
            // LinkRegistro
            // 
            this.LinkRegistro.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.LinkRegistro.AutoSize = true;
            this.LinkRegistro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkRegistro.LinkColor = System.Drawing.Color.LightGray;
            this.LinkRegistro.Location = new System.Drawing.Point(536, 304);
            this.LinkRegistro.Name = "LinkRegistro";
            this.LinkRegistro.Size = new System.Drawing.Size(105, 17);
            this.LinkRegistro.TabIndex = 10;
            this.LinkRegistro.TabStop = true;
            this.LinkRegistro.Text = "Registrate aquí";
            this.LinkRegistro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkRegistro_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(377, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "¿No tienes una cuenta?";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.LinkRegistro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ErrorMsglbl);
            this.Controls.Add(this.CerrarBttn);
            this.Controls.Add(this.minimizarbttn);
            this.Controls.Add(this.LoginBttn);
            this.Controls.Add(this.linkContraseña);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ContraseñaTxt);
            this.Controls.Add(this.UsuarioTxt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormLogin_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizarbttn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarBttn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.TextBox UsuarioTxt;
        private System.Windows.Forms.TextBox ContraseñaTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkContraseña;
        private System.Windows.Forms.Button LoginBttn;
        private System.Windows.Forms.PictureBox minimizarbttn;
        private System.Windows.Forms.PictureBox CerrarBttn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ErrorMsglbl;
        private System.Windows.Forms.LinkLabel LinkRegistro;
        private System.Windows.Forms.Label label2;
    }
}

