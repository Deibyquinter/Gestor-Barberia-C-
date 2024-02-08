namespace Barberia
{
    partial class CrearCita
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_codigoCita = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_eliminarCita = new System.Windows.Forms.Button();
            this.btn_modificarCita = new System.Windows.Forms.Button();
            this.btn_crearCita = new System.Windows.Forms.Button();
            this.txt_hora = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_dia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_NombreCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_seleccionCodigoCita = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tablaCitas = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ver = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.txt_codigoCita);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_eliminarCita);
            this.panel1.Controls.Add(this.btn_modificarCita);
            this.panel1.Controls.Add(this.btn_crearCita);
            this.panel1.Controls.Add(this.txt_hora);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_dia);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_NombreCliente);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 245);
            this.panel1.TabIndex = 0;
            // 
            // txt_codigoCita
            // 
            this.txt_codigoCita.Location = new System.Drawing.Point(127, 39);
            this.txt_codigoCita.Name = "txt_codigoCita";
            this.txt_codigoCita.Size = new System.Drawing.Size(155, 20);
            this.txt_codigoCita.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "CODIGO";
            // 
            // btn_eliminarCita
            // 
            this.btn_eliminarCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminarCita.Location = new System.Drawing.Point(244, 188);
            this.btn_eliminarCita.Name = "btn_eliminarCita";
            this.btn_eliminarCita.Size = new System.Drawing.Size(94, 23);
            this.btn_eliminarCita.TabIndex = 9;
            this.btn_eliminarCita.Text = "Eliminar";
            this.btn_eliminarCita.UseVisualStyleBackColor = true;
            this.btn_eliminarCita.Click += new System.EventHandler(this.btn_eliminarCita_Click);
            // 
            // btn_modificarCita
            // 
            this.btn_modificarCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificarCita.Location = new System.Drawing.Point(128, 188);
            this.btn_modificarCita.Name = "btn_modificarCita";
            this.btn_modificarCita.Size = new System.Drawing.Size(94, 23);
            this.btn_modificarCita.TabIndex = 8;
            this.btn_modificarCita.Text = "Modificar";
            this.btn_modificarCita.UseVisualStyleBackColor = true;
            this.btn_modificarCita.Click += new System.EventHandler(this.btn_modificarCita_Click);
            // 
            // btn_crearCita
            // 
            this.btn_crearCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_crearCita.Location = new System.Drawing.Point(8, 188);
            this.btn_crearCita.Name = "btn_crearCita";
            this.btn_crearCita.Size = new System.Drawing.Size(94, 23);
            this.btn_crearCita.TabIndex = 7;
            this.btn_crearCita.Text = "Crear Cita";
            this.btn_crearCita.UseVisualStyleBackColor = true;
            this.btn_crearCita.Click += new System.EventHandler(this.btn_crearCita_Click);
            // 
            // txt_hora
            // 
            this.txt_hora.Location = new System.Drawing.Point(128, 135);
            this.txt_hora.Name = "txt_hora";
            this.txt_hora.Size = new System.Drawing.Size(155, 20);
            this.txt_hora.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Hora";
            // 
            // txt_dia
            // 
            this.txt_dia.Location = new System.Drawing.Point(128, 102);
            this.txt_dia.Name = "txt_dia";
            this.txt_dia.Size = new System.Drawing.Size(155, 20);
            this.txt_dia.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dia";
            // 
            // txt_NombreCliente
            // 
            this.txt_NombreCliente.Location = new System.Drawing.Point(127, 71);
            this.txt_NombreCliente.Name = "txt_NombreCliente";
            this.txt_NombreCliente.Size = new System.Drawing.Size(155, 20);
            this.txt_NombreCliente.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestionar Citas";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.txt_seleccionCodigoCita);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(615, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(313, 245);
            this.panel2.TabIndex = 2;
            // 
            // txt_seleccionCodigoCita
            // 
            this.txt_seleccionCodigoCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_seleccionCodigoCita.Location = new System.Drawing.Point(78, 102);
            this.txt_seleccionCodigoCita.Name = "txt_seleccionCodigoCita";
            this.txt_seleccionCodigoCita.Size = new System.Drawing.Size(155, 31);
            this.txt_seleccionCodigoCita.TabIndex = 2;
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
            // tablaCitas
            // 
            this.tablaCitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaCitas.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tablaCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaCitas.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tablaCitas.Location = new System.Drawing.Point(140, 294);
            this.tablaCitas.Name = "tablaCitas";
            this.tablaCitas.Size = new System.Drawing.Size(717, 172);
            this.tablaCitas.TabIndex = 9;
            this.tablaCitas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaCitas_CellContentClick_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(389, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "CREACION DE CITAS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Barberia.Properties.Resources.LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(393, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 246);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ver
            // 
            this.ver.Location = new System.Drawing.Point(30, 363);
            this.ver.Name = "ver";
            this.ver.Size = new System.Drawing.Size(75, 23);
            this.ver.TabIndex = 26;
            this.ver.Text = "Volver";
            this.ver.UseVisualStyleBackColor = true;
            this.ver.Click += new System.EventHandler(this.ver_Click);
            // 
            // CrearCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(955, 478);
            this.Controls.Add(this.ver);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tablaCitas);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "CrearCita";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NombreCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_dia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_hora;
        private System.Windows.Forms.Button btn_crearCita;
        private System.Windows.Forms.Button btn_eliminarCita;
        private System.Windows.Forms.Button btn_modificarCita;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_seleccionCodigoCita;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView tablaCitas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_codigoCita;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ver;
    }
}

