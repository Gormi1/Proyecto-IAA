﻿
namespace WindowsFormsApp1
{
    partial class FormRecuperarContrasenia
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.TxtUserRequest = new System.Windows.Forms.TextBox();
            this.BttnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresa tú usuario o contraseña.";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(40, 139);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(55, 13);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "Resultado";
            // 
            // TxtUserRequest
            // 
            this.TxtUserRequest.Location = new System.Drawing.Point(31, 71);
            this.TxtUserRequest.Name = "TxtUserRequest";
            this.TxtUserRequest.Size = new System.Drawing.Size(346, 20);
            this.TxtUserRequest.TabIndex = 2;
            // 
            // BttnSend
            // 
            this.BttnSend.Location = new System.Drawing.Point(209, 97);
            this.BttnSend.Name = "BttnSend";
            this.BttnSend.Size = new System.Drawing.Size(75, 23);
            this.BttnSend.TabIndex = 3;
            this.BttnSend.Text = "Enviar";
            this.BttnSend.UseVisualStyleBackColor = true;
            this.BttnSend.Click += new System.EventHandler(this.BttnSend_Click);
            // 
            // FormRecuperarContrasenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 230);
            this.Controls.Add(this.BttnSend);
            this.Controls.Add(this.TxtUserRequest);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label1);
            this.Name = "FormRecuperarContrasenia";
            this.Text = "FormRecuperarContrasenia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox TxtUserRequest;
        private System.Windows.Forms.Button BttnSend;
    }
}