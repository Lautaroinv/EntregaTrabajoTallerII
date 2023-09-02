namespace Practico4
{
    partial class Practico4
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ListNumeros = new System.Windows.Forms.ListBox();
            this.LDesde = new System.Windows.Forms.Label();
            this.LHasta = new System.Windows.Forms.Label();
            this.TDesde = new System.Windows.Forms.TextBox();
            this.THasta = new System.Windows.Forms.TextBox();
            this.BGenerar = new System.Windows.Forms.Button();
            this.LLista = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.BNumerosPares = new System.Windows.Forms.Button();
            this.BNumerosImpares = new System.Windows.Forms.Button();
            this.BNumerosPrimos = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // ListNumeros
            // 
            this.ListNumeros.FormattingEnabled = true;
            this.ListNumeros.Location = new System.Drawing.Point(227, 81);
            this.ListNumeros.Name = "ListNumeros";
            this.ListNumeros.Size = new System.Drawing.Size(317, 277);
            this.ListNumeros.TabIndex = 0;
            // 
            // LDesde
            // 
            this.LDesde.AutoSize = true;
            this.LDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LDesde.Location = new System.Drawing.Point(29, 84);
            this.LDesde.Name = "LDesde";
            this.LDesde.Size = new System.Drawing.Size(49, 17);
            this.LDesde.TabIndex = 1;
            this.LDesde.Text = "Desde";
            // 
            // LHasta
            // 
            this.LHasta.AutoSize = true;
            this.LHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LHasta.Location = new System.Drawing.Point(29, 143);
            this.LHasta.Name = "LHasta";
            this.LHasta.Size = new System.Drawing.Size(45, 17);
            this.LHasta.TabIndex = 2;
            this.LHasta.Text = "Hasta";
            // 
            // TDesde
            // 
            this.TDesde.Location = new System.Drawing.Point(99, 83);
            this.TDesde.Multiline = true;
            this.TDesde.Name = "TDesde";
            this.TDesde.Size = new System.Drawing.Size(109, 23);
            this.TDesde.TabIndex = 3;
            this.TDesde.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.TDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TDesde_KeyPress);
            // 
            // THasta
            // 
            this.THasta.Location = new System.Drawing.Point(99, 142);
            this.THasta.Multiline = true;
            this.THasta.Name = "THasta";
            this.THasta.Size = new System.Drawing.Size(109, 23);
            this.THasta.TabIndex = 4;
            this.THasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.THasta_KeyPress);
            // 
            // BGenerar
            // 
            this.BGenerar.Location = new System.Drawing.Point(99, 193);
            this.BGenerar.Name = "BGenerar";
            this.BGenerar.Size = new System.Drawing.Size(104, 23);
            this.BGenerar.TabIndex = 5;
            this.BGenerar.Text = "Generar Función";
            this.BGenerar.UseVisualStyleBackColor = true;
            this.BGenerar.Click += new System.EventHandler(this.BGenerar_Click);
            // 
            // LLista
            // 
            this.LLista.AutoSize = true;
            this.LLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.LLista.Location = new System.Drawing.Point(161, 22);
            this.LLista.Name = "LLista";
            this.LLista.Size = new System.Drawing.Size(226, 31);
            this.LLista.TabIndex = 6;
            this.LLista.Text = "Lista de Números";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // BNumerosPares
            // 
            this.BNumerosPares.Location = new System.Drawing.Point(99, 251);
            this.BNumerosPares.Name = "BNumerosPares";
            this.BNumerosPares.Size = new System.Drawing.Size(104, 23);
            this.BNumerosPares.TabIndex = 7;
            this.BNumerosPares.Text = "Numeros Pares";
            this.BNumerosPares.UseVisualStyleBackColor = true;
            this.BNumerosPares.Click += new System.EventHandler(this.BNumerosPares_Click);
            // 
            // BNumerosImpares
            // 
            this.BNumerosImpares.Location = new System.Drawing.Point(99, 289);
            this.BNumerosImpares.Name = "BNumerosImpares";
            this.BNumerosImpares.Size = new System.Drawing.Size(104, 23);
            this.BNumerosImpares.TabIndex = 8;
            this.BNumerosImpares.Text = "Numeros Impares";
            this.BNumerosImpares.UseVisualStyleBackColor = true;
            this.BNumerosImpares.Click += new System.EventHandler(this.BNumerosImpares_Click);
            // 
            // BNumerosPrimos
            // 
            this.BNumerosPrimos.Location = new System.Drawing.Point(99, 329);
            this.BNumerosPrimos.Name = "BNumerosPrimos";
            this.BNumerosPrimos.Size = new System.Drawing.Size(104, 23);
            this.BNumerosPrimos.TabIndex = 9;
            this.BNumerosPrimos.Text = "Numeros Primos";
            this.BNumerosPrimos.UseVisualStyleBackColor = true;
            this.BNumerosPrimos.Click += new System.EventHandler(this.BNumerosPrimos_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(608, 81);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Numeros";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(300, 277);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 393);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.BNumerosPrimos);
            this.Controls.Add(this.BNumerosImpares);
            this.Controls.Add(this.BNumerosPares);
            this.Controls.Add(this.LLista);
            this.Controls.Add(this.BGenerar);
            this.Controls.Add(this.THasta);
            this.Controls.Add(this.TDesde);
            this.Controls.Add(this.LHasta);
            this.Controls.Add(this.LDesde);
            this.Controls.Add(this.ListNumeros);
            this.Name = "Form1";
            this.Text = "Lista de numeros";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListNumeros;
        private System.Windows.Forms.Label LDesde;
        private System.Windows.Forms.Label LHasta;
        private System.Windows.Forms.TextBox TDesde;
        private System.Windows.Forms.TextBox THasta;
        private System.Windows.Forms.Button BGenerar;
        private System.Windows.Forms.Label LLista;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button BNumerosPrimos;
        private System.Windows.Forms.Button BNumerosImpares;
        private System.Windows.Forms.Button BNumerosPares;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

