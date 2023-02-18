
namespace WindowsFormsApp1
{
    partial class FormProductos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductoDGV = new System.Windows.Forms.DataGridView();
            this.GuardarBttn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PrecioTxt = new System.Windows.Forms.TextBox();
            this.NombreTxt = new System.Windows.Forms.TextBox();
            this.EditarBttn = new System.Windows.Forms.Button();
            this.EliminarBttn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Productos";
            // 
            // ProductoDGV
            // 
            this.ProductoDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.ProductoDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductoDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.ProductoDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductoDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ProductoDGV.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductoDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.ProductoDGV.EnableHeadersVisualStyles = false;
            this.ProductoDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.ProductoDGV.Location = new System.Drawing.Point(21, 59);
            this.ProductoDGV.Name = "ProductoDGV";
            this.ProductoDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductoDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.ProductoDGV.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ProductoDGV.Size = new System.Drawing.Size(594, 515);
            this.ProductoDGV.TabIndex = 24;
            // 
            // GuardarBttn
            // 
            this.GuardarBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.GuardarBttn.FlatAppearance.BorderSize = 0;
            this.GuardarBttn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.GuardarBttn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.GuardarBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuardarBttn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarBttn.ForeColor = System.Drawing.Color.LightGray;
            this.GuardarBttn.Location = new System.Drawing.Point(638, 135);
            this.GuardarBttn.Name = "GuardarBttn";
            this.GuardarBttn.Size = new System.Drawing.Size(173, 38);
            this.GuardarBttn.TabIndex = 23;
            this.GuardarBttn.Text = "Guardar";
            this.GuardarBttn.UseVisualStyleBackColor = false;
            this.GuardarBttn.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(638, 539);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 35);
            this.button1.TabIndex = 19;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // PrecioTxt
            // 
            this.PrecioTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.PrecioTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PrecioTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioTxt.ForeColor = System.Drawing.Color.DimGray;
            this.PrecioTxt.Location = new System.Drawing.Point(638, 95);
            this.PrecioTxt.Name = "PrecioTxt";
            this.PrecioTxt.Size = new System.Drawing.Size(173, 20);
            this.PrecioTxt.TabIndex = 18;
            this.PrecioTxt.Text = "Precio";
            this.PrecioTxt.Enter += new System.EventHandler(this.PrecioTxt_Enter);
            this.PrecioTxt.Leave += new System.EventHandler(this.PrecioTxt_Leave);
            // 
            // NombreTxt
            // 
            this.NombreTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.NombreTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NombreTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreTxt.ForeColor = System.Drawing.Color.DimGray;
            this.NombreTxt.Location = new System.Drawing.Point(638, 59);
            this.NombreTxt.Name = "NombreTxt";
            this.NombreTxt.Size = new System.Drawing.Size(173, 20);
            this.NombreTxt.TabIndex = 17;
            this.NombreTxt.Text = "Nombre";
            this.NombreTxt.Enter += new System.EventHandler(this.NombreTxt_Enter);
            this.NombreTxt.Leave += new System.EventHandler(this.NombreTxt_Leave);
            // 
            // EditarBttn
            // 
            this.EditarBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.EditarBttn.FlatAppearance.BorderSize = 0;
            this.EditarBttn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.EditarBttn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.EditarBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditarBttn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditarBttn.ForeColor = System.Drawing.Color.LightGray;
            this.EditarBttn.Location = new System.Drawing.Point(638, 189);
            this.EditarBttn.Name = "EditarBttn";
            this.EditarBttn.Size = new System.Drawing.Size(173, 38);
            this.EditarBttn.TabIndex = 25;
            this.EditarBttn.Text = "Editar";
            this.EditarBttn.UseVisualStyleBackColor = false;
            this.EditarBttn.Click += new System.EventHandler(this.EditarBttn_Click);
            // 
            // EliminarBttn
            // 
            this.EliminarBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.EliminarBttn.FlatAppearance.BorderSize = 0;
            this.EliminarBttn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.EliminarBttn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.EliminarBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarBttn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarBttn.ForeColor = System.Drawing.Color.LightGray;
            this.EliminarBttn.Location = new System.Drawing.Point(638, 244);
            this.EliminarBttn.Name = "EliminarBttn";
            this.EliminarBttn.Size = new System.Drawing.Size(173, 38);
            this.EliminarBttn.TabIndex = 26;
            this.EliminarBttn.Text = "Eliminar";
            this.EliminarBttn.UseVisualStyleBackColor = false;
            this.EliminarBttn.Click += new System.EventHandler(this.EliminarBttn_Click);
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(850, 610);
            this.Controls.Add(this.EliminarBttn);
            this.Controls.Add(this.EditarBttn);
            this.Controls.Add(this.ProductoDGV);
            this.Controls.Add(this.GuardarBttn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PrecioTxt);
            this.Controls.Add(this.NombreTxt);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProductos";
            this.Text = "SubForm1";
            this.Load += new System.EventHandler(this.FormProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductoDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ProductoDGV;
        private System.Windows.Forms.Button GuardarBttn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox PrecioTxt;
        private System.Windows.Forms.TextBox NombreTxt;
        private System.Windows.Forms.Button EditarBttn;
        private System.Windows.Forms.Button EliminarBttn;
    }
}