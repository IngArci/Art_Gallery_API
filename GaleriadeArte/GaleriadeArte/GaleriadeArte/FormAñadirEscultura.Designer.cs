namespace GaleriadeArte
{
    partial class FormAñadirEscultura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAñadirEscultura));
            this.txtTextura = new System.Windows.Forms.TextBox();
            this.labelTextura = new System.Windows.Forms.Label();
            this.textTecnica = new System.Windows.Forms.TextBox();
            this.labelTecnica = new System.Windows.Forms.Label();
            this.FechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.labelFechaIngreso = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelEstado = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.txtIdEscultura = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTextura
            // 
            this.txtTextura.Location = new System.Drawing.Point(105, 430);
            this.txtTextura.Name = "txtTextura";
            this.txtTextura.Size = new System.Drawing.Size(173, 27);
            this.txtTextura.TabIndex = 31;
            this.txtTextura.TextChanged += new System.EventHandler(this.txtTextura_TextChanged);
            // 
            // labelTextura
            // 
            this.labelTextura.AutoSize = true;
            this.labelTextura.Location = new System.Drawing.Point(24, 437);
            this.labelTextura.Name = "labelTextura";
            this.labelTextura.Size = new System.Drawing.Size(81, 20);
            this.labelTextura.TabIndex = 30;
            this.labelTextura.Text = "Textura";
            // 
            // textTecnica
            // 
            this.textTecnica.Location = new System.Drawing.Point(105, 384);
            this.textTecnica.Name = "textTecnica";
            this.textTecnica.Size = new System.Drawing.Size(173, 27);
            this.textTecnica.TabIndex = 29;
            this.textTecnica.TextChanged += new System.EventHandler(this.textTecnica_TextChanged);
            // 
            // labelTecnica
            // 
            this.labelTecnica.AutoSize = true;
            this.labelTecnica.Location = new System.Drawing.Point(24, 391);
            this.labelTecnica.Name = "labelTecnica";
            this.labelTecnica.Size = new System.Drawing.Size(82, 20);
            this.labelTecnica.TabIndex = 28;
            this.labelTecnica.Text = "Tecnica";
            // 
            // FechaIngreso
            // 
            this.FechaIngreso.Location = new System.Drawing.Point(169, 331);
            this.FechaIngreso.Name = "FechaIngreso";
            this.FechaIngreso.Size = new System.Drawing.Size(257, 27);
            this.FechaIngreso.TabIndex = 27;
            // 
            // labelFechaIngreso
            // 
            this.labelFechaIngreso.AutoSize = true;
            this.labelFechaIngreso.Location = new System.Drawing.Point(24, 331);
            this.labelFechaIngreso.Name = "labelFechaIngreso";
            this.labelFechaIngreso.Size = new System.Drawing.Size(139, 20);
            this.labelFechaIngreso.TabIndex = 26;
            this.labelFechaIngreso.Text = "Fecha Ingerso";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(105, 271);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 28);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(24, 279);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(72, 20);
            this.labelEstado.TabIndex = 24;
            this.labelEstado.Text = "Estado";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(105, 219);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(173, 27);
            this.txtPrecio.TabIndex = 23;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(24, 222);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(68, 20);
            this.labelPrecio.TabIndex = 22;
            this.labelPrecio.Text = "Precio";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(105, 159);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(173, 27);
            this.txtAutor.TabIndex = 21;
            this.txtAutor.TextChanged += new System.EventHandler(this.txtAutor_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Autor";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(105, 98);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(173, 27);
            this.txtTitulo.TabIndex = 19;
            this.txtTitulo.TextChanged += new System.EventHandler(this.txtTitulo_TextChanged);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(23, 101);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(62, 20);
            this.labelTitulo.TabIndex = 18;
            this.labelTitulo.Text = "Titulo";
            // 
            // txtIdEscultura
            // 
            this.txtIdEscultura.Location = new System.Drawing.Point(73, 39);
            this.txtIdEscultura.Name = "txtIdEscultura";
            this.txtIdEscultura.Size = new System.Drawing.Size(100, 27);
            this.txtIdEscultura.TabIndex = 17;
            this.txtIdEscultura.TextChanged += new System.EventHandler(this.txtIdEscultura_TextChanged);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(23, 42);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(26, 20);
            this.labelId.TabIndex = 16;
            this.labelId.Text = "Id";
            // 
            // btnAñadir
            // 
            this.btnAñadir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAñadir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAñadir.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadir.Location = new System.Drawing.Point(985, 314);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(131, 37);
            this.btnAñadir.TabIndex = 32;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // FormAñadirEscultura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.BackgroundImage = global::GaleriadeArte.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1200, 562);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.txtTextura);
            this.Controls.Add(this.labelTextura);
            this.Controls.Add(this.textTecnica);
            this.Controls.Add(this.labelTecnica);
            this.Controls.Add(this.FechaIngreso);
            this.Controls.Add(this.labelFechaIngreso);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.txtIdEscultura);
            this.Controls.Add(this.labelId);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("MS UI Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAñadirEscultura";
            this.Text = "FormAñadirEscultura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTextura;
        private System.Windows.Forms.Label labelTextura;
        private System.Windows.Forms.TextBox textTecnica;
        private System.Windows.Forms.Label labelTecnica;
        private System.Windows.Forms.DateTimePicker FechaIngreso;
        private System.Windows.Forms.Label labelFechaIngreso;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.TextBox txtIdEscultura;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Button btnAñadir;
    }
}