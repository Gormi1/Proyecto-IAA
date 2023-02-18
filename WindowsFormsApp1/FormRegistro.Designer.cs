
namespace WindowsFormsApp1
{
    partial class FormRegistro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistro));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoginBttn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NombreTxt = new System.Windows.Forms.TextBox();
            this.ContraseñaTxt = new System.Windows.Forms.TextBox();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape7 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape6 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.EmailTxt = new System.Windows.Forms.TextBox();
            this.ApellidosTxt = new System.Windows.Forms.TextBox();
            this.TeléfonoTxt = new System.Windows.Forms.TextBox();
            this.UsuarioTxt = new System.Windows.Forms.TextBox();
            this.DirecciónTxt = new System.Windows.Forms.TextBox();
            this.CerrarBttn = new System.Windows.Forms.PictureBox();
            this.minimizarbttn = new System.Windows.Forms.PictureBox();
            this.CargoCB = new System.Windows.Forms.ComboBox();
            this.LinkRegistro = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.ErrorMsglbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarBttn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizarbttn)).BeginInit();
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
            this.panel1.TabIndex = 1;
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
            this.LoginBttn.TabIndex = 8;
            this.LoginBttn.Text = "Registrarse";
            this.LoginBttn.UseVisualStyleBackColor = false;
            this.LoginBttn.Click += new System.EventHandler(this.LoginBttn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(455, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "Registro";
            // 
            // NombreTxt
            // 
            this.NombreTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.NombreTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NombreTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreTxt.ForeColor = System.Drawing.Color.DimGray;
            this.NombreTxt.Location = new System.Drawing.Point(295, 54);
            this.NombreTxt.Name = "NombreTxt";
            this.NombreTxt.Size = new System.Drawing.Size(190, 20);
            this.NombreTxt.TabIndex = 9;
            this.NombreTxt.Text = "Nombre(s)";
            this.NombreTxt.Enter += new System.EventHandler(this.NombreTxt_Enter);
            this.NombreTxt.Leave += new System.EventHandler(this.NombreTxt_Leave);
            // 
            // ContraseñaTxt
            // 
            this.ContraseñaTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.ContraseñaTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ContraseñaTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContraseñaTxt.ForeColor = System.Drawing.Color.DimGray;
            this.ContraseñaTxt.Location = new System.Drawing.Point(535, 97);
            this.ContraseñaTxt.Name = "ContraseñaTxt";
            this.ContraseñaTxt.Size = new System.Drawing.Size(190, 20);
            this.ContraseñaTxt.TabIndex = 10;
            this.ContraseñaTxt.Text = "Contraseña";
            this.ContraseñaTxt.Enter += new System.EventHandler(this.ContraseñaTxt_Enter);
            this.ContraseñaTxt.Leave += new System.EventHandler(this.ContraseñaTxt_Leave);
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.LightGray;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 291;
            this.lineShape1.X2 = 487;
            this.lineShape1.Y1 = 77;
            this.lineShape1.Y2 = 77;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape7,
            this.lineShape6,
            this.lineShape5,
            this.lineShape4,
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(780, 330);
            this.shapeContainer1.TabIndex = 11;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape7
            // 
            this.lineShape7.BorderColor = System.Drawing.Color.LightGray;
            this.lineShape7.Name = "lineShape7";
            this.lineShape7.X1 = 293;
            this.lineShape7.X2 = 489;
            this.lineShape7.Y1 = 198;
            this.lineShape7.Y2 = 198;
            // 
            // lineShape6
            // 
            this.lineShape6.BorderColor = System.Drawing.Color.LightGray;
            this.lineShape6.Name = "lineShape6";
            this.lineShape6.X1 = 531;
            this.lineShape6.X2 = 727;
            this.lineShape6.Y1 = 159;
            this.lineShape6.Y2 = 159;
            // 
            // lineShape5
            // 
            this.lineShape5.BorderColor = System.Drawing.Color.LightGray;
            this.lineShape5.Name = "lineShape5";
            this.lineShape5.X1 = 291;
            this.lineShape5.X2 = 487;
            this.lineShape5.Y1 = 159;
            this.lineShape5.Y2 = 159;
            // 
            // lineShape4
            // 
            this.lineShape4.BorderColor = System.Drawing.Color.LightGray;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 291;
            this.lineShape4.X2 = 487;
            this.lineShape4.Y1 = 118;
            this.lineShape4.Y2 = 118;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.Color.LightGray;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 531;
            this.lineShape3.X2 = 727;
            this.lineShape3.Y1 = 118;
            this.lineShape3.Y2 = 118;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.LightGray;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 531;
            this.lineShape2.X2 = 727;
            this.lineShape2.Y1 = 77;
            this.lineShape2.Y2 = 77;
            // 
            // EmailTxt
            // 
            this.EmailTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.EmailTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTxt.ForeColor = System.Drawing.Color.DimGray;
            this.EmailTxt.Location = new System.Drawing.Point(295, 97);
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.Size = new System.Drawing.Size(190, 20);
            this.EmailTxt.TabIndex = 12;
            this.EmailTxt.Text = "E-mail";
            this.EmailTxt.Enter += new System.EventHandler(this.EmailTxt_Enter);
            this.EmailTxt.Leave += new System.EventHandler(this.EmailTxt_Leave);
            // 
            // ApellidosTxt
            // 
            this.ApellidosTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.ApellidosTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ApellidosTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApellidosTxt.ForeColor = System.Drawing.Color.DimGray;
            this.ApellidosTxt.Location = new System.Drawing.Point(535, 54);
            this.ApellidosTxt.Name = "ApellidosTxt";
            this.ApellidosTxt.Size = new System.Drawing.Size(190, 20);
            this.ApellidosTxt.TabIndex = 13;
            this.ApellidosTxt.Text = "Apellidos";
            this.ApellidosTxt.Enter += new System.EventHandler(this.ApellidosTxt_Enter);
            this.ApellidosTxt.Leave += new System.EventHandler(this.ApellidosTxt_Leave);
            // 
            // TeléfonoTxt
            // 
            this.TeléfonoTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.TeléfonoTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TeléfonoTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeléfonoTxt.ForeColor = System.Drawing.Color.DimGray;
            this.TeléfonoTxt.Location = new System.Drawing.Point(535, 138);
            this.TeléfonoTxt.Name = "TeléfonoTxt";
            this.TeléfonoTxt.Size = new System.Drawing.Size(190, 20);
            this.TeléfonoTxt.TabIndex = 15;
            this.TeléfonoTxt.Text = "Télefono";
            this.TeléfonoTxt.Enter += new System.EventHandler(this.TeléfonoTxt_Enter);
            this.TeléfonoTxt.Leave += new System.EventHandler(this.TeléfonoTxt_Leave);
            // 
            // UsuarioTxt
            // 
            this.UsuarioTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.UsuarioTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsuarioTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioTxt.ForeColor = System.Drawing.Color.DimGray;
            this.UsuarioTxt.Location = new System.Drawing.Point(295, 138);
            this.UsuarioTxt.Name = "UsuarioTxt";
            this.UsuarioTxt.Size = new System.Drawing.Size(190, 20);
            this.UsuarioTxt.TabIndex = 14;
            this.UsuarioTxt.Text = "Usuario";
            this.UsuarioTxt.Enter += new System.EventHandler(this.UsuarioTxt_Enter);
            this.UsuarioTxt.Leave += new System.EventHandler(this.UsuarioTxt_Leave);
            // 
            // DirecciónTxt
            // 
            this.DirecciónTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.DirecciónTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DirecciónTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirecciónTxt.ForeColor = System.Drawing.Color.DimGray;
            this.DirecciónTxt.Location = new System.Drawing.Point(295, 176);
            this.DirecciónTxt.Name = "DirecciónTxt";
            this.DirecciónTxt.Size = new System.Drawing.Size(190, 20);
            this.DirecciónTxt.TabIndex = 16;
            this.DirecciónTxt.Text = "Dirección";
            this.DirecciónTxt.Enter += new System.EventHandler(this.DirecciónTxt_Enter);
            this.DirecciónTxt.Leave += new System.EventHandler(this.DirecciónTxt_Leave);
            // 
            // CerrarBttn
            // 
            this.CerrarBttn.Image = ((System.Drawing.Image)(resources.GetObject("CerrarBttn.Image")));
            this.CerrarBttn.Location = new System.Drawing.Point(757, 3);
            this.CerrarBttn.Name = "CerrarBttn";
            this.CerrarBttn.Size = new System.Drawing.Size(20, 20);
            this.CerrarBttn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CerrarBttn.TabIndex = 19;
            this.CerrarBttn.TabStop = false;
            this.CerrarBttn.Click += new System.EventHandler(this.CerrarBttn_Click);
            // 
            // minimizarbttn
            // 
            this.minimizarbttn.Image = ((System.Drawing.Image)(resources.GetObject("minimizarbttn.Image")));
            this.minimizarbttn.Location = new System.Drawing.Point(731, 3);
            this.minimizarbttn.Name = "minimizarbttn";
            this.minimizarbttn.Size = new System.Drawing.Size(20, 20);
            this.minimizarbttn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizarbttn.TabIndex = 18;
            this.minimizarbttn.TabStop = false;
            this.minimizarbttn.Click += new System.EventHandler(this.minimizarbttn_Click);
            // 
            // CargoCB
            // 
            this.CargoCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.CargoCB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CargoCB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CargoCB.ForeColor = System.Drawing.Color.DimGray;
            this.CargoCB.FormattingEnabled = true;
            this.CargoCB.Items.AddRange(new object[] {
            "Gerente",
            "Vendedor",
            "Administrador"});
            this.CargoCB.Location = new System.Drawing.Point(535, 173);
            this.CargoCB.Name = "CargoCB";
            this.CargoCB.Size = new System.Drawing.Size(190, 29);
            this.CargoCB.TabIndex = 20;
            this.CargoCB.Text = "Cargo";
            // 
            // LinkRegistro
            // 
            this.LinkRegistro.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.LinkRegistro.AutoSize = true;
            this.LinkRegistro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkRegistro.LinkColor = System.Drawing.Color.LightGray;
            this.LinkRegistro.Location = new System.Drawing.Point(541, 288);
            this.LinkRegistro.Name = "LinkRegistro";
            this.LinkRegistro.Size = new System.Drawing.Size(97, 17);
            this.LinkRegistro.TabIndex = 21;
            this.LinkRegistro.TabStop = true;
            this.LinkRegistro.Text = "haz click aquí";
            this.LinkRegistro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkRegistro_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(384, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "¿Ya tienes una cuenta?";
            // 
            // ErrorMsglbl
            // 
            this.ErrorMsglbl.AutoSize = true;
            this.ErrorMsglbl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorMsglbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.ErrorMsglbl.Image = ((System.Drawing.Image)(resources.GetObject("ErrorMsglbl.Image")));
            this.ErrorMsglbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ErrorMsglbl.Location = new System.Drawing.Point(295, 205);
            this.ErrorMsglbl.Name = "ErrorMsglbl";
            this.ErrorMsglbl.Size = new System.Drawing.Size(97, 16);
            this.ErrorMsglbl.TabIndex = 23;
            this.ErrorMsglbl.Text = "Error Al Conectar";
            this.ErrorMsglbl.Visible = false;
            // 
            // FormRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.ErrorMsglbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LinkRegistro);
            this.Controls.Add(this.CargoCB);
            this.Controls.Add(this.CerrarBttn);
            this.Controls.Add(this.minimizarbttn);
            this.Controls.Add(this.DirecciónTxt);
            this.Controls.Add(this.TeléfonoTxt);
            this.Controls.Add(this.UsuarioTxt);
            this.Controls.Add(this.ApellidosTxt);
            this.Controls.Add(this.EmailTxt);
            this.Controls.Add(this.ContraseñaTxt);
            this.Controls.Add(this.NombreTxt);
            this.Controls.Add(this.LoginBttn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegistro";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRegistro";
            this.Load += new System.EventHandler(this.FormRegistro_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarBttn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizarbttn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button LoginBttn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NombreTxt;
        private System.Windows.Forms.TextBox ContraseñaTxt;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.TextBox EmailTxt;
        private System.Windows.Forms.TextBox ApellidosTxt;
        private System.Windows.Forms.TextBox TeléfonoTxt;
        private System.Windows.Forms.TextBox UsuarioTxt;
        private System.Windows.Forms.TextBox DirecciónTxt;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape6;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape7;
        private System.Windows.Forms.PictureBox CerrarBttn;
        private System.Windows.Forms.PictureBox minimizarbttn;
        private System.Windows.Forms.ComboBox CargoCB;
        private System.Windows.Forms.LinkLabel LinkRegistro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ErrorMsglbl;
    }
}