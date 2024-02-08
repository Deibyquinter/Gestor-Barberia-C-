namespace Barberia
{
    partial class MenuUsuario
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
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cerrarSesion = new System.Windows.Forms.Button();
            this.btn_verPago = new System.Windows.Forms.Button();
            this.btn_verCita = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "MENU PRINCIPAL USUARIO";
            // 
            // btn_cerrarSesion
            // 
            this.btn_cerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrarSesion.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_cerrarSesion.Location = new System.Drawing.Point(216, 370);
            this.btn_cerrarSesion.Name = "btn_cerrarSesion";
            this.btn_cerrarSesion.Size = new System.Drawing.Size(161, 33);
            this.btn_cerrarSesion.TabIndex = 10;
            this.btn_cerrarSesion.Text = "CERRAR SESION";
            this.btn_cerrarSesion.UseVisualStyleBackColor = true;
            this.btn_cerrarSesion.Click += new System.EventHandler(this.btn_cerrarSesion_Click);
            // 
            // btn_verPago
            // 
            this.btn_verPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verPago.Location = new System.Drawing.Point(365, 317);
            this.btn_verPago.Name = "btn_verPago";
            this.btn_verPago.Size = new System.Drawing.Size(132, 34);
            this.btn_verPago.TabIndex = 8;
            this.btn_verPago.Text = "PAGO";
            this.btn_verPago.UseVisualStyleBackColor = true;
            this.btn_verPago.Click += new System.EventHandler(this.btn_verPago_Click);
            // 
            // btn_verCita
            // 
            this.btn_verCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verCita.Location = new System.Drawing.Point(77, 317);
            this.btn_verCita.Name = "btn_verCita";
            this.btn_verCita.Size = new System.Drawing.Size(129, 34);
            this.btn_verCita.TabIndex = 7;
            this.btn_verCita.Text = "CREAR CITA";
            this.btn_verCita.UseVisualStyleBackColor = true;
            this.btn_verCita.Click += new System.EventHandler(this.btn_verCita_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Barberia.Properties.Resources.LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(191, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 246);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // MenuUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_cerrarSesion);
            this.Controls.Add(this.btn_verPago);
            this.Controls.Add(this.btn_verCita);
            this.Name = "MenuUsuario";
            this.Text = "MenuUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_cerrarSesion;
        private System.Windows.Forms.Button btn_verPago;
        private System.Windows.Forms.Button btn_verCita;
    }
}