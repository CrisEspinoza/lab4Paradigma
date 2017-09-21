namespace WindowsFormsApplication3.Vistas
{
    partial class VistaTerreno
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaTerreno));
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonRendirse = new System.Windows.Forms.Button();
            this.buttonComenzarBatalla = new System.Windows.Forms.Button();
            this.panelTablero = new System.Windows.Forms.Panel();
            this.groupColocarBarco = new System.Windows.Forms.GroupBox();
            this.buttonColocarAceptar = new System.Windows.Forms.Button();
            this.comboBoxBarcos = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonBarcoMAtaque = new System.Windows.Forms.Button();
            this.buttonBarcoEAtaque = new System.Windows.Forms.Button();
            this.tiempo = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelPuntajeUsuario = new System.Windows.Forms.Label();
            this.labelComputadora = new System.Windows.Forms.Label();
            this.labelPuntajeCompu = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelArmaBarco = new System.Windows.Forms.Label();
            this.labelMunicionBarco = new System.Windows.Forms.Label();
            this.labelVidaBarco = new System.Windows.Forms.Label();
            this.labelNivelBarco = new System.Windows.Forms.Label();
            this.labelNombreBarco = new System.Windows.Forms.Label();
            this.labelMunicion = new System.Windows.Forms.Label();
            this.labelArma = new System.Windows.Forms.Label();
            this.labelVida = new System.Windows.Forms.Label();
            this.labelNivel = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupColocarBarco.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(867, 98);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 0);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.buttonGuardar);
            this.groupBox1.Controls.Add(this.buttonRendirse);
            this.groupBox1.Controls.Add(this.buttonComenzarBatalla);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(929, 98);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(300, 161);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OPCIONES";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuardar.Font = new System.Drawing.Font("Matura MT Script Capitals", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.Location = new System.Drawing.Point(28, 96);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(120, 40);
            this.buttonGuardar.TabIndex = 3;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonRendirse
            // 
            this.buttonRendirse.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonRendirse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRendirse.Font = new System.Drawing.Font("Matura MT Script Capitals", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRendirse.Location = new System.Drawing.Point(165, 96);
            this.buttonRendirse.Name = "buttonRendirse";
            this.buttonRendirse.Size = new System.Drawing.Size(120, 40);
            this.buttonRendirse.TabIndex = 2;
            this.buttonRendirse.Text = "Rendirse";
            this.buttonRendirse.UseVisualStyleBackColor = false;
            this.buttonRendirse.Click += new System.EventHandler(this.buttonRendirse_Click);
            // 
            // buttonComenzarBatalla
            // 
            this.buttonComenzarBatalla.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonComenzarBatalla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonComenzarBatalla.Font = new System.Drawing.Font("Matura MT Script Capitals", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonComenzarBatalla.Location = new System.Drawing.Point(28, 29);
            this.buttonComenzarBatalla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonComenzarBatalla.Name = "buttonComenzarBatalla";
            this.buttonComenzarBatalla.Size = new System.Drawing.Size(249, 42);
            this.buttonComenzarBatalla.TabIndex = 0;
            this.buttonComenzarBatalla.Text = "Comenzar batalla";
            this.buttonComenzarBatalla.UseVisualStyleBackColor = false;
            this.buttonComenzarBatalla.Click += new System.EventHandler(this.buttonDisparar_Click);
            // 
            // panelTablero
            // 
            this.panelTablero.BackColor = System.Drawing.Color.Transparent;
            this.panelTablero.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelTablero.Location = new System.Drawing.Point(3, 78);
            this.panelTablero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelTablero.Name = "panelTablero";
            this.panelTablero.Size = new System.Drawing.Size(918, 869);
            this.panelTablero.TabIndex = 3;
            this.panelTablero.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTablero_Paint);
            // 
            // groupColocarBarco
            // 
            this.groupColocarBarco.BackColor = System.Drawing.Color.Transparent;
            this.groupColocarBarco.Controls.Add(this.buttonColocarAceptar);
            this.groupColocarBarco.Controls.Add(this.comboBoxBarcos);
            this.groupColocarBarco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupColocarBarco.Location = new System.Drawing.Point(929, 471);
            this.groupColocarBarco.Name = "groupColocarBarco";
            this.groupColocarBarco.Size = new System.Drawing.Size(300, 162);
            this.groupColocarBarco.TabIndex = 4;
            this.groupColocarBarco.TabStop = false;
            this.groupColocarBarco.Text = "COLOCAR BARCOS";
            // 
            // buttonColocarAceptar
            // 
            this.buttonColocarAceptar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonColocarAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonColocarAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonColocarAceptar.Font = new System.Drawing.Font("Matura MT Script Capitals", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonColocarAceptar.Location = new System.Drawing.Point(28, 102);
            this.buttonColocarAceptar.Name = "buttonColocarAceptar";
            this.buttonColocarAceptar.Size = new System.Drawing.Size(120, 40);
            this.buttonColocarAceptar.TabIndex = 1;
            this.buttonColocarAceptar.Text = "Aceptar";
            this.buttonColocarAceptar.UseVisualStyleBackColor = false;
            this.buttonColocarAceptar.Click += new System.EventHandler(this.buttonColocarAceptar_Click);
            // 
            // comboBoxBarcos
            // 
            this.comboBoxBarcos.BackColor = System.Drawing.SystemColors.HighlightText;
            this.comboBoxBarcos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxBarcos.FormattingEnabled = true;
            this.comboBoxBarcos.Location = new System.Drawing.Point(28, 48);
            this.comboBoxBarcos.Name = "comboBoxBarcos";
            this.comboBoxBarcos.Size = new System.Drawing.Size(249, 28);
            this.comboBoxBarcos.TabIndex = 0;
            this.comboBoxBarcos.SelectedIndexChanged += new System.EventHandler(this.comboBoxBarcos_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.buttonBarcoMAtaque);
            this.groupBox2.Controls.Add(this.buttonBarcoEAtaque);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(929, 281);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 162);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ATAQUE";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // buttonBarcoMAtaque
            // 
            this.buttonBarcoMAtaque.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonBarcoMAtaque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBarcoMAtaque.Font = new System.Drawing.Font("Matura MT Script Capitals", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBarcoMAtaque.Location = new System.Drawing.Point(28, 45);
            this.buttonBarcoMAtaque.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBarcoMAtaque.Name = "buttonBarcoMAtaque";
            this.buttonBarcoMAtaque.Size = new System.Drawing.Size(249, 40);
            this.buttonBarcoMAtaque.TabIndex = 2;
            this.buttonBarcoMAtaque.Text = "Escoger equipo atacador";
            this.buttonBarcoMAtaque.UseVisualStyleBackColor = false;
            this.buttonBarcoMAtaque.Click += new System.EventHandler(this.buttonBarcoMAtaque_Click);
            // 
            // buttonBarcoEAtaque
            // 
            this.buttonBarcoEAtaque.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonBarcoEAtaque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBarcoEAtaque.Font = new System.Drawing.Font("Matura MT Script Capitals", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBarcoEAtaque.Location = new System.Drawing.Point(28, 109);
            this.buttonBarcoEAtaque.Name = "buttonBarcoEAtaque";
            this.buttonBarcoEAtaque.Size = new System.Drawing.Size(249, 40);
            this.buttonBarcoEAtaque.TabIndex = 1;
            this.buttonBarcoEAtaque.Text = "Casilla enemigo a atacar";
            this.buttonBarcoEAtaque.UseVisualStyleBackColor = false;
            this.buttonBarcoEAtaque.Click += new System.EventHandler(this.buttonBarcoEAtaque_Click);
            // 
            // tiempo
            // 
            this.tiempo.Interval = 1000;
            this.tiempo.Tick += new System.EventHandler(this.tiempo_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(822, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tiempo Restante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Matura MT Script Capitals", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1031, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "0";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Matura MT Script Capitals", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1123, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "segundos";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.BackColor = System.Drawing.Color.Transparent;
            this.labelUsuario.Font = new System.Drawing.Font("Matura MT Script Capitals", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.Location = new System.Drawing.Point(12, 28);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(167, 26);
            this.labelUsuario.TabIndex = 9;
            this.labelUsuario.Text = "Puntaje Usuario";
            // 
            // labelPuntajeUsuario
            // 
            this.labelPuntajeUsuario.AutoSize = true;
            this.labelPuntajeUsuario.BackColor = System.Drawing.Color.Transparent;
            this.labelPuntajeUsuario.Font = new System.Drawing.Font("Matura MT Script Capitals", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPuntajeUsuario.Location = new System.Drawing.Point(196, 28);
            this.labelPuntajeUsuario.Name = "labelPuntajeUsuario";
            this.labelPuntajeUsuario.Size = new System.Drawing.Size(25, 26);
            this.labelPuntajeUsuario.TabIndex = 10;
            this.labelPuntajeUsuario.Text = "0";
            // 
            // labelComputadora
            // 
            this.labelComputadora.AutoSize = true;
            this.labelComputadora.BackColor = System.Drawing.Color.Transparent;
            this.labelComputadora.Font = new System.Drawing.Font("Matura MT Script Capitals", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComputadora.Location = new System.Drawing.Point(358, 29);
            this.labelComputadora.Name = "labelComputadora";
            this.labelComputadora.Size = new System.Drawing.Size(207, 26);
            this.labelComputadora.TabIndex = 11;
            this.labelComputadora.Text = "Puntaje Computadora";
            // 
            // labelPuntajeCompu
            // 
            this.labelPuntajeCompu.AutoSize = true;
            this.labelPuntajeCompu.BackColor = System.Drawing.Color.Transparent;
            this.labelPuntajeCompu.Font = new System.Drawing.Font("Matura MT Script Capitals", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPuntajeCompu.Location = new System.Drawing.Point(589, 29);
            this.labelPuntajeCompu.Name = "labelPuntajeCompu";
            this.labelPuntajeCompu.Size = new System.Drawing.Size(25, 26);
            this.labelPuntajeCompu.TabIndex = 12;
            this.labelPuntajeCompu.Text = "0";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.labelArmaBarco);
            this.groupBox3.Controls.Add(this.labelMunicionBarco);
            this.groupBox3.Controls.Add(this.labelVidaBarco);
            this.groupBox3.Controls.Add(this.labelNivelBarco);
            this.groupBox3.Controls.Add(this.labelNombreBarco);
            this.groupBox3.Controls.Add(this.labelMunicion);
            this.groupBox3.Controls.Add(this.labelArma);
            this.groupBox3.Controls.Add(this.labelVida);
            this.groupBox3.Controls.Add(this.labelNivel);
            this.groupBox3.Controls.Add(this.labelNombre);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(928, 654);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(300, 280);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "INFORMACION EQUIPO";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // labelArmaBarco
            // 
            this.labelArmaBarco.AutoSize = true;
            this.labelArmaBarco.Font = new System.Drawing.Font("Matura MT Script Capitals", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArmaBarco.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelArmaBarco.Location = new System.Drawing.Point(126, 195);
            this.labelArmaBarco.Name = "labelArmaBarco";
            this.labelArmaBarco.Size = new System.Drawing.Size(16, 22);
            this.labelArmaBarco.TabIndex = 9;
            this.labelArmaBarco.Text = "-";
            // 
            // labelMunicionBarco
            // 
            this.labelMunicionBarco.AutoSize = true;
            this.labelMunicionBarco.Font = new System.Drawing.Font("Matura MT Script Capitals", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMunicionBarco.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelMunicionBarco.Location = new System.Drawing.Point(126, 248);
            this.labelMunicionBarco.Name = "labelMunicionBarco";
            this.labelMunicionBarco.Size = new System.Drawing.Size(16, 22);
            this.labelMunicionBarco.TabIndex = 8;
            this.labelMunicionBarco.Text = "-";
            // 
            // labelVidaBarco
            // 
            this.labelVidaBarco.AutoSize = true;
            this.labelVidaBarco.Font = new System.Drawing.Font("Matura MT Script Capitals", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVidaBarco.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelVidaBarco.Location = new System.Drawing.Point(126, 140);
            this.labelVidaBarco.Name = "labelVidaBarco";
            this.labelVidaBarco.Size = new System.Drawing.Size(16, 22);
            this.labelVidaBarco.TabIndex = 7;
            this.labelVidaBarco.Text = "-";
            // 
            // labelNivelBarco
            // 
            this.labelNivelBarco.AutoSize = true;
            this.labelNivelBarco.Font = new System.Drawing.Font("Matura MT Script Capitals", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNivelBarco.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelNivelBarco.Location = new System.Drawing.Point(126, 87);
            this.labelNivelBarco.Name = "labelNivelBarco";
            this.labelNivelBarco.Size = new System.Drawing.Size(16, 22);
            this.labelNivelBarco.TabIndex = 6;
            this.labelNivelBarco.Text = "-";
            // 
            // labelNombreBarco
            // 
            this.labelNombreBarco.AutoSize = true;
            this.labelNombreBarco.Font = new System.Drawing.Font("Matura MT Script Capitals", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreBarco.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelNombreBarco.Location = new System.Drawing.Point(126, 39);
            this.labelNombreBarco.Name = "labelNombreBarco";
            this.labelNombreBarco.Size = new System.Drawing.Size(16, 22);
            this.labelNombreBarco.TabIndex = 5;
            this.labelNombreBarco.Text = "-";
            // 
            // labelMunicion
            // 
            this.labelMunicion.AutoSize = true;
            this.labelMunicion.Font = new System.Drawing.Font("Matura MT Script Capitals", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMunicion.Location = new System.Drawing.Point(24, 248);
            this.labelMunicion.Name = "labelMunicion";
            this.labelMunicion.Size = new System.Drawing.Size(103, 26);
            this.labelMunicion.TabIndex = 4;
            this.labelMunicion.Text = "Municion";
            // 
            // labelArma
            // 
            this.labelArma.AutoSize = true;
            this.labelArma.Font = new System.Drawing.Font("Matura MT Script Capitals", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArma.Location = new System.Drawing.Point(24, 195);
            this.labelArma.Name = "labelArma";
            this.labelArma.Size = new System.Drawing.Size(71, 26);
            this.labelArma.TabIndex = 3;
            this.labelArma.Text = "Arma";
            // 
            // labelVida
            // 
            this.labelVida.AutoSize = true;
            this.labelVida.Font = new System.Drawing.Font("Matura MT Script Capitals", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVida.Location = new System.Drawing.Point(24, 140);
            this.labelVida.Name = "labelVida";
            this.labelVida.Size = new System.Drawing.Size(63, 26);
            this.labelVida.TabIndex = 2;
            this.labelVida.Text = "Vida";
            // 
            // labelNivel
            // 
            this.labelNivel.AutoSize = true;
            this.labelNivel.Font = new System.Drawing.Font("Matura MT Script Capitals", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNivel.Location = new System.Drawing.Point(24, 87);
            this.labelNivel.Name = "labelNivel";
            this.labelNivel.Size = new System.Drawing.Size(70, 26);
            this.labelNivel.TabIndex = 1;
            this.labelNivel.Text = "Nivel";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Matura MT Script Capitals", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(24, 39);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(89, 26);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            // 
            // VistaTerreno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1278, 959);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.labelPuntajeCompu);
            this.Controls.Add(this.labelComputadora);
            this.Controls.Add(this.labelPuntajeUsuario);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupColocarBarco);
            this.Controls.Add(this.panelTablero);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1300, 1015);
            this.MinimumSize = new System.Drawing.Size(1300, 1015);
            this.Name = "VistaTerreno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VistaTerreno";
            this.Load += new System.EventHandler(this.VistaTerreno_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupColocarBarco.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonComenzarBatalla;
        private System.Windows.Forms.GroupBox groupColocarBarco;
        private System.Windows.Forms.Button buttonColocarAceptar;
        private System.Windows.Forms.Button buttonRendirse;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonBarcoEAtaque;
        private System.Windows.Forms.Button buttonBarcoMAtaque;
        private System.Windows.Forms.Timer tiempo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelComputadora;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelMunicion;
        private System.Windows.Forms.Label labelArma;
        private System.Windows.Forms.Label labelVida;
        private System.Windows.Forms.Label labelNivel;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelMunicionBarco;
        private System.Windows.Forms.Label labelVidaBarco;
        private System.Windows.Forms.Label labelNivelBarco;
        private System.Windows.Forms.Label labelNombreBarco;
        private System.Windows.Forms.Label labelArmaBarco;
        public System.Windows.Forms.Panel panelTablero;
        public System.Windows.Forms.Label labelPuntajeUsuario;
        public System.Windows.Forms.Label labelPuntajeCompu;
        public System.Windows.Forms.ComboBox comboBoxBarcos;
    }
}