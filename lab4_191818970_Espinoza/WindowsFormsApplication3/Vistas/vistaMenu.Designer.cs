namespace WindowsFormsApplication3.Vistas
{
    partial class VistaMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaMenu));
            this.buttonPerfil = new System.Windows.Forms.Button();
            this.butJugar = new System.Windows.Forms.Button();
            this.butVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPerfil
            // 
            this.buttonPerfil.BackColor = System.Drawing.Color.Transparent;
            this.buttonPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPerfil.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPerfil.Location = new System.Drawing.Point(98, 328);
            this.buttonPerfil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPerfil.Name = "buttonPerfil";
            this.buttonPerfil.Size = new System.Drawing.Size(279, 42);
            this.buttonPerfil.TabIndex = 1;
            this.buttonPerfil.Text = "PERFIL";
            this.buttonPerfil.UseVisualStyleBackColor = false;
            this.buttonPerfil.Click += new System.EventHandler(this.button2_Click);
            // 
            // butJugar
            // 
            this.butJugar.BackColor = System.Drawing.Color.Transparent;
            this.butJugar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butJugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butJugar.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butJugar.Location = new System.Drawing.Point(98, 190);
            this.butJugar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butJugar.Name = "butJugar";
            this.butJugar.Size = new System.Drawing.Size(279, 42);
            this.butJugar.TabIndex = 3;
            this.butJugar.Text = "JUGAR";
            this.butJugar.UseVisualStyleBackColor = false;
            this.butJugar.Click += new System.EventHandler(this.butJugar_Click);
            // 
            // butVolver
            // 
            this.butVolver.BackColor = System.Drawing.Color.Transparent;
            this.butVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butVolver.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butVolver.Location = new System.Drawing.Point(98, 498);
            this.butVolver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butVolver.Name = "butVolver";
            this.butVolver.Size = new System.Drawing.Size(279, 42);
            this.butVolver.TabIndex = 4;
            this.butVolver.Text = "VOLVER";
            this.butVolver.UseVisualStyleBackColor = false;
            this.butVolver.Click += new System.EventHandler(this.button5_Click);
            // 
            // VistaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1002, 712);
            this.Controls.Add(this.butVolver);
            this.Controls.Add(this.butJugar);
            this.Controls.Add(this.buttonPerfil);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "VistaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "vistaMenu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonPerfil;
        private System.Windows.Forms.Button butJugar;
        private System.Windows.Forms.Button butVolver;
    }
}