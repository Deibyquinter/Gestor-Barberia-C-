namespace Barberia
{
    partial class GestionarCitas
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
            this.label6 = new System.Windows.Forms.Label();
            this.tablaCitas = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_seleccionCodigoCita = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_cancelarCita = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_codigoCita = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_modificarCita = new System.Windows.Forms.Button();
            this.txt_hora = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_dia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_NombreCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCitas)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(407, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "GESTOR DE CITAS";
            // 
            // tablaCitas
            // 
            this.tablaCitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaCitas.BackgroundColor = System.Drawing.Color.Teal;
            this.tablaCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaCitas.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tablaCitas.Location = new System.Drawing.Point(158, 288);
            this.tablaCitas.Name = "tablaCitas";
            this.tablaCitas.Size = new System.Drawing.Size(717, 172);
            this.tablaCitas.TabIndex = 14;
            this.tablaCitas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaCitas_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.txt_seleccionCodigoCita);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btn_cancelarCita);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(633, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(313, 245);
            this.panel2.TabIndex = 13;
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
            // btn_cancelarCita
            // 
            this.btn_cancelarCita.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_cancelarCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelarCita.Location = new System.Drawing.Point(78, 183);
            this.btn_cancelarCita.Name = "btn_cancelarCita";
            this.btn_cancelarCita.Size = new System.Drawing.Size(158, 29);
            this.btn_cancelarCita.TabIndex = 9;
            this.btn_cancelarCita.Text = "CANCELAR CITA";
            this.btn_cancelarCita.UseVisualStyleBackColor = false;
            this.btn_cancelarCita.Click += new System.EventHandler(this.btn_cancelarCita_Click);
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
            this.pictureBox1.Location = new System.Drawing.Point(411, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 246);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.txt_codigoCita);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_modificarCita);
            this.panel1.Controls.Add(this.txt_hora);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_dia);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_NombreCliente);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(30, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 245);
            this.panel1.TabIndex = 11;
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
            // btn_modificarCita
            // 
            this.btn_modificarCita.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_modificarCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificarCita.Location = new System.Drawing.Point(139, 183);
            this.btn_modificarCita.Name = "btn_modificarCita";
            this.btn_modificarCita.Size = new System.Drawing.Size(118, 37);
            this.btn_modificarCita.TabIndex = 8;
            this.btn_modificarCita.Text = "Modificar";
            this.btn_modificarCita.UseVisualStyleBackColor = false;
            this.btn_modificarCita.Click += new System.EventHandler(this.btn_modificarCita_Click);
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
            // ver
            // 
            this.ver.Location = new System.Drawing.Point(38, 353);
            this.ver.Name = "ver";
            this.ver.Size = new System.Drawing.Size(75, 23);
            this.ver.TabIndex = 27;
            this.ver.Text = "Volver";
            this.ver.UseVisualStyleBackColor = true;
            this.ver.Click += new System.EventHandler(this.ver_Click);
            // 
            // GestionarCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(987, 464);
            this.Controls.Add(this.ver);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tablaCitas);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "GestionarCitas";
            this.Text = "GestionarCitas";
            this.Load += new System.EventHandler(this.GestionarCitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaCitas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView tablaCitas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_seleccionCodigoCita;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_codigoCita;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_cancelarCita;
        private System.Windows.Forms.Button btn_modificarCita;
        private System.Windows.Forms.TextBox txt_hora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_dia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_NombreCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ver;
    }
}