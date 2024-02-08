namespace Barberia
{
    partial class CrearUsuario
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
            this.verMenuAdmin = new System.Windows.Forms.Button();
            this.tablaUsuarios = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_seleccionCodigoUsuario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_codigoUsuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_eliminarUsuario = new System.Windows.Forms.Button();
            this.btn_modificarUsuario = new System.Windows.Forms.Button();
            this.btn_crearUsuario = new System.Windows.Forms.Button();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_NombreUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaUsuarios)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(382, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CREAR USUARIOS";
            // 
            // verMenuAdmin
            // 
            this.verMenuAdmin.Location = new System.Drawing.Point(2, 381);
            this.verMenuAdmin.Name = "verMenuAdmin";
            this.verMenuAdmin.Size = new System.Drawing.Size(75, 23);
            this.verMenuAdmin.TabIndex = 19;
            this.verMenuAdmin.Text = "Volver";
            this.verMenuAdmin.UseVisualStyleBackColor = true;
            this.verMenuAdmin.Click += new System.EventHandler(this.verMenuAdmin_Click);
            // 
            // tablaUsuarios
            // 
            this.tablaUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaUsuarios.BackgroundColor = System.Drawing.Color.Maroon;
            this.tablaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaUsuarios.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tablaUsuarios.Location = new System.Drawing.Point(134, 303);
            this.tablaUsuarios.Name = "tablaUsuarios";
            this.tablaUsuarios.Size = new System.Drawing.Size(717, 172);
            this.tablaUsuarios.TabIndex = 18;
            this.tablaUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaUsuarios_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.txt_seleccionCodigoUsuario);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(609, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(313, 245);
            this.panel2.TabIndex = 17;
            // 
            // txt_seleccionCodigoUsuario
            // 
            this.txt_seleccionCodigoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_seleccionCodigoUsuario.Location = new System.Drawing.Point(78, 102);
            this.txt_seleccionCodigoUsuario.Name = "txt_seleccionCodigoUsuario";
            this.txt_seleccionCodigoUsuario.Size = new System.Drawing.Size(155, 31);
            this.txt_seleccionCodigoUsuario.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(55, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ingrese Codigo De Usuario";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Seleccionar Usuario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Barberia.Properties.Resources.LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(387, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 246);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.txt_codigoUsuario);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_eliminarUsuario);
            this.panel1.Controls.Add(this.btn_modificarUsuario);
            this.panel1.Controls.Add(this.btn_crearUsuario);
            this.panel1.Controls.Add(this.txt_contraseña);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_NombreUsuario);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(6, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 245);
            this.panel1.TabIndex = 15;
            // 
            // txt_codigoUsuario
            // 
            this.txt_codigoUsuario.Location = new System.Drawing.Point(128, 50);
            this.txt_codigoUsuario.Name = "txt_codigoUsuario";
            this.txt_codigoUsuario.Size = new System.Drawing.Size(155, 20);
            this.txt_codigoUsuario.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "CODIGO";
            // 
            // btn_eliminarUsuario
            // 
            this.btn_eliminarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminarUsuario.Location = new System.Drawing.Point(254, 188);
            this.btn_eliminarUsuario.Name = "btn_eliminarUsuario";
            this.btn_eliminarUsuario.Size = new System.Drawing.Size(108, 23);
            this.btn_eliminarUsuario.TabIndex = 9;
            this.btn_eliminarUsuario.Text = "ELIMINAR";
            this.btn_eliminarUsuario.UseVisualStyleBackColor = true;
            this.btn_eliminarUsuario.Click += new System.EventHandler(this.btn_eliminarUsuario_Click);
            // 
            // btn_modificarUsuario
            // 
            this.btn_modificarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificarUsuario.Location = new System.Drawing.Point(148, 188);
            this.btn_modificarUsuario.Name = "btn_modificarUsuario";
            this.btn_modificarUsuario.Size = new System.Drawing.Size(101, 23);
            this.btn_modificarUsuario.TabIndex = 8;
            this.btn_modificarUsuario.Text = "MODIFICAR";
            this.btn_modificarUsuario.UseVisualStyleBackColor = true;
            this.btn_modificarUsuario.Click += new System.EventHandler(this.btn_modificarUsuario_Click);
            // 
            // btn_crearUsuario
            // 
            this.btn_crearUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_crearUsuario.Location = new System.Drawing.Point(3, 188);
            this.btn_crearUsuario.Name = "btn_crearUsuario";
            this.btn_crearUsuario.Size = new System.Drawing.Size(139, 23);
            this.btn_crearUsuario.TabIndex = 7;
            this.btn_crearUsuario.Text = "CREAR USUARIO";
            this.btn_crearUsuario.UseVisualStyleBackColor = true;
            this.btn_crearUsuario.Click += new System.EventHandler(this.btn_crearUsuario_Click);
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Location = new System.Drawing.Point(127, 137);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(155, 20);
            this.txt_contraseña.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "CONTRASEÑA";
            // 
            // txt_NombreUsuario
            // 
            this.txt_NombreUsuario.Location = new System.Drawing.Point(127, 91);
            this.txt_NombreUsuario.Name = "txt_NombreUsuario";
            this.txt_NombreUsuario.Size = new System.Drawing.Size(155, 20);
            this.txt_NombreUsuario.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "USUARIO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Gestionar Usuarios";
            // 
            // CrearUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(932, 487);
            this.Controls.Add(this.verMenuAdmin);
            this.Controls.Add(this.tablaUsuarios);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "CrearUsuario";
            this.Text = "CrearUsuario";
            this.Load += new System.EventHandler(this.CrearUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaUsuarios)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button verMenuAdmin;
        private System.Windows.Forms.DataGridView tablaUsuarios;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_seleccionCodigoUsuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_codigoUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_eliminarUsuario;
        private System.Windows.Forms.Button btn_modificarUsuario;
        private System.Windows.Forms.Button btn_crearUsuario;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_NombreUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}