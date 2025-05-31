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
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dgvseries = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbxIdiomaOriginal = new System.Windows.Forms.ComboBox();
            this.dtpFechaEstreno = new System.Windows.Forms.DateTimePicker();
            this.nudEpisodios = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvseries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEpisodios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCedulaIdentidad
            // 
            this.lblCedulaIdentidad.AccessibleName = "lblTitulo";
            this.lblCedulaIdentidad.AutoSize = true;
            this.lblCedulaIdentidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedulaIdentidad.ForeColor = System.Drawing.Color.Lavender;
            this.lblCedulaIdentidad.Location = new System.Drawing.Point(90, 58);
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
            this.label1.Location = new System.Drawing.Point(72, 87);
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
            this.label2.Location = new System.Drawing.Point(9, 177);
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
            this.label3.Location = new System.Drawing.Point(64, 146);
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
            this.label4.Location = new System.Drawing.Point(75, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Director:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.Color.Pink;
            this.txtTitulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTitulo.Location = new System.Drawing.Point(162, 57);
            this.txtTitulo.MaxLength = 12;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(390, 20);
            this.txtTitulo.TabIndex = 12;
            // 
            // txtSinopsis
            // 
            this.txtSinopsis.BackColor = System.Drawing.Color.Pink;
            this.txtSinopsis.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSinopsis.Location = new System.Drawing.Point(162, 87);
            this.txtSinopsis.MaxLength = 12;
            this.txtSinopsis.Name = "txtSinopsis";
            this.txtSinopsis.Size = new System.Drawing.Size(390, 20);
            this.txtSinopsis.TabIndex = 13;
            // 
            // txtdirector
            // 
            this.txtdirector.BackColor = System.Drawing.Color.Pink;
            this.txtdirector.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdirector.Location = new System.Drawing.Point(162, 118);
            this.txtdirector.MaxLength = 12;
            this.txtdirector.Name = "txtdirector";
            this.txtdirector.Size = new System.Drawing.Size(390, 20);
            this.txtdirector.TabIndex = 14;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Blue;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(183, 271);
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
            this.btnEliminar.Location = new System.Drawing.Point(368, 271);
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
            this.btnLimpiar.Location = new System.Drawing.Point(565, 271);
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
            this.dgvseries.Location = new System.Drawing.Point(12, 317);
            this.dgvseries.Name = "dgvseries";
            this.dgvseries.Size = new System.Drawing.Size(795, 162);
            this.dgvseries.TabIndex = 20;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Pink;
            this.textBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox2.Location = new System.Drawing.Point(162, 204);
            this.textBox2.MaxLength = 12;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(390, 20);
            this.textBox2.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AccessibleName = "lblUrlPortada";
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Lavender;
            this.label10.Location = new System.Drawing.Point(53, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 17);
            this.label10.TabIndex = 26;
            this.label10.Text = "Url Portada:";
            // 
            // label11
            // 
            this.label11.AccessibleName = "lblIdiomaOriginal";
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Lavender;
            this.label11.Location = new System.Drawing.Point(31, 235);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "Idioma Original:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.pictureBox1.Location = new System.Drawing.Point(584, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 152);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AccessibleName = "lblUrlPortada";
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Lavender;
            this.label12.Location = new System.Drawing.Point(618, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 17);
            this.label12.TabIndex = 30;
            this.label12.Text = "Vista Previa de Imaen";
            // 
            // cbxIdiomaOriginal
            // 
            this.cbxIdiomaOriginal.BackColor = System.Drawing.Color.Pink;
            this.cbxIdiomaOriginal.FormattingEnabled = true;
            this.cbxIdiomaOriginal.Items.AddRange(new object[] {
            "Chino",
            "Español",
            "Ingles",
            "Japones"});
            this.cbxIdiomaOriginal.Location = new System.Drawing.Point(162, 234);
            this.cbxIdiomaOriginal.Margin = new System.Windows.Forms.Padding(2);
            this.cbxIdiomaOriginal.Name = "cbxIdiomaOriginal";
            this.cbxIdiomaOriginal.Size = new System.Drawing.Size(390, 21);
            this.cbxIdiomaOriginal.TabIndex = 31;
            // 
            // dtpFechaEstreno
            // 
            this.dtpFechaEstreno.CalendarMonthBackground = System.Drawing.Color.Pink;
            this.dtpFechaEstreno.CalendarTitleBackColor = System.Drawing.Color.Pink;
            this.dtpFechaEstreno.Location = new System.Drawing.Point(162, 177);
            this.dtpFechaEstreno.Name = "dtpFechaEstreno";
            this.dtpFechaEstreno.Size = new System.Drawing.Size(390, 20);
            this.dtpFechaEstreno.TabIndex = 32;
            // 
            // nudEpisodios
            // 
            this.nudEpisodios.BackColor = System.Drawing.Color.Pink;
            this.nudEpisodios.Location = new System.Drawing.Point(161, 143);
            this.nudEpisodios.Name = "nudEpisodios";
            this.nudEpisodios.Size = new System.Drawing.Size(391, 20);
            this.nudEpisodios.TabIndex = 33;
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(681, 383);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.button1.Size = new System.Drawing.Size(111, 40);
            this.button1.TabIndex = 37;
            this.button1.Text = "Cancelar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(570, 383);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.button2.Size = new System.Drawing.Size(105, 40);
            this.button2.TabIndex = 36;
            this.button2.Text = "Guardar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Serie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumOrchid;
            this.ClientSize = new System.Drawing.Size(819, 448);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.nudEpisodios);
            this.Controls.Add(this.dtpFechaEstreno);
            this.Controls.Add(this.cbxIdiomaOriginal);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvseries);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEpisodios)).EndInit();
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
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dgvseries;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbxIdiomaOriginal;
        private System.Windows.Forms.DateTimePicker dtpFechaEstreno;
        private System.Windows.Forms.NumericUpDown nudEpisodios;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

