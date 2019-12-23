namespace SistemaInventario
{
    partial class Proveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proveedores));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel5 = new MetroFramework.Controls.MetroPanel();
            this.btn_Cancelar = new ns1.BunifuThinButton2();
            this.tbxStatus = new ns1.BunifuMaterialTextbox();
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.txtAdquisicion = new ns1.BunifuMaterialTextbox();
            this.btn_Eliminar = new ns1.BunifuThinButton2();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.txtNombre = new ns1.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.btn_Guardar = new ns1.BunifuThinButton2();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.gtb_datos = new ns1.BunifuCustomDataGrid();
            this.bunifuGradientPanel1 = new ns1.BunifuGradientPanel();
            this.bunifuCustomLabel5 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new ns1.BunifuCustomLabel();
            this.dtpFecha = new ns1.BunifuDatepicker();
            this.cbx_Marcas = new MetroFramework.Controls.MetroComboBox();
            this.btnAtras = new System.Windows.Forms.Button();
            this.metroPanel5.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gtb_datos)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel5
            // 
            this.metroPanel5.Controls.Add(this.btn_Cancelar);
            this.metroPanel5.Controls.Add(this.tbxStatus);
            this.metroPanel5.Controls.Add(this.bunifuCustomLabel3);
            this.metroPanel5.HorizontalScrollbarBarColor = true;
            this.metroPanel5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel5.HorizontalScrollbarSize = 10;
            this.metroPanel5.Location = new System.Drawing.Point(622, 302);
            this.metroPanel5.Name = "metroPanel5";
            this.metroPanel5.Size = new System.Drawing.Size(487, 76);
            this.metroPanel5.TabIndex = 24;
            this.metroPanel5.VerticalScrollbarBarColor = true;
            this.metroPanel5.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel5.VerticalScrollbarSize = 10;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.ActiveBorderThickness = 1;
            this.btn_Cancelar.ActiveCornerRadius = 20;
            this.btn_Cancelar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_Cancelar.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Cancelar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Cancelar.BackColor = System.Drawing.SystemColors.Info;
            this.btn_Cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cancelar.BackgroundImage")));
            this.btn_Cancelar.ButtonText = "Cancelar";
            this.btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Cancelar.IdleBorderThickness = 1;
            this.btn_Cancelar.IdleCornerRadius = 20;
            this.btn_Cancelar.IdleFillColor = System.Drawing.Color.White;
            this.btn_Cancelar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_Cancelar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Cancelar.Location = new System.Drawing.Point(359, 11);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(119, 41);
            this.btn_Cancelar.TabIndex = 4;
            this.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // tbxStatus
            // 
            this.tbxStatus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxStatus.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbxStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxStatus.HintForeColor = System.Drawing.Color.Empty;
            this.tbxStatus.HintText = "";
            this.tbxStatus.isPassword = false;
            this.tbxStatus.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbxStatus.LineIdleColor = System.Drawing.Color.Gray;
            this.tbxStatus.LineMouseHoverColor = System.Drawing.Color.Black;
            this.tbxStatus.LineThickness = 3;
            this.tbxStatus.Location = new System.Drawing.Point(20, 31);
            this.tbxStatus.Margin = new System.Windows.Forms.Padding(4);
            this.tbxStatus.Name = "tbxStatus";
            this.tbxStatus.Size = new System.Drawing.Size(266, 35);
            this.tbxStatus.TabIndex = 8;
            this.tbxStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(17, 11);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(179, 16);
            this.bunifuCustomLabel3.TabIndex = 4;
            this.bunifuCustomLabel3.Text = "Estado del Producto";
            // 
            // metroPanel4
            // 
            this.metroPanel4.Controls.Add(this.txtAdquisicion);
            this.metroPanel4.Controls.Add(this.btn_Eliminar);
            this.metroPanel4.Controls.Add(this.bunifuCustomLabel2);
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(622, 223);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(487, 73);
            this.metroPanel4.TabIndex = 23;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // txtAdquisicion
            // 
            this.txtAdquisicion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdquisicion.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAdquisicion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAdquisicion.HintForeColor = System.Drawing.Color.Empty;
            this.txtAdquisicion.HintText = "";
            this.txtAdquisicion.isPassword = false;
            this.txtAdquisicion.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtAdquisicion.LineIdleColor = System.Drawing.Color.Gray;
            this.txtAdquisicion.LineMouseHoverColor = System.Drawing.Color.Black;
            this.txtAdquisicion.LineThickness = 3;
            this.txtAdquisicion.Location = new System.Drawing.Point(4, 30);
            this.txtAdquisicion.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdquisicion.Name = "txtAdquisicion";
            this.txtAdquisicion.Size = new System.Drawing.Size(282, 35);
            this.txtAdquisicion.TabIndex = 7;
            this.txtAdquisicion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.ActiveBorderThickness = 1;
            this.btn_Eliminar.ActiveCornerRadius = 20;
            this.btn_Eliminar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_Eliminar.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Eliminar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Eliminar.BackColor = System.Drawing.SystemColors.Info;
            this.btn_Eliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Eliminar.BackgroundImage")));
            this.btn_Eliminar.ButtonText = "Eliminar";
            this.btn_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Eliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Eliminar.IdleBorderThickness = 1;
            this.btn_Eliminar.IdleCornerRadius = 20;
            this.btn_Eliminar.IdleFillColor = System.Drawing.Color.White;
            this.btn_Eliminar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_Eliminar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Eliminar.Location = new System.Drawing.Point(359, 24);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(119, 41);
            this.btn_Eliminar.TabIndex = 3;
            this.btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(10, 4);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(78, 22);
            this.bunifuCustomLabel2.TabIndex = 3;
            this.bunifuCustomLabel2.Text = "Producto";
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.txtNombre);
            this.metroPanel2.Controls.Add(this.bunifuCustomLabel1);
            this.metroPanel2.Controls.Add(this.btn_Guardar);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(622, 144);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(487, 73);
            this.metroPanel2.TabIndex = 22;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // txtNombre
            // 
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombre.HintForeColor = System.Drawing.Color.Empty;
            this.txtNombre.HintText = "";
            this.txtNombre.isPassword = false;
            this.txtNombre.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtNombre.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNombre.LineMouseHoverColor = System.Drawing.Color.Black;
            this.txtNombre.LineThickness = 3;
            this.txtNombre.Location = new System.Drawing.Point(14, 27);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(272, 35);
            this.txtNombre.TabIndex = 6;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(22, 10);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(152, 13);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Nombre del Proveedor";
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.ActiveBorderThickness = 1;
            this.btn_Guardar.ActiveCornerRadius = 20;
            this.btn_Guardar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_Guardar.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Guardar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Guardar.BackColor = System.Drawing.SystemColors.Info;
            this.btn_Guardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Guardar.BackgroundImage")));
            this.btn_Guardar.ButtonText = "Guardar";
            this.btn_Guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Guardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Guardar.IdleBorderThickness = 1;
            this.btn_Guardar.IdleCornerRadius = 20;
            this.btn_Guardar.IdleFillColor = System.Drawing.Color.White;
            this.btn_Guardar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_Guardar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Guardar.Location = new System.Drawing.Point(359, 21);
            this.btn_Guardar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(119, 41);
            this.btn_Guardar.TabIndex = 2;
            this.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.gtb_datos);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(12, 68);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(601, 310);
            this.metroPanel3.TabIndex = 20;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // gtb_datos
            // 
            this.gtb_datos.AllowUserToAddRows = false;
            this.gtb_datos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gtb_datos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gtb_datos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gtb_datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gtb_datos.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.gtb_datos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gtb_datos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.gtb_datos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gtb_datos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gtb_datos.ColumnHeadersHeight = 29;
            this.gtb_datos.DoubleBuffered = true;
            this.gtb_datos.EnableHeadersVisualStyles = false;
            this.gtb_datos.GridColor = System.Drawing.Color.Silver;
            this.gtb_datos.HeaderBgColor = System.Drawing.Color.DarkCyan;
            this.gtb_datos.HeaderForeColor = System.Drawing.Color.DarkSlateGray;
            this.gtb_datos.Location = new System.Drawing.Point(12, 13);
            this.gtb_datos.Name = "gtb_datos";
            this.gtb_datos.ReadOnly = true;
            this.gtb_datos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gtb_datos.RowHeadersWidth = 51;
            this.gtb_datos.Size = new System.Drawing.Size(579, 278);
            this.gtb_datos.TabIndex = 11;
            this.gtb_datos.DoubleClick += new System.EventHandler(this.Gtb_datos_DoubleClick);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel5);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel4);
            this.bunifuGradientPanel1.Controls.Add(this.dtpFecha);
            this.bunifuGradientPanel1.Controls.Add(this.cbx_Marcas);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(619, 68);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(490, 70);
            this.bunifuGradientPanel1.TabIndex = 21;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(208, 13);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(52, 22);
            this.bunifuCustomLabel5.TabIndex = 5;
            this.bunifuCustomLabel5.Text = "Fecha";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(3, 13);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(63, 22);
            this.bunifuCustomLabel4.TabIndex = 4;
            this.bunifuCustomLabel4.Text = "Marcas";
            // 
            // dtpFecha
            // 
            this.dtpFecha.BackColor = System.Drawing.Color.SeaGreen;
            this.dtpFecha.BorderRadius = 0;
            this.dtpFecha.ForeColor = System.Drawing.Color.White;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpFecha.FormatCustom = null;
            this.dtpFecha.Location = new System.Drawing.Point(196, 38);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(285, 29);
            this.dtpFecha.TabIndex = 1;
            this.dtpFecha.Value = new System.DateTime(2019, 11, 11, 10, 20, 36, 278);
            // 
            // cbx_Marcas
            // 
            this.cbx_Marcas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_Marcas.FormattingEnabled = true;
            this.cbx_Marcas.ItemHeight = 23;
            this.cbx_Marcas.Location = new System.Drawing.Point(3, 38);
            this.cbx_Marcas.Name = "cbx_Marcas";
            this.cbx_Marcas.Size = new System.Drawing.Size(183, 29);
            this.cbx_Marcas.TabIndex = 0;
            // 
            // btnAtras
            // 
            this.btnAtras.Image = global::SistemaInventario.Properties.Resources.atras21;
            this.btnAtras.Location = new System.Drawing.Point(1048, 26);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(61, 36);
            this.btnAtras.TabIndex = 25;
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1123, 387);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.metroPanel5);
            this.Controls.Add(this.metroPanel4);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.metroPanel3);
            this.Name = "Proveedores";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.Proveedores_Load);
            this.metroPanel5.ResumeLayout(false);
            this.metroPanel5.PerformLayout();
            this.metroPanel4.ResumeLayout(false);
            this.metroPanel4.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.metroPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gtb_datos)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroPanel metroPanel5;
        private ns1.BunifuMaterialTextbox tbxStatus;
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private ns1.BunifuMaterialTextbox txtAdquisicion;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private ns1.BunifuMaterialTextbox txtNombre;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private ns1.BunifuGradientPanel bunifuGradientPanel1;
        private MetroFramework.Controls.MetroComboBox cbx_Marcas;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private ns1.BunifuCustomDataGrid gtb_datos;
        private ns1.BunifuThinButton2 btn_Cancelar;
        private ns1.BunifuThinButton2 btn_Eliminar;
        private ns1.BunifuThinButton2 btn_Guardar;
        private ns1.BunifuDatepicker dtpFecha;
        private ns1.BunifuCustomLabel bunifuCustomLabel5;
        private ns1.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.Button btnAtras;
        //private Bunifu.Framework.UI.BunifuDatepicker dtpFecha;
    }
}