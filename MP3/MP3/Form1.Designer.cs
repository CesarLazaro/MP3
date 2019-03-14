namespace MP3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Lista_Canciones = new System.Windows.Forms.ListBox();
            this.b = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.PLAYER = new AxWMPLib.AxWindowsMediaPlayer();
            this.Lista_datos = new System.Windows.Forms.ListBox();
            this.Primero = new System.Windows.Forms.Button();
            this.Siguiente = new System.Windows.Forms.Button();
            this.Ultimo = new System.Windows.Forms.Button();
            this.Atras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PLAYER)).BeginInit();
            this.SuspendLayout();
            // 
            // Lista_Canciones
            // 
            this.Lista_Canciones.FormattingEnabled = true;
            this.Lista_Canciones.Location = new System.Drawing.Point(12, 12);
            this.Lista_Canciones.Name = "Lista_Canciones";
            this.Lista_Canciones.Size = new System.Drawing.Size(235, 199);
            this.Lista_Canciones.TabIndex = 0;
            this.Lista_Canciones.SelectedIndexChanged += new System.EventHandler(this.Lista_Canciones_SelectedIndexChanged);
            // 
            // b
            // 
            this.b.Image = ((System.Drawing.Image)(resources.GetObject("b.Image")));
            this.b.Location = new System.Drawing.Point(12, 217);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(75, 90);
            this.b.TabIndex = 1;
            this.b.UseVisualStyleBackColor = true;
            this.b.Click += new System.EventHandler(this.b_Click);
            // 
            // PLAYER
            // 
            this.PLAYER.Enabled = true;
            this.PLAYER.Location = new System.Drawing.Point(262, 12);
            this.PLAYER.Name = "PLAYER";
            this.PLAYER.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("PLAYER.OcxState")));
            this.PLAYER.Size = new System.Drawing.Size(318, 46);
            this.PLAYER.TabIndex = 6;
            // 
            // Lista_datos
            // 
            this.Lista_datos.FormattingEnabled = true;
            this.Lista_datos.Location = new System.Drawing.Point(262, 59);
            this.Lista_datos.Name = "Lista_datos";
            this.Lista_datos.Size = new System.Drawing.Size(318, 121);
            this.Lista_datos.TabIndex = 7;
            // 
            // Primero
            // 
            this.Primero.Image = ((System.Drawing.Image)(resources.GetObject("Primero.Image")));
            this.Primero.Location = new System.Drawing.Point(262, 186);
            this.Primero.Name = "Primero";
            this.Primero.Size = new System.Drawing.Size(75, 75);
            this.Primero.TabIndex = 8;
            this.Primero.UseVisualStyleBackColor = true;
            this.Primero.Click += new System.EventHandler(this.Primero_Click);
            // 
            // Siguiente
            // 
            this.Siguiente.Image = ((System.Drawing.Image)(resources.GetObject("Siguiente.Image")));
            this.Siguiente.Location = new System.Drawing.Point(424, 186);
            this.Siguiente.Name = "Siguiente";
            this.Siguiente.Size = new System.Drawing.Size(75, 75);
            this.Siguiente.TabIndex = 9;
            this.Siguiente.UseVisualStyleBackColor = true;
            this.Siguiente.Click += new System.EventHandler(this.Siguiente_Click);
            // 
            // Ultimo
            // 
            this.Ultimo.Image = ((System.Drawing.Image)(resources.GetObject("Ultimo.Image")));
            this.Ultimo.Location = new System.Drawing.Point(505, 186);
            this.Ultimo.Name = "Ultimo";
            this.Ultimo.Size = new System.Drawing.Size(75, 75);
            this.Ultimo.TabIndex = 10;
            this.Ultimo.UseVisualStyleBackColor = true;
            this.Ultimo.Click += new System.EventHandler(this.Ultimo_Click);
            // 
            // Atras
            // 
            this.Atras.Image = ((System.Drawing.Image)(resources.GetObject("Atras.Image")));
            this.Atras.Location = new System.Drawing.Point(343, 186);
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(75, 75);
            this.Atras.TabIndex = 11;
            this.Atras.UseVisualStyleBackColor = true;
            this.Atras.Click += new System.EventHandler(this.Atras_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 334);
            this.Controls.Add(this.Atras);
            this.Controls.Add(this.Ultimo);
            this.Controls.Add(this.Siguiente);
            this.Controls.Add(this.Primero);
            this.Controls.Add(this.Lista_datos);
            this.Controls.Add(this.PLAYER);
            this.Controls.Add(this.b);
            this.Controls.Add(this.Lista_Canciones);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PLAYER)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Lista_Canciones;
        private System.Windows.Forms.Button b;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private AxWMPLib.AxWindowsMediaPlayer PLAYER;
        private System.Windows.Forms.ListBox Lista_datos;
        private System.Windows.Forms.Button Primero;
        private System.Windows.Forms.Button Siguiente;
        private System.Windows.Forms.Button Ultimo;
        private System.Windows.Forms.Button Atras;
    }
}

