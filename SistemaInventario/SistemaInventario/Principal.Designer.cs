namespace SistemaInventario
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.metroButton1 = new ns1.BunifuImageButton();
            this.metroButton2 = new ns1.BunifuImageButton();
            this.txt_Salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.metroButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.Transparent;
            this.metroButton1.Image = global::SistemaInventario.Properties.Resources.pintura1;
            this.metroButton1.ImageActive = null;
            this.metroButton1.Location = new System.Drawing.Point(243, 257);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(191, 150);
            this.metroButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.metroButton1.TabIndex = 2;
            this.metroButton1.TabStop = false;
            this.metroButton1.Zoom = 10;
            this.metroButton1.Click += new System.EventHandler(this.MetroButton1_Click_1);
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.Transparent;
            this.metroButton2.Image = global::SistemaInventario.Properties.Resources.impresora;
            this.metroButton2.ImageActive = null;
            this.metroButton2.Location = new System.Drawing.Point(243, 63);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(191, 143);
            this.metroButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.metroButton2.TabIndex = 1;
            this.metroButton2.TabStop = false;
            this.metroButton2.Zoom = 10;
            this.metroButton2.Click += new System.EventHandler(this.MetroButton2_Click_1);
            // 
            // txt_Salir
            // 
            this.txt_Salir.Image = global::SistemaInventario.Properties.Resources.Login_37128;
            this.txt_Salir.Location = new System.Drawing.Point(511, 12);
            this.txt_Salir.Name = "txt_Salir";
            this.txt_Salir.Size = new System.Drawing.Size(75, 61);
            this.txt_Salir.TabIndex = 3;
            this.txt_Salir.UseVisualStyleBackColor = true;
            this.txt_Salir.Click += new System.EventHandler(this.txt_Salir_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaInventario.Properties.Resources.photo_1535370976884_f4376736ab06;
            this.ClientSize = new System.Drawing.Size(598, 456);
            this.Controls.Add(this.txt_Salir);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroButton2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroButton2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ns1.BunifuImageButton metroButton2;
        private ns1.BunifuImageButton metroButton1;
        private System.Windows.Forms.Button txt_Salir;
    }
}