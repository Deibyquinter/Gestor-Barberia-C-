namespace Barberia
{
    partial class MenuAdmin
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
            this.verServicio = new System.Windows.Forms.Button();
            this.btn_verUsuario = new System.Windows.Forms.Button();
            this.btn_verEmergencia = new System.Windows.Forms.Button();
            this.btn_cerrarSesion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // verServicio
            // 
            this.verServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verServicio.Location = new System.Drawing.Point(24, 317);
            this.verServicio.Name = "verServicio";
            this.verServicio.Size = new System.Drawing.Size(129, 34);
            this.verServicio.TabIndex = 0;
            this.verServicio.Text = "Crear Servicio";
            this.verServicio.UseVisualStyleBackColor = true;
            this.verServicio.Click += new System.EventHandler(this.verServicio_Click);
            // 
            // btn_verUsuario
            // 
            this.btn_verUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verUsuario.Location = new System.Drawing.Point(175, 317);
            this.btn_verUsuario.Name = "btn_verUsuario";
            this.btn_verUsuario.Size = new System.Drawing.Size(132, 34);
            this.btn_verUsuario.TabIndex = 1;
            this.btn_verUsuario.Text = "Crear Usuario";
            this.btn_verUsuario.UseVisualStyleBackColor = true;
            this.btn_verUsuario.Click += new System.EventHandler(this.btn_verUsuario_Click);
            // 
            // btn_verEmergencia
            // 
            this.btn_verEmergencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verEmergencia.Location = new System.Drawing.Point(322, 317);
            this.btn_verEmergencia.Name = "btn_verEmergencia";
            this.btn_verEmergencia.Size = new System.Drawing.Size(149, 34);
            this.btn_verEmergencia.TabIndex = 2;
            this.btn_verEmergencia.Text = "Crear Emergencia";
            this.btn_verEmergencia.UseVisualStyleBackColor = true;
            this.btn_verEmergencia.Click += new System.EventHandler(this.btn_verEmergencia_Click);
            // 
            // btn_cerrarSesion
            // 
            this.btn_cerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrarSesion.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_cerrarSesion.Location = new System.Drawing.Point(163, 370);
            this.btn_cerrarSesion.Name = "btn_cerrarSesion";
            this.btn_cerrarSesion.Size = new System.Drawing.Size(161, 33);
            this.btn_cerrarSesion.TabIndex = 3;
            this.btn_cerrarSesion.Text = "CERRAR SESION";
            this.btn_cerrarSesion.UseVisualStyleBackColor = true;
            this.btn_cerrarSesion.Click += new System.EventHandler(this.btn_cerrarSesion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "MENU PRINCIPAL ADMIN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Barberia.Properties.Resources.LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(138, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 246);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(493, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_cerrarSesion);
            this.Controls.Add(this.btn_verEmergencia);
            this.Controls.Add(this.btn_verUsuario);
            this.Controls.Add(this.verServicio);
            this.Name = "MenuAdmin";
            this.Text = "MenuAdmin";
            this.Load += new System.EventHandler(this.MenuAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button verServicio;
        private System.Windows.Forms.Button btn_verUsuario;
        private System.Windows.Forms.Button btn_verEmergencia;
        private System.Windows.Forms.Button btn_cerrarSesion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}