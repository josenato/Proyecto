namespace SistemaInventario
{
    partial class Marcas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Marcas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.txt_Descripcion = new ns1.BunifuMaterialTextbox();
            this.txt_buscar = new ns1.BunifuTextbox();
            this.bunifuThinButton23 = new ns1.BunifuThinButton2();
            this.btn_guardar = new ns1.BunifuThinButton2();
            this.btn_borrar = new ns1.BunifuThinButton2();
            this.btn_cancelar = new ns1.BunifuThinButton2();
            this.gtb_datos = new ns1.BunifuCustomDataGrid();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gtb_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.metroPanel1.Controls.Add(this.bunifuCustomLabel1);
            this.metroPanel1.Controls.Add(this.txt_Descripcion);
            this.metroPanel1.Controls.Add(this.txt_buscar);
            this.metroPanel1.Controls.Add(this.bunifuThinButton23);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 12;
            this.metroPanel1.Location = new System.Drawing.Point(27, 74);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(561, 111);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 13;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(4, 15);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(161, 28);
            this.bunifuCustomLabel1.TabIndex = 9;
            this.bunifuCustomLabel1.Text = "Descripcion";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Descripcion.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Descripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Descripcion.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Descripcion.HintText = "";
            this.txt_Descripcion.isPassword = false;
            this.txt_Descripcion.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_Descripcion.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_Descripcion.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_Descripcion.LineThickness = 3;
            this.txt_Descripcion.Location = new System.Drawing.Point(8, 48);
            this.txt_Descripcion.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(233, 42);
            this.txt_Descripcion.TabIndex = 8;
            this.txt_Descripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_buscar
            // 
            this.txt_buscar.BackColor = System.Drawing.Color.Silver;
            this.txt_buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_buscar.BackgroundImage")));
            this.txt_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txt_buscar.ForeColor = System.Drawing.Color.SeaGreen;
            this.txt_buscar.Icon = ((System.Drawing.Image)(resources.GetObject("txt_buscar.Icon")));
            this.txt_buscar.Location = new System.Drawing.Point(265, 64);
            this.txt_buscar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(208, 42);
            this.txt_buscar.TabIndex = 7;
            this.txt_buscar.text = "";
            // 
            // bunifuThinButton23
            // 
            this.bunifuThinButton23.ActiveBorderThickness = 1;
            this.bunifuThinButton23.ActiveCornerRadius = 20;
            this.bunifuThinButton23.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton23.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.BackColor = System.Drawing.Color.DarkTurquoise;
            this.bunifuThinButton23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton23.BackgroundImage")));
            this.bunifuThinButton23.ButtonText = "Buscar";
            this.bunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton23.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton23.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.IdleBorderThickness = 1;
            this.bunifuThinButton23.IdleCornerRadius = 20;
            this.bunifuThinButton23.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton23.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.Location = new System.Drawing.Point(314, 6);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(133, 53);
            this.bunifuThinButton23.TabIndex = 6;
            this.bunifuThinButton23.Tag = "";
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton23.Click += new System.EventHandler(this.BunifuThinButton23_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.ActiveBorderThickness = 1;
            this.btn_guardar.ActiveCornerRadius = 20;
            this.btn_guardar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_guardar.ActiveForecolor = System.Drawing.Color.Black;
            this.btn_guardar.ActiveLineColor = System.Drawing.Color.Green;
            this.btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.btn_guardar.Location = new System.Drawing.Point(95, 394);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(117, 44);
            this.btn_guardar.TabIndex = 6;
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // btn_borrar
            // 
            this.btn_borrar.ActiveBorderThickness = 1;
            this.btn_borrar.ActiveCornerRadius = 20;
            this.btn_borrar.ActiveFillColor = System.Drawing.Color.Red;
            this.btn_borrar.ActiveForecolor = System.Drawing.Color.Black;
            this.btn_borrar.ActiveLineColor = System.Drawing.Color.Green;
            this.btn_borrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_borrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_borrar.BackgroundImage")));
            this.btn_borrar.ButtonText = "Eliminar ";
            this.btn_borrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_borrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_borrar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_borrar.IdleBorderThickness = 1;
            this.btn_borrar.IdleCornerRadius = 20;
            this.btn_borrar.IdleFillColor = System.Drawing.Color.White;
            this.btn_borrar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_borrar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_borrar.Location = new System.Drawing.Point(226, 393);
            this.btn_borrar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(120, 45);
            this.btn_borrar.TabIndex = 5;
            this.btn_borrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_borrar.Click += new System.EventHandler(this.Btn_borrar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.ActiveBorderThickness = 1;
            this.btn_cancelar.ActiveCornerRadius = 20;
            this.btn_cancelar.ActiveFillColor = System.Drawing.Color.Yellow;
            this.btn_cancelar.ActiveForecolor = System.Drawing.Color.Black;
            this.btn_cancelar.ActiveLineColor = System.Drawing.Color.Green;
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.BackgroundImage")));
            this.btn_cancelar.ButtonText = "Cancelar";
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_cancelar.IdleBorderThickness = 1;
            this.btn_cancelar.IdleCornerRadius = 20;
            this.btn_cancelar.IdleFillColor = System.Drawing.Color.White;
            this.btn_cancelar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_cancelar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_cancelar.Location = new System.Drawing.Point(369, 393);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(120, 45);
            this.btn_cancelar.TabIndex = 7;
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // gtb_datos
            // 
            this.gtb_datos.AllowUserToAddRows = false;
            this.gtb_datos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gtb_datos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gtb_datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.gtb_datos.BackgroundColor = System.Drawing.Color.White;
            this.gtb_datos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gtb_datos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gtb_datos.ColumnHeadersHeight = 29;
            this.gtb_datos.DoubleBuffered = true;
            this.gtb_datos.EnableHeadersVisualStyles = false;
            this.gtb_datos.GridColor = System.Drawing.Color.Red;
            this.gtb_datos.HeaderBgColor = System.Drawing.Color.DarkCyan;
            this.gtb_datos.HeaderForeColor = System.Drawing.Color.LightSeaGreen;
            this.gtb_datos.Location = new System.Drawing.Point(95, 207);
            this.gtb_datos.Margin = new System.Windows.Forms.Padding(4);
            this.gtb_datos.Name = "gtb_datos";
            this.gtb_datos.ReadOnly = true;
            this.gtb_datos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gtb_datos.RowHeadersWidth = 51;
            this.gtb_datos.Size = new System.Drawing.Size(394, 150);
            this.gtb_datos.TabIndex = 2;
            this.gtb_datos.DoubleClick += new System.EventHandler(this.Gtb_datos_DoubleClick);
            // 
            // Marcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 475);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.gtb_datos);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.btn_borrar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Marcas";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Marcas";
            this.Load += new System.EventHandler(this.Marcas_Load);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gtb_datos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private ns1.BunifuThinButton2 bunifuThinButton23;
        private ns1.BunifuThinButton2 btn_borrar;
        private ns1.BunifuThinButton2 btn_guardar;
        private ns1.BunifuTextbox txt_buscar;
        private ns1.BunifuMaterialTextbox txt_Descripcion;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private ns1.BunifuThinButton2 btn_cancelar;
        private ns1.BunifuCustomDataGrid gtb_datos;
    }
}