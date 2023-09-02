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
            this.BGuardar = new System.Windows.Forms.Button();
            this.BEliminar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // LNya
            // 
            this.LNya.AutoSize = true;
            this.LNya.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LNya.Location = new System.Drawing.Point(27, 29);
            this.LNya.Name = "LNya";
            this.LNya.Size = new System.Drawing.Size(127, 17);
            this.LNya.TabIndex = 0;
            this.LNya.Text = "Nombre y Apellido:";
            this.LNya.Click += new System.EventHandler(this.label1_Click);
            // 
            // LModificar
            // 
            this.LModificar.AutoSize = true;
            this.LModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.LModificar.ForeColor = System.Drawing.Color.Red;
            this.LModificar.Location = new System.Drawing.Point(191, 29);
            this.LModificar.Name = "LModificar";
            this.LModificar.Size = new System.Drawing.Size(58, 15);
            this.LModificar.TabIndex = 1;
            this.LModificar.Text = "modificar";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LNombre.Location = new System.Drawing.Point(26, 175);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(52, 15);
            this.LNombre.TabIndex = 2;
            this.LNombre.Text = "Nombre";
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LApellido.Location = new System.Drawing.Point(27, 128);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(51, 15);
            this.LApellido.TabIndex = 3;
            this.LApellido.Text = "Apellido";
            this.LApellido.Click += new System.EventHandler(this.LApellido_Click);
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LDni.Location = new System.Drawing.Point(26, 79);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(28, 15);
            this.LDni.TabIndex = 4;
            this.LDni.Text = "DNI";
            // 
            // TDni
            // 
            this.TDni.Location = new System.Drawing.Point(113, 78);
            this.TDni.Multiline = true;
            this.TDni.Name = "TDni";
            this.TDni.Size = new System.Drawing.Size(113, 24);
            this.TDni.TabIndex = 5;
            this.TDni.TextChanged += new System.EventHandler(this.TDni_TextChanged);
            this.TDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TDni_KeyPress);
            // 
            // TNombre
            // 
            this.TNombre.Location = new System.Drawing.Point(113, 174);
            this.TNombre.Multiline = true;
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(113, 24);
            this.TNombre.TabIndex = 6;
            this.TNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TApellido_KeyPress);
            // 
            // TApellido
            // 
            this.TApellido.Location = new System.Drawing.Point(113, 127);
            this.TApellido.Multiline = true;
            this.TApellido.Name = "TApellido";
            this.TApellido.Size = new System.Drawing.Size(113, 24);
            this.TApellido.TabIndex = 7;
            this.TApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TApellido_KeyPress);
            // 
            // BGuardar
            // 
            this.BGuardar.Location = new System.Drawing.Point(29, 251);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(84, 28);
            this.BGuardar.TabIndex = 8;
            this.BGuardar.Text = "Guardar";
            this.BGuardar.UseVisualStyleBackColor = true;
            this.BGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // BEliminar
            // 
            this.BEliminar.Location = new System.Drawing.Point(140, 251);
            this.BEliminar.Name = "BEliminar";
            this.BEliminar.Size = new System.Drawing.Size(84, 28);
            this.BEliminar.TabIndex = 9;
            this.BEliminar.Text = "Eliminar";
            this.BEliminar.UseVisualStyleBackColor = true;
            this.BEliminar.Click += new System.EventHandler(this.BEliminar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 361);
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
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pequeño Formulario";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
    }
}

