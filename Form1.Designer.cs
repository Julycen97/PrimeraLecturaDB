namespace PrimeraLecturaBD
{
    partial class frmLecturaPokemons
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
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.btnObtenerDatos = new System.Windows.Forms.Button();
            this.pbxImagenPokemon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(29, 26);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(444, 170);
            this.dgvDatos.TabIndex = 0;
            this.dgvDatos.SelectionChanged += new System.EventHandler(this.dgvDatos_SelectionChanged);
            // 
            // btnObtenerDatos
            // 
            this.btnObtenerDatos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnObtenerDatos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnObtenerDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObtenerDatos.Location = new System.Drawing.Point(504, 26);
            this.btnObtenerDatos.Name = "btnObtenerDatos";
            this.btnObtenerDatos.Size = new System.Drawing.Size(75, 23);
            this.btnObtenerDatos.TabIndex = 1;
            this.btnObtenerDatos.Text = "Obtener";
            this.btnObtenerDatos.UseVisualStyleBackColor = false;
            this.btnObtenerDatos.Click += new System.EventHandler(this.btnObtenerDatos_Click);
            // 
            // pbxImagenPokemon
            // 
            this.pbxImagenPokemon.Location = new System.Drawing.Point(504, 71);
            this.pbxImagenPokemon.Name = "pbxImagenPokemon";
            this.pbxImagenPokemon.Size = new System.Drawing.Size(159, 125);
            this.pbxImagenPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagenPokemon.TabIndex = 2;
            this.pbxImagenPokemon.TabStop = false;
            // 
            // frmLecturaPokemons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 224);
            this.Controls.Add(this.pbxImagenPokemon);
            this.Controls.Add(this.btnObtenerDatos);
            this.Controls.Add(this.dgvDatos);
            this.Name = "frmLecturaPokemons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lectura BD";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenPokemon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Button btnObtenerDatos;
        private System.Windows.Forms.PictureBox pbxImagenPokemon;
    }
}

