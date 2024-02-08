namespace Barberia
{
    partial class CrearEmergencia
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
            this.ver = new System.Windows.Forms.Button();
            this.tablaEmergencia = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_eliminarEmergencia = new System.Windows.Forms.Button();
            this.txt_seleccionCodigoEmergencia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_nombreEmergencia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_codigoEmergencia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_modificarEmergencia = new System.Windows.Forms.Button();
            this.btn_crearEmergencia = new System.Windows.Forms.Button();
            this.txt_correoUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_NumeroUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaEmergencia)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ver
            // 
            this.ver.Location = new System.Drawing.Point(20, 375);
            this.ver.Name = "ver";
            this.ver.Size = new System.Drawing.Size(75, 23);
            this.ver.TabIndex = 25;
            this.ver.Text = "Volver";
            this.ver.UseVisualStyleBackColor = true;
            this.ver.Click += new System.EventHandler(this.verMenuAdmin_Click);
            // 
            // tablaEmergencia
            // 
            this.tablaEmergencia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaEmergencia.BackgroundColor = System.Drawing.Color.Maroon;
            this.tablaEmergencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaEmergencia.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tablaEmergencia.Location = new System.Drawing.Point(140, 287);
            this.tablaEmergencia.Name = "tablaEmergencia";
            this.tablaEmergencia.Size = new System.Drawing.Size(717, 172);
            this.tablaEmergencia.TabIndex = 24;
            this.tablaEmergencia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaEmergencia_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.btn_eliminarEmergencia);
            this.panel2.Controls.Add(this.txt_seleccionCodigoEmergencia);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(615, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(313, 245);
            this.panel2.TabIndex = 23;
            // 
            // btn_eliminarEmergencia
            // 
            this.btn_eliminarEmergencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminarEmergencia.Location = new System.Drawing.Point(94, 149);
            this.btn_eliminarEmergencia.Name = "btn_eliminarEmergencia";
            this.btn_eliminarEmergencia.Size = new System.Drawing.Size(108, 23);
            this.btn_eliminarEmergencia.TabIndex = 10;
            this.btn_eliminarEmergencia.Text = "ELIMINAR";
            this.btn_eliminarEmergencia.UseVisualStyleBackColor = true;
            this.btn_eliminarEmergencia.Click += new System.EventHandler(this.btn_eliminarEmergencia_Click);
            // 
            // txt_seleccionCodigoEmergencia
            // 
            this.txt_seleccionCodigoEmergencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_seleccionCodigoEmergencia.Location = new System.Drawing.Point(78, 102);
            this.txt_seleccionCodigoEmergencia.Name = "txt_seleccionCodigoEmergencia";
            this.txt_seleccionCodigoEmergencia.Size = new System.Drawing.Size(155, 31);
            this.txt_seleccionCodigoEmergencia.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(55, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(231, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ingrese Codigo De Emergencia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(240, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Seleccionar Emergencia";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.txt_nombreEmergencia);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_codigoEmergencia);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_modificarEmergencia);
            this.panel1.Controls.Add(this.btn_crearEmergencia);
            this.panel1.Controls.Add(this.txt_correoUsuario);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_NumeroUsuario);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 245);
            this.panel1.TabIndex = 21;
            // 
            // txt_nombreEmergencia
            // 
            this.txt_nombreEmergencia.Location = new System.Drawing.Point(127, 78);
            this.txt_nombreEmergencia.Name = "txt_nombreEmergencia";
            this.txt_nombreEmergencia.Size = new System.Drawing.Size(155, 20);
            this.txt_nombreEmergencia.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "NOMBRE";
            // 
            // txt_codigoEmergencia
            // 
            this.txt_codigoEmergencia.Location = new System.Drawing.Point(127, 48);
            this.txt_codigoEmergencia.Name = "txt_codigoEmergencia";
            this.txt_codigoEmergencia.Size = new System.Drawing.Size(155, 20);
            this.txt_codigoEmergencia.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "CODIGO";
            // 
            // btn_modificarEmergencia
            // 
            this.btn_modificarEmergencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificarEmergencia.Location = new System.Drawing.Point(210, 187);
            this.btn_modificarEmergencia.Name = "btn_modificarEmergencia";
            this.btn_modificarEmergencia.Size = new System.Drawing.Size(124, 23);
            this.btn_modificarEmergencia.TabIndex = 8;
            this.btn_modificarEmergencia.Text = "MODIFICAR";
            this.btn_modificarEmergencia.UseVisualStyleBackColor = true;
            this.btn_modificarEmergencia.Click += new System.EventHandler(this.btn_modificarEmergencia_Click);
            // 
            // btn_crearEmergencia
            // 
            this.btn_crearEmergencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_crearEmergencia.Location = new System.Drawing.Point(8, 187);
            this.btn_crearEmergencia.Name = "btn_crearEmergencia";
            this.btn_crearEmergencia.Size = new System.Drawing.Size(172, 23);
            this.btn_crearEmergencia.TabIndex = 7;
            this.btn_crearEmergencia.Text = "CREAR EMERGENCIA";
            this.btn_crearEmergencia.UseVisualStyleBackColor = true;
            this.btn_crearEmergencia.Click += new System.EventHandler(this.btn_crearEmergencia_Click);
            // 
            // txt_correoUsuario
            // 
            this.txt_correoUsuario.Location = new System.Drawing.Point(127, 149);
            this.txt_correoUsuario.Name = "txt_correoUsuario";
            this.txt_correoUsuario.Size = new System.Drawing.Size(155, 20);
            this.txt_correoUsuario.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "CORREO";
            // 
            // txt_NumeroUsuario
            // 
            this.txt_NumeroUsuario.Location = new System.Drawing.Point(127, 113);
            this.txt_NumeroUsuario.Name = "txt_NumeroUsuario";
            this.txt_NumeroUsuario.Size = new System.Drawing.Size(155, 20);
            this.txt_NumeroUsuario.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "NUMERO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Gestionar Emergencia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(388, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "CREAR EMERGENCIA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Barberia.Properties.Resources.LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(393, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 246);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // CrearEmergencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 470);
            this.Controls.Add(this.ver);
            this.Controls.Add(this.tablaEmergencia);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "CrearEmergencia";
            this.Text = "CrearEmergencia";
            this.Load += new System.EventHandler(this.CrearEmergencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaEmergencia)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ver;
        private System.Windows.Forms.DataGridView tablaEmergencia;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_seleccionCodigoEmergencia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_codigoEmergencia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_modificarEmergencia;
        private System.Windows.Forms.Button btn_crearEmergencia;
        private System.Windows.Forms.TextBox txt_correoUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_NumeroUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombreEmergencia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_eliminarEmergencia;
    }
}