namespace SistemaInventario
{
    partial class Ubicacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ubicacion));
            this.gtb_datos = new ns1.BunifuCustomDataGrid();
            this.tbx_Ubucacion = new ns1.BunifuMetroTextbox();
            this.btn_Envios = new System.Windows.Forms.Button();
            this.btn_Impresora = new System.Windows.Forms.Button();
            this.bunifuGradientPanel1 = new ns1.BunifuGradientPanel();
            this.btn_Cancelar = new ns1.BunifuThinButton2();
            this.btn_Eliminar = new ns1.BunifuThinButton2();
            this.btn_guardar = new ns1.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.gtb_datos)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gtb_datos
            // 
            this.gtb_datos.AllowUserToAddRows = false;
            this.gtb_datos.AllowUserToDeleteRows = false;
            this.gtb_datos.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gtb_datos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gtb_datos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gtb_datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gtb_datos.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.gtb_datos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gtb_datos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.gtb_datos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gtb_datos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gtb_datos.ColumnHeadersHeight = 29;
            this.gtb_datos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gtb_datos.DoubleBuffered = true;
            this.gtb_datos.EnableHeadersVisualStyles = false;
            this.gtb_datos.GridColor = System.Drawing.Color.Silver;
            this.gtb_datos.HeaderBgColor = System.Drawing.Color.DarkCyan;
            this.gtb_datos.HeaderForeColor = System.Drawing.Color.DarkSlateGray;
            this.gtb_datos.Location = new System.Drawing.Point(126, 108);
            this.gtb_datos.MultiSelect = false;
            this.gtb_datos.Name = "gtb_datos";
            this.gtb_datos.ReadOnly = true;
            this.gtb_datos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gtb_datos.RowHeadersWidth = 51;
            this.gtb_datos.Size = new System.Drawing.Size(175, 174);
            this.gtb_datos.TabIndex = 11;
            this.gtb_datos.DoubleClick += new System.EventHandler(this.Gtb_datos_DoubleClick);
            // 
            // tbx_Ubucacion
            // 
            this.tbx_Ubucacion.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbx_Ubucacion.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbx_Ubucacion.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbx_Ubucacion.BorderThickness = 2;
            this.tbx_Ubucacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbx_Ubucacion.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Ubucacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbx_Ubucacion.isPassword = false;
            this.tbx_Ubucacion.Location = new System.Drawing.Point(4, 53);
            this.tbx_Ubucacion.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbx_Ubucacion.Name = "tbx_Ubucacion";
            this.tbx_Ubucacion.Size = new System.Drawing.Size(175, 33);
            this.tbx_Ubucacion.TabIndex = 13;
            this.tbx_Ubucacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_Envios
            // 
            this.btn_Envios.Image = global::SistemaInventario.Properties.Resources.encios;
            this.btn_Envios.Location = new System.Drawing.Point(201, 30);
            this.btn_Envios.Name = "btn_Envios";
            this.btn_Envios.Size = new System.Drawing.Size(45, 56);
            this.btn_Envios.TabIndex = 28;
            this.btn_Envios.UseVisualStyleBackColor = true;
            this.btn_Envios.Click += new System.EventHandler(this.Btn_Envios_Click);
            // 
            // btn_Impresora
            // 
            this.btn_Impresora.Image = global::SistemaInventario.Properties.Resources.impre;
            this.btn_Impresora.Location = new System.Drawing.Point(264, 30);
            this.btn_Impresora.Name = "btn_Impresora";
            this.btn_Impresora.Size = new System.Drawing.Size(49, 56);
            this.btn_Impresora.TabIndex = 27;
            this.btn_Impresora.UseVisualStyleBackColor = true;
            this.btn_Impresora.Click += new System.EventHandler(this.BtnAtras_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Purple;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuGradientPanel1.Controls.Add(this.btn_Cancelar);
            this.bunifuGradientPanel1.Controls.Add(this.btn_Eliminar);
            this.bunifuGradientPanel1.Controls.Add(this.btn_guardar);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(4, 108);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(105, 174);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.ActiveBorderThickness = 1;
            this.btn_Cancelar.ActiveCornerRadius = 20;
            this.btn_Cancelar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Cancelar.ActiveForecolor = System.Drawing.Color.Black;
            this.btn_Cancelar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Cancelar.BackColor = System.Drawing.Color.Purple;
            this.btn_Cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cancelar.BackgroundImage")));
            this.btn_Cancelar.ButtonText = "Cancelar";
            this.btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.Color.Black;
            this.btn_Cancelar.IdleBorderThickness = 1;
            this.btn_Cancelar.IdleCornerRadius = 20;
            this.btn_Cancelar.IdleFillColor = System.Drawing.Color.White;
            this.btn_Cancelar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_Cancelar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Cancelar.Location = new System.Drawing.Point(5, 119);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(93, 38);
            this.btn_Cancelar.TabIndex = 8;
            this.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.ActiveBorderThickness = 1;
            this.btn_Eliminar.ActiveCornerRadius = 20;
            this.btn_Eliminar.ActiveFillColor = System.Drawing.Color.Red;
            this.btn_Eliminar.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Eliminar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Eliminar.BackColor = System.Drawing.Color.Purple;
            this.btn_Eliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Eliminar.BackgroundImage")));
            this.btn_Eliminar.ButtonText = "Eliminar";
            this.btn_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Eliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.ForeColor = System.Drawing.Color.Black;
            this.btn_Eliminar.IdleBorderThickness = 1;
            this.btn_Eliminar.IdleCornerRadius = 20;
            this.btn_Eliminar.IdleFillColor = System.Drawing.Color.White;
            this.btn_Eliminar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_Eliminar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Eliminar.Location = new System.Drawing.Point(5, 62);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(93, 38);
            this.btn_Eliminar.TabIndex = 7;
            this.btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.ActiveBorderThickness = 1;
            this.btn_guardar.ActiveCornerRadius = 20;
            this.btn_guardar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_guardar.ActiveForecolor = System.Drawing.Color.White;
            this.btn_guardar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_guardar.BackColor = System.Drawing.Color.Purple;
            this.btn_guardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_guardar.BackgroundImage")));
            this.btn_guardar.ButtonText = "Guardar";
            this.btn_guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_guardar.IdleBorderThickness = 1;
            this.btn_guardar.IdleCornerRadius = 20;
            this.btn_guardar.IdleFillColor = System.Drawing.Color.White;
            this.btn_guardar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_guardar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_guardar.Location = new System.Drawing.Point(5, 5);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(93, 38);
            this.btn_guardar.TabIndex = 6;
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Ubicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 290);
            this.Controls.Add(this.btn_Envios);
            this.Controls.Add(this.btn_Impresora);
            this.Controls.Add(this.tbx_Ubucacion);
            this.Controls.Add(this.gtb_datos);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.MaximizeBox = false;
            this.Name = "Ubicacion";
            this.Text = "Ubicacion";
            this.Load += new System.EventHandler(this.Ubicacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gtb_datos)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuGradientPanel bunifuGradientPanel1;
        private ns1.BunifuThinButton2 btn_Cancelar;
        private ns1.BunifuThinButton2 btn_Eliminar;
        private ns1.BunifuThinButton2 btn_guardar;
        private ns1.BunifuCustomDataGrid gtb_datos;
        private ns1.BunifuMetroTextbox tbx_Ubucacion;
        private System.Windows.Forms.Button btn_Impresora;
        private System.Windows.Forms.Button btn_Envios;
    }
}