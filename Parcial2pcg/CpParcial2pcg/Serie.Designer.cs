namespace CpParcial2pcg
{
    partial class Serie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Serie));
            this.lblCedulaIdentidad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblserie = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtSinopsis = new System.Windows.Forms.TextBox();
            this.txtdirector = new System.Windows.Forms.TextBox();
            this.txtEpisodios = new System.Windows.Forms.TextBox();
            this.txtFechaEstreno = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dgvseries = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvseries)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCedulaIdentidad
            // 
            this.lblCedulaIdentidad.AccessibleName = "lblTitulo";
            this.lblCedulaIdentidad.AutoSize = true;
            this.lblCedulaIdentidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedulaIdentidad.ForeColor = System.Drawing.Color.Lavender;
            this.lblCedulaIdentidad.Location = new System.Drawing.Point(200, 57);
            this.lblCedulaIdentidad.Name = "lblCedulaIdentidad";
            this.lblCedulaIdentidad.Size = new System.Drawing.Size(47, 17);
            this.lblCedulaIdentidad.TabIndex = 1;
            this.lblCedulaIdentidad.Text = "Título:";
            this.lblCedulaIdentidad.Click += new System.EventHandler(this.lblCedulaIdentidad_Click);
            // 
            // label1
            // 
            this.label1.AccessibleName = "lblSinopsis";
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lavender;
            this.label1.Location = new System.Drawing.Point(182, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sinopsis:";
            // 
            // lblserie
            // 
            this.lblserie.AccessibleName = "lblSerie";
            this.lblserie.BackColor = System.Drawing.Color.Thistle;
            this.lblserie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblserie.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblserie.Location = new System.Drawing.Point(7, 9);
            this.lblserie.Name = "lblserie";
            this.lblserie.Size = new System.Drawing.Size(800, 31);
            this.lblserie.TabIndex = 8;
            this.lblserie.Text = "Serie";
            this.lblserie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AccessibleName = "lblfechaEstreno";
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lavender;
            this.label2.Location = new System.Drawing.Point(119, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fecha de  Estreno:";
            // 
            // label3
            // 
            this.label3.AccessibleName = "lblEpisodios";
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lavender;
            this.label3.Location = new System.Drawing.Point(174, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Episodios:";
            // 
            // label4
            // 
            this.label4.AccessibleName = "lblDirector";
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lavender;
            this.label4.Location = new System.Drawing.Point(185, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Director:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.Color.Pink;
            this.txtTitulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTitulo.Location = new System.Drawing.Point(272, 56);
            this.txtTitulo.MaxLength = 12;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(390, 20);
            this.txtTitulo.TabIndex = 12;
            // 
            // txtSinopsis
            // 
            this.txtSinopsis.BackColor = System.Drawing.Color.Pink;
            this.txtSinopsis.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSinopsis.Location = new System.Drawing.Point(272, 86);
            this.txtSinopsis.MaxLength = 12;
            this.txtSinopsis.Name = "txtSinopsis";
            this.txtSinopsis.Size = new System.Drawing.Size(390, 20);
            this.txtSinopsis.TabIndex = 13;
            // 
            // txtdirector
            // 
            this.txtdirector.BackColor = System.Drawing.Color.Pink;
            this.txtdirector.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdirector.Location = new System.Drawing.Point(272, 117);
            this.txtdirector.MaxLength = 12;
            this.txtdirector.Name = "txtdirector";
            this.txtdirector.Size = new System.Drawing.Size(390, 20);
            this.txtdirector.TabIndex = 14;
            // 
            // txtEpisodios
            // 
            this.txtEpisodios.BackColor = System.Drawing.Color.Pink;
            this.txtEpisodios.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEpisodios.Location = new System.Drawing.Point(272, 145);
            this.txtEpisodios.MaxLength = 12;
            this.txtEpisodios.Name = "txtEpisodios";
            this.txtEpisodios.Size = new System.Drawing.Size(390, 20);
            this.txtEpisodios.TabIndex = 15;
            // 
            // txtFechaEstreno
            // 
            this.txtFechaEstreno.BackColor = System.Drawing.Color.Pink;
            this.txtFechaEstreno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFechaEstreno.Location = new System.Drawing.Point(272, 176);
            this.txtFechaEstreno.MaxLength = 12;
            this.txtFechaEstreno.Name = "txtFechaEstreno";
            this.txtFechaEstreno.Size = new System.Drawing.Size(390, 20);
            this.txtFechaEstreno.TabIndex = 16;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Blue;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(185, 207);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnEditar.Size = new System.Drawing.Size(110, 40);
            this.btnEditar.TabIndex = 17;
            this.btnEditar.Text = "Guardar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Crimson;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(370, 207);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnEliminar.Size = new System.Drawing.Size(110, 40);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(567, 207);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnLimpiar.Size = new System.Drawing.Size(110, 40);
            this.btnLimpiar.TabIndex = 19;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // dgvseries
            // 
            this.dgvseries.AccessibleName = "dgvSeries";
            this.dgvseries.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvseries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvseries.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvseries.Location = new System.Drawing.Point(12, 253);
            this.dgvseries.Name = "dgvseries";
            this.dgvseries.Size = new System.Drawing.Size(795, 183);
            this.dgvseries.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AccessibleName = "lblid";
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(84, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Id";
            // 
            // label6
            // 
            this.label6.AccessibleName = "lblid";
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(172, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "Título";
            // 
            // label7
            // 
            this.label7.AccessibleName = "lblDirector";
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(288, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "Director";
            // 
            // label8
            // 
            this.label8.AccessibleName = "lblepisodios";
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(427, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 25);
            this.label8.TabIndex = 23;
            this.label8.Text = "Episodios";
            // 
            // label9
            // 
            this.label9.AccessibleName = "lblFechaestreno";
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(590, 274);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 25);
            this.label9.TabIndex = 24;
            this.label9.Text = "Fecha Estreno";
            // 
            // Serie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumOrchid;
            this.ClientSize = new System.Drawing.Size(819, 448);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvseries);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtFechaEstreno);
            this.Controls.Add(this.txtEpisodios);
            this.Controls.Add(this.txtdirector);
            this.Controls.Add(this.txtSinopsis);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblserie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCedulaIdentidad);
            this.ForeColor = System.Drawing.Color.BlueViolet;
            this.Name = "Serie";
            this.Text = ":::-Serie-:::";
            ((System.ComponentModel.ISupportInitialize)(this.dgvseries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCedulaIdentidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblserie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtSinopsis;
        private System.Windows.Forms.TextBox txtdirector;
        private System.Windows.Forms.TextBox txtEpisodios;
        private System.Windows.Forms.TextBox txtFechaEstreno;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dgvseries;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

