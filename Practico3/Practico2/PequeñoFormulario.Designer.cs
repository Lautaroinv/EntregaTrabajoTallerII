namespace Practico2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.LNya = new System.Windows.Forms.Label();
            this.LModificar = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.LDni = new System.Windows.Forms.Label();
            this.TDni = new System.Windows.Forms.TextBox();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.TApellido = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.LTarjetas = new System.Windows.Forms.Label();
            this.LTelefono = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LNuevoCliente = new System.Windows.Forms.Label();
            this.RBVaron = new System.Windows.Forms.RadioButton();
            this.RBMujer = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BSalir = new System.Windows.Forms.Button();
            this.BEliminar = new System.Windows.Forms.Button();
            this.BGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LNya
            // 
            this.LNya.AutoSize = true;
            this.LNya.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.LNya.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LNya.Location = new System.Drawing.Point(38, 91);
            this.LNya.Name = "LNya";
            this.LNya.Size = new System.Drawing.Size(127, 17);
            this.LNya.TabIndex = 0;
            this.LNya.Text = "Nombre y Apellido:";
            this.LNya.Click += new System.EventHandler(this.label1_Click);
            // 
            // LModificar
            // 
            this.LModificar.AutoSize = true;
            this.LModificar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.LModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.LModificar.ForeColor = System.Drawing.Color.Red;
            this.LModificar.Location = new System.Drawing.Point(202, 91);
            this.LModificar.Name = "LModificar";
            this.LModificar.Size = new System.Drawing.Size(58, 15);
            this.LModificar.TabIndex = 1;
            this.LModificar.Text = "modificar";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.LNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LNombre.Location = new System.Drawing.Point(37, 237);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(60, 15);
            this.LNombre.TabIndex = 2;
            this.LNombre.Text = "* Nombre";
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.LApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LApellido.Location = new System.Drawing.Point(38, 190);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(59, 15);
            this.LApellido.TabIndex = 3;
            this.LApellido.Text = "* Apellido";
            this.LApellido.Click += new System.EventHandler(this.LApellido_Click);
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.LDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LDni.Location = new System.Drawing.Point(37, 141);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(36, 15);
            this.LDni.TabIndex = 4;
            this.LDni.Text = "* DNI";
            // 
            // TDni
            // 
            this.TDni.Location = new System.Drawing.Point(124, 140);
            this.TDni.Multiline = true;
            this.TDni.Name = "TDni";
            this.TDni.Size = new System.Drawing.Size(113, 24);
            this.TDni.TabIndex = 5;
            this.TDni.TextChanged += new System.EventHandler(this.TDni_TextChanged);
            this.TDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TDni_KeyPress);
            // 
            // TNombre
            // 
            this.TNombre.Location = new System.Drawing.Point(124, 236);
            this.TNombre.Multiline = true;
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(113, 24);
            this.TNombre.TabIndex = 6;
            this.TNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TApellido_KeyPress);
            // 
            // TApellido
            // 
            this.TApellido.Location = new System.Drawing.Point(124, 189);
            this.TApellido.Multiline = true;
            this.TApellido.Name = "TApellido";
            this.TApellido.Size = new System.Drawing.Size(113, 24);
            this.TApellido.TabIndex = 7;
            this.TApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TApellido_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.LTarjetas);
            this.panel1.Controls.Add(this.LTelefono);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(21, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 345);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(159, 310);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(88, 19);
            this.checkBox3.TabIndex = 16;
            this.checkBox3.Text = "Mastercard";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.checkBox2.Location = new System.Drawing.Point(159, 285);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(49, 19);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "Visa";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.checkBox1.Location = new System.Drawing.Point(159, 260);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(70, 19);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Naranja";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // LTarjetas
            // 
            this.LTarjetas.AutoSize = true;
            this.LTarjetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LTarjetas.Location = new System.Drawing.Point(21, 259);
            this.LTarjetas.Name = "LTarjetas";
            this.LTarjetas.Size = new System.Drawing.Size(111, 15);
            this.LTarjetas.TabIndex = 13;
            this.LTarjetas.Text = "Tarjetas de crédito:";
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LTelefono.Location = new System.Drawing.Point(21, 212);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(55, 15);
            this.LTelefono.TabIndex = 1;
            this.LTelefono.Text = "Telefono";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 211);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 24);
            this.textBox1.TabIndex = 0;
            // 
            // LNuevoCliente
            // 
            this.LNuevoCliente.AutoSize = true;
            this.LNuevoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNuevoCliente.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LNuevoCliente.Location = new System.Drawing.Point(200, 9);
            this.LNuevoCliente.Name = "LNuevoCliente";
            this.LNuevoCliente.Size = new System.Drawing.Size(185, 29);
            this.LNuevoCliente.TabIndex = 12;
            this.LNuevoCliente.Text = "Nuevo Cliente";
            // 
            // RBVaron
            // 
            this.RBVaron.AutoSize = true;
            this.RBVaron.Checked = true;
            this.RBVaron.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.RBVaron.Location = new System.Drawing.Point(349, 286);
            this.RBVaron.Name = "RBVaron";
            this.RBVaron.Size = new System.Drawing.Size(57, 19);
            this.RBVaron.TabIndex = 14;
            this.RBVaron.TabStop = true;
            this.RBVaron.Text = "Varón";
            this.RBVaron.UseVisualStyleBackColor = true;
            this.RBVaron.CheckedChanged += new System.EventHandler(this.RBVaron_CheckedChanged);
            // 
            // RBMujer
            // 
            this.RBMujer.AutoSize = true;
            this.RBMujer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.RBMujer.Location = new System.Drawing.Point(423, 286);
            this.RBMujer.Name = "RBMujer";
            this.RBMujer.Size = new System.Drawing.Size(57, 19);
            this.RBMujer.TabIndex = 15;
            this.RBMujer.Text = "Mujer";
            this.RBMujer.UseVisualStyleBackColor = true;
            this.RBMujer.CheckedChanged += new System.EventHandler(this.RBMujer_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Practico2.Properties.Resources.hombre2;
            this.pictureBox1.Location = new System.Drawing.Point(349, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // BSalir
            // 
            this.BSalir.Image = global::Practico2.Properties.Resources.salir;
            this.BSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BSalir.Location = new System.Drawing.Point(423, 448);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(78, 47);
            this.BSalir.TabIndex = 11;
            this.BSalir.Text = "Salir";
            this.BSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BSalir.UseVisualStyleBackColor = true;
            this.BSalir.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // BEliminar
            // 
            this.BEliminar.Image = global::Practico2.Properties.Resources.eliminar2;
            this.BEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BEliminar.Location = new System.Drawing.Point(187, 448);
            this.BEliminar.Name = "BEliminar";
            this.BEliminar.Size = new System.Drawing.Size(90, 47);
            this.BEliminar.TabIndex = 9;
            this.BEliminar.Text = "Eliminar";
            this.BEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BEliminar.UseVisualStyleBackColor = true;
            this.BEliminar.Click += new System.EventHandler(this.BEliminar_Click);
            // 
            // BGuardar
            // 
            this.BGuardar.Image = global::Practico2.Properties.Resources.guardar2;
            this.BGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BGuardar.Location = new System.Drawing.Point(21, 448);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(90, 47);
            this.BGuardar.TabIndex = 8;
            this.BGuardar.Text = "Guardar";
            this.BGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BGuardar.UseVisualStyleBackColor = true;
            this.BGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 511);
            this.Controls.Add(this.RBMujer);
            this.Controls.Add(this.RBVaron);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LNuevoCliente);
            this.Controls.Add(this.BSalir);
            this.Controls.Add(this.BEliminar);
            this.Controls.Add(this.BGuardar);
            this.Controls.Add(this.TApellido);
            this.Controls.Add(this.TNombre);
            this.Controls.Add(this.TDni);
            this.Controls.Add(this.LDni);
            this.Controls.Add(this.LApellido);
            this.Controls.Add(this.LNombre);
            this.Controls.Add(this.LModificar);
            this.Controls.Add(this.LNya);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pequeño Formulario";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LNya;
        private System.Windows.Forms.Label LModificar;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.TextBox TDni;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.TextBox TApellido;
        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.Button BEliminar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BSalir;
        private System.Windows.Forms.Label LTelefono;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LNuevoCliente;
        private System.Windows.Forms.Label LTarjetas;
        private System.Windows.Forms.RadioButton RBMujer;
        private System.Windows.Forms.RadioButton RBVaron;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

