
namespace WindowsFormsApp1
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelFormularios = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenú = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.EmpleadosBttn = new System.Windows.Forms.Button();
            this.LogOutBttn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CargoLbl = new System.Windows.Forms.Label();
            this.Emaillbl = new System.Windows.Forms.Label();
            this.Nombrelbl = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelBarraDeTitulo = new System.Windows.Forms.Panel();
            this.RestaurarBttn = new System.Windows.Forms.PictureBox();
            this.MinimizarBttn = new System.Windows.Forms.PictureBox();
            this.MaximizarBttn = new System.Windows.Forms.PictureBox();
            this.CerrarBttn = new System.Windows.Forms.PictureBox();
            this.panelContenedor.SuspendLayout();
            this.panelFormularios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMenú.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelBarraDeTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RestaurarBttn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarBttn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizarBttn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarBttn)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.panelContenedor.Controls.Add(this.panelFormularios);
            this.panelContenedor.Controls.Add(this.panelMenú);
            this.panelContenedor.Controls.Add(this.panelBarraDeTitulo);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1100, 650);
            this.panelContenedor.TabIndex = 0;
            // 
            // panelFormularios
            // 
            this.panelFormularios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panelFormularios.Controls.Add(this.label1);
            this.panelFormularios.Controls.Add(this.pictureBox1);
            this.panelFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormularios.Location = new System.Drawing.Point(250, 40);
            this.panelFormularios.Name = "panelFormularios";
            this.panelFormularios.Size = new System.Drawing.Size(850, 610);
            this.panelFormularios.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.label1.Location = new System.Drawing.Point(222, 471);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "FoxGames";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(196, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelMenú
            // 
            this.panelMenú.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.panelMenú.Controls.Add(this.button1);
            this.panelMenú.Controls.Add(this.EmpleadosBttn);
            this.panelMenú.Controls.Add(this.LogOutBttn);
            this.panelMenú.Controls.Add(this.button2);
            this.panelMenú.Controls.Add(this.button3);
            this.panelMenú.Controls.Add(this.panel1);
            this.panelMenú.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenú.Location = new System.Drawing.Point(0, 40);
            this.panelMenú.Name = "panelMenú";
            this.panelMenú.Size = new System.Drawing.Size(250, 610);
            this.panelMenú.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(0, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sobre mí";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmpleadosBttn
            // 
            this.EmpleadosBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.EmpleadosBttn.Dock = System.Windows.Forms.DockStyle.Top;
            this.EmpleadosBttn.FlatAppearance.BorderSize = 0;
            this.EmpleadosBttn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.EmpleadosBttn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.EmpleadosBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmpleadosBttn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpleadosBttn.ForeColor = System.Drawing.Color.LightGray;
            this.EmpleadosBttn.Location = new System.Drawing.Point(0, 225);
            this.EmpleadosBttn.Name = "EmpleadosBttn";
            this.EmpleadosBttn.Size = new System.Drawing.Size(250, 40);
            this.EmpleadosBttn.TabIndex = 5;
            this.EmpleadosBttn.Text = "Empleados";
            this.EmpleadosBttn.UseVisualStyleBackColor = false;
            this.EmpleadosBttn.Click += new System.EventHandler(this.EmpleadosBttn_Click);
            // 
            // LogOutBttn
            // 
            this.LogOutBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.LogOutBttn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LogOutBttn.FlatAppearance.BorderSize = 0;
            this.LogOutBttn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.LogOutBttn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.LogOutBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutBttn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutBttn.ForeColor = System.Drawing.Color.LightGray;
            this.LogOutBttn.Location = new System.Drawing.Point(0, 570);
            this.LogOutBttn.Name = "LogOutBttn";
            this.LogOutBttn.Size = new System.Drawing.Size(250, 40);
            this.LogOutBttn.TabIndex = 4;
            this.LogOutBttn.Text = "LogOut";
            this.LogOutBttn.UseVisualStyleBackColor = false;
            this.LogOutBttn.Click += new System.EventHandler(this.LogOutBttn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.LightGray;
            this.button2.Location = new System.Drawing.Point(0, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "Videojuegos";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.LightGray;
            this.button3.Location = new System.Drawing.Point(0, 145);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(250, 40);
            this.button3.TabIndex = 3;
            this.button3.Text = "Articulos y consolas";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.CargoLbl);
            this.panel1.Controls.Add(this.Emaillbl);
            this.panel1.Controls.Add(this.Nombrelbl);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 145);
            this.panel1.TabIndex = 0;
            // 
            // CargoLbl
            // 
            this.CargoLbl.AutoSize = true;
            this.CargoLbl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CargoLbl.ForeColor = System.Drawing.Color.LightGray;
            this.CargoLbl.Location = new System.Drawing.Point(94, 66);
            this.CargoLbl.Name = "CargoLbl";
            this.CargoLbl.Size = new System.Drawing.Size(52, 19);
            this.CargoLbl.TabIndex = 4;
            this.CargoLbl.Text = "Cargo";
            // 
            // Emaillbl
            // 
            this.Emaillbl.AutoSize = true;
            this.Emaillbl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emaillbl.ForeColor = System.Drawing.Color.LightGray;
            this.Emaillbl.Location = new System.Drawing.Point(94, 47);
            this.Emaillbl.Name = "Emaillbl";
            this.Emaillbl.Size = new System.Drawing.Size(46, 19);
            this.Emaillbl.TabIndex = 3;
            this.Emaillbl.Text = "Email";
            // 
            // Nombrelbl
            // 
            this.Nombrelbl.AutoSize = true;
            this.Nombrelbl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombrelbl.ForeColor = System.Drawing.Color.LightGray;
            this.Nombrelbl.Location = new System.Drawing.Point(94, 28);
            this.Nombrelbl.Name = "Nombrelbl";
            this.Nombrelbl.Size = new System.Drawing.Size(64, 19);
            this.Nombrelbl.TabIndex = 2;
            this.Nombrelbl.Text = "Nombre";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(76, 73);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panelBarraDeTitulo
            // 
            this.panelBarraDeTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.panelBarraDeTitulo.Controls.Add(this.RestaurarBttn);
            this.panelBarraDeTitulo.Controls.Add(this.MinimizarBttn);
            this.panelBarraDeTitulo.Controls.Add(this.MaximizarBttn);
            this.panelBarraDeTitulo.Controls.Add(this.CerrarBttn);
            this.panelBarraDeTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraDeTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraDeTitulo.Name = "panelBarraDeTitulo";
            this.panelBarraDeTitulo.Size = new System.Drawing.Size(1100, 40);
            this.panelBarraDeTitulo.TabIndex = 0;
            this.panelBarraDeTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBarraDeTitulo_MouseMove);
            // 
            // RestaurarBttn
            // 
            this.RestaurarBttn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RestaurarBttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RestaurarBttn.Image = ((System.Drawing.Image)(resources.GetObject("RestaurarBttn.Image")));
            this.RestaurarBttn.Location = new System.Drawing.Point(1042, 3);
            this.RestaurarBttn.Name = "RestaurarBttn";
            this.RestaurarBttn.Size = new System.Drawing.Size(20, 20);
            this.RestaurarBttn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RestaurarBttn.TabIndex = 3;
            this.RestaurarBttn.TabStop = false;
            this.RestaurarBttn.Visible = false;
            this.RestaurarBttn.Click += new System.EventHandler(this.RestaurarBttn_Click);
            // 
            // MinimizarBttn
            // 
            this.MinimizarBttn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizarBttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizarBttn.Image = ((System.Drawing.Image)(resources.GetObject("MinimizarBttn.Image")));
            this.MinimizarBttn.Location = new System.Drawing.Point(1016, 3);
            this.MinimizarBttn.Name = "MinimizarBttn";
            this.MinimizarBttn.Size = new System.Drawing.Size(20, 20);
            this.MinimizarBttn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MinimizarBttn.TabIndex = 2;
            this.MinimizarBttn.TabStop = false;
            this.MinimizarBttn.Click += new System.EventHandler(this.MinimizarBttn_Click);
            // 
            // MaximizarBttn
            // 
            this.MaximizarBttn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizarBttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaximizarBttn.Image = ((System.Drawing.Image)(resources.GetObject("MaximizarBttn.Image")));
            this.MaximizarBttn.Location = new System.Drawing.Point(1042, 3);
            this.MaximizarBttn.Name = "MaximizarBttn";
            this.MaximizarBttn.Size = new System.Drawing.Size(20, 20);
            this.MaximizarBttn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MaximizarBttn.TabIndex = 1;
            this.MaximizarBttn.TabStop = false;
            this.MaximizarBttn.Click += new System.EventHandler(this.MaximizarBttn_Click);
            // 
            // CerrarBttn
            // 
            this.CerrarBttn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CerrarBttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CerrarBttn.Image = ((System.Drawing.Image)(resources.GetObject("CerrarBttn.Image")));
            this.CerrarBttn.Location = new System.Drawing.Point(1068, 3);
            this.CerrarBttn.Name = "CerrarBttn";
            this.CerrarBttn.Size = new System.Drawing.Size(20, 20);
            this.CerrarBttn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CerrarBttn.TabIndex = 0;
            this.CerrarBttn.TabStop = false;
            this.CerrarBttn.Click += new System.EventHandler(this.CerrarBttn_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(650, 400);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrincipal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.panelContenedor.ResumeLayout(false);
            this.panelFormularios.ResumeLayout(false);
            this.panelFormularios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMenú.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelBarraDeTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RestaurarBttn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarBttn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizarBttn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarBttn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelBarraDeTitulo;
        private System.Windows.Forms.Panel panelMenú;
        private System.Windows.Forms.Panel panelFormularios;
        private System.Windows.Forms.PictureBox RestaurarBttn;
        private System.Windows.Forms.PictureBox MinimizarBttn;
        private System.Windows.Forms.PictureBox MaximizarBttn;
        private System.Windows.Forms.PictureBox CerrarBttn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LogOutBttn;
        private System.Windows.Forms.Label Nombrelbl;
        private System.Windows.Forms.Label Emaillbl;
        private System.Windows.Forms.Label CargoLbl;
        private System.Windows.Forms.Button EmpleadosBttn;
    }
}