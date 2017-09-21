namespace WindowsFormsApplication3.Vistas
{
    partial class vistaPrevBatalla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vistaPrevBatalla));
            this.labelFila = new System.Windows.Forms.Label();
            this.labelColumna = new System.Windows.Forms.Label();
            this.labelCantBarcos = new System.Windows.Forms.Label();
            this.labelNivel = new System.Windows.Forms.Label();
            this.labelEquipoPreferido = new System.Windows.Forms.Label();
            this.comboNivel = new System.Windows.Forms.ComboBox();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.numericFila = new System.Windows.Forms.NumericUpDown();
            this.numericColumna = new System.Windows.Forms.NumericUpDown();
            this.comboEquipoPreferido = new System.Windows.Forms.ComboBox();
            this.numericCantBarcos = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericFila)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericColumna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantBarcos)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFila
            // 
            this.labelFila.AutoSize = true;
            this.labelFila.BackColor = System.Drawing.Color.Transparent;
            this.labelFila.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelFila.Font = new System.Drawing.Font("Matura MT Script Capitals", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFila.ForeColor = System.Drawing.Color.Crimson;
            this.labelFila.Location = new System.Drawing.Point(567, 146);
            this.labelFila.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFila.Name = "labelFila";
            this.labelFila.Size = new System.Drawing.Size(153, 26);
            this.labelFila.TabIndex = 2;
            this.labelFila.Text = "Numero de fila";
            // 
            // labelColumna
            // 
            this.labelColumna.AutoSize = true;
            this.labelColumna.BackColor = System.Drawing.Color.Transparent;
            this.labelColumna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelColumna.Font = new System.Drawing.Font("Matura MT Script Capitals", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColumna.ForeColor = System.Drawing.Color.Crimson;
            this.labelColumna.Location = new System.Drawing.Point(567, 229);
            this.labelColumna.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelColumna.Name = "labelColumna";
            this.labelColumna.Size = new System.Drawing.Size(193, 26);
            this.labelColumna.TabIndex = 3;
            this.labelColumna.Text = "Numero de columna";
            // 
            // labelCantBarcos
            // 
            this.labelCantBarcos.AutoSize = true;
            this.labelCantBarcos.BackColor = System.Drawing.Color.Transparent;
            this.labelCantBarcos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCantBarcos.Font = new System.Drawing.Font("Matura MT Script Capitals", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantBarcos.ForeColor = System.Drawing.Color.Crimson;
            this.labelCantBarcos.Location = new System.Drawing.Point(567, 312);
            this.labelCantBarcos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCantBarcos.Name = "labelCantBarcos";
            this.labelCantBarcos.Size = new System.Drawing.Size(194, 26);
            this.labelCantBarcos.TabIndex = 4;
            this.labelCantBarcos.Text = "Cantidad de Barcos";
            // 
            // labelNivel
            // 
            this.labelNivel.AutoSize = true;
            this.labelNivel.BackColor = System.Drawing.Color.Transparent;
            this.labelNivel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelNivel.Font = new System.Drawing.Font("Matura MT Script Capitals", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNivel.ForeColor = System.Drawing.Color.Crimson;
            this.labelNivel.Location = new System.Drawing.Point(567, 386);
            this.labelNivel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNivel.Name = "labelNivel";
            this.labelNivel.Size = new System.Drawing.Size(70, 26);
            this.labelNivel.TabIndex = 5;
            this.labelNivel.Text = "Nivel";
            // 
            // labelEquipoPreferido
            // 
            this.labelEquipoPreferido.AutoSize = true;
            this.labelEquipoPreferido.BackColor = System.Drawing.Color.Transparent;
            this.labelEquipoPreferido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelEquipoPreferido.Font = new System.Drawing.Font("Matura MT Script Capitals", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEquipoPreferido.ForeColor = System.Drawing.Color.Crimson;
            this.labelEquipoPreferido.Location = new System.Drawing.Point(567, 486);
            this.labelEquipoPreferido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEquipoPreferido.Name = "labelEquipoPreferido";
            this.labelEquipoPreferido.Size = new System.Drawing.Size(165, 26);
            this.labelEquipoPreferido.TabIndex = 6;
            this.labelEquipoPreferido.Text = "Equipo Preferido";
            // 
            // comboNivel
            // 
            this.comboNivel.FormattingEnabled = true;
            this.comboNivel.Items.AddRange(new object[] {
            "Facil",
            "Medio",
            "Dificil"});
            this.comboNivel.Location = new System.Drawing.Point(809, 383);
            this.comboNivel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboNivel.Name = "comboNivel";
            this.comboNivel.Size = new System.Drawing.Size(180, 28);
            this.comboNivel.TabIndex = 8;
            // 
            // buttonVolver
            // 
            this.buttonVolver.BackColor = System.Drawing.Color.Transparent;
            this.buttonVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVolver.Font = new System.Drawing.Font("Matura MT Script Capitals", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVolver.ForeColor = System.Drawing.Color.Crimson;
            this.buttonVolver.Location = new System.Drawing.Point(628, 573);
            this.buttonVolver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(112, 35);
            this.buttonVolver.TabIndex = 10;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = false;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.BackColor = System.Drawing.Color.Transparent;
            this.buttonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAceptar.Font = new System.Drawing.Font("Matura MT Script Capitals", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAceptar.ForeColor = System.Drawing.Color.Crimson;
            this.buttonAceptar.Location = new System.Drawing.Point(845, 573);
            this.buttonAceptar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(112, 35);
            this.buttonAceptar.TabIndex = 11;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = false;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // numericFila
            // 
            this.numericFila.Location = new System.Drawing.Point(809, 146);
            this.numericFila.Name = "numericFila";
            this.numericFila.Size = new System.Drawing.Size(108, 26);
            this.numericFila.TabIndex = 13;
            // 
            // numericColumna
            // 
            this.numericColumna.Location = new System.Drawing.Point(810, 227);
            this.numericColumna.Name = "numericColumna";
            this.numericColumna.Size = new System.Drawing.Size(108, 26);
            this.numericColumna.TabIndex = 14;
            // 
            // comboEquipoPreferido
            // 
            this.comboEquipoPreferido.FormattingEnabled = true;
            this.comboEquipoPreferido.Items.AddRange(new object[] {
            "UniversidadDeChile",
            "UnionEspañola"});
            this.comboEquipoPreferido.Location = new System.Drawing.Point(810, 478);
            this.comboEquipoPreferido.Name = "comboEquipoPreferido";
            this.comboEquipoPreferido.Size = new System.Drawing.Size(180, 28);
            this.comboEquipoPreferido.TabIndex = 16;
            // 
            // numericCantBarcos
            // 
            this.numericCantBarcos.Location = new System.Drawing.Point(809, 306);
            this.numericCantBarcos.Name = "numericCantBarcos";
            this.numericCantBarcos.Size = new System.Drawing.Size(108, 26);
            this.numericCantBarcos.TabIndex = 20;
            // 
            // vistaPrevBatalla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1002, 712);
            this.Controls.Add(this.numericCantBarcos);
            this.Controls.Add(this.comboEquipoPreferido);
            this.Controls.Add(this.numericColumna);
            this.Controls.Add(this.numericFila);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.comboNivel);
            this.Controls.Add(this.labelEquipoPreferido);
            this.Controls.Add(this.labelNivel);
            this.Controls.Add(this.labelCantBarcos);
            this.Controls.Add(this.labelColumna);
            this.Controls.Add(this.labelFila);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "vistaPrevBatalla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vista Previa Batalla";
            this.Load += new System.EventHandler(this.vistaPrevBatalla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericFila)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericColumna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantBarcos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelFila;
        private System.Windows.Forms.Label labelColumna;
        private System.Windows.Forms.Label labelCantBarcos;
        private System.Windows.Forms.Label labelNivel;
        private System.Windows.Forms.Label labelEquipoPreferido;
        private System.Windows.Forms.ComboBox comboNivel;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.NumericUpDown numericFila;
        private System.Windows.Forms.NumericUpDown numericColumna;
        private System.Windows.Forms.ComboBox comboEquipoPreferido;
        private System.Windows.Forms.NumericUpDown numericCantBarcos;
    }
}