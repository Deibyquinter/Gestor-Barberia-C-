namespace Barberia
{
    partial class CrearServicio
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
            this.tablaServicios = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_seleccionCodigoServicio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_codigoServicio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_eliminarServicio = new System.Windows.Forms.Button();
            this.btn_modificarServicio = new System.Windows.Forms.Button();
            this.btn_crearServicio = new System.Windows.Forms.Button();
            this.txt_valorServicio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_NombreServicio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.verMenuAdmin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaServicios)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablaServicios
            // 
            this.tablaServicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaServicios.BackgroundColor = System.Drawing.Color.LightGreen;
            this.tablaServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaServicios.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tablaServicios.Location = new System.Drawing.Point(174, 265);
            this.tablaServicios.Name = "tablaServicios";
            this.tablaServicios.Size = new System.Drawing.Size(717, 172);
            this.tablaServicios.TabIndex = 13;
            this.tablaServicios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaServicios_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGreen;
            this.panel2.Controls.Add(this.txt_seleccionCodigoServicio);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(649, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(313, 245);
            this.panel2.TabIndex = 12;
            // 
            // txt_seleccionCodigoServicio
            // 
            this.txt_seleccionCodigoServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_seleccionCodigoServicio.Location = new System.Drawing.Point(78, 102);
            this.txt_seleccionCodigoServicio.Name = "txt_seleccionCodigoServicio";
            this.txt_seleccionCodigoServicio.Size = new System.Drawing.Size(155, 31);
            this.txt_seleccionCodigoServicio.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(74, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ingrese Codigo de cita";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Seleccionar Cita";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Barberia.Properties.Resources.LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(427, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 246);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.txt_codigoServicio);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_eliminarServicio);
            this.panel1.Controls.Add(this.btn_modificarServicio);
            this.panel1.Controls.Add(this.btn_crearServicio);
            this.panel1.Controls.Add(this.txt_valorServicio);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_NombreServicio);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(46, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 245);
            this.panel1.TabIndex = 10;
            // 
            // txt_codigoServicio
            // 
            this.txt_codigoServicio.Location = new System.Drawing.Point(128, 50);
            this.txt_codigoServicio.Name = "txt_codigoServicio";
            this.txt_codigoServicio.Size = new System.Drawing.Size(155, 20);
            this.txt_codigoServicio.TabIndex = 11;
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
            // btn_eliminarServicio
            // 
            this.btn_eliminarServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminarServicio.Location = new System.Drawing.Point(244, 188);
            this.btn_eliminarServicio.Name = "btn_eliminarServicio";
            this.btn_eliminarServicio.Size = new System.Drawing.Size(94, 23);
            this.btn_eliminarServicio.TabIndex = 9;
            this.btn_eliminarServicio.Text = "Eliminar";
            this.btn_eliminarServicio.UseVisualStyleBackColor = true;
            this.btn_eliminarServicio.Click += new System.EventHandler(this.btn_eliminarServicio_Click);
            // 
            // btn_modificarServicio
            // 
            this.btn_modificarServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificarServicio.Location = new System.Drawing.Point(128, 188);
            this.btn_modificarServicio.Name = "btn_modificarServicio";
            this.btn_modificarServicio.Size = new System.Drawing.Size(94, 23);
            this.btn_modificarServicio.TabIndex = 8;
            this.btn_modificarServicio.Text = "Modificar";
            this.btn_modificarServicio.UseVisualStyleBackColor = true;
            this.btn_modificarServicio.Click += new System.EventHandler(this.btn_modificarServicio_Click);
            // 
            // btn_crearServicio
            // 
            this.btn_crearServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_crearServicio.Location = new System.Drawing.Point(8, 188);
            this.btn_crearServicio.Name = "btn_crearServicio";
            this.btn_crearServicio.Size = new System.Drawing.Size(94, 23);
            this.btn_crearServicio.TabIndex = 7;
            this.btn_crearServicio.Text = "Crear Servicio";
            this.btn_crearServicio.UseVisualStyleBackColor = true;
            this.btn_crearServicio.Click += new System.EventHandler(this.btn_crearServicio_Click);
            // 
            // txt_valorServicio
            // 
            this.txt_valorServicio.Location = new System.Drawing.Point(127, 137);
            this.txt_valorServicio.Name = "txt_valorServicio";
            this.txt_valorServicio.Size = new System.Drawing.Size(155, 20);
            this.txt_valorServicio.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "VALOR:";
            // 
            // txt_NombreServicio
            // 
            this.txt_NombreServicio.Location = new System.Drawing.Point(127, 91);
            this.txt_NombreServicio.Name = "txt_NombreServicio";
            this.txt_NombreServicio.Size = new System.Drawing.Size(155, 20);
            this.txt_NombreServicio.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "SERVICIO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestionar Servicios";
            // 
            // verMenuAdmin
            // 
            this.verMenuAdmin.Location = new System.Drawing.Point(54, 343);
            this.verMenuAdmin.Name = "verMenuAdmin";
            this.verMenuAdmin.Size = new System.Drawing.Size(75, 23);
            this.verMenuAdmin.TabIndex = 14;
            this.verMenuAdmin.Text = "Volver";
            this.verMenuAdmin.UseVisualStyleBackColor = true;
            this.verMenuAdmin.Click += new System.EventHandler(this.verMenuAdmin_Click);
            // 
            // CrearServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1009, 450);
            this.Controls.Add(this.verMenuAdmin);
            this.Controls.Add(this.tablaServicios);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "CrearServicio";
            this.Text = "CrearServicio";
            this.Load += new System.EventHandler(this.CrearServicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaServicios)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaServicios;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_seleccionCodigoServicio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_codigoServicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_eliminarServicio;
        private System.Windows.Forms.Button btn_modificarServicio;
        private System.Windows.Forms.Button btn_crearServicio;
        private System.Windows.Forms.TextBox txt_valorServicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_NombreServicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button verMenuAdmin;
    }
}