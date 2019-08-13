namespace SistemaInventario
{
    partial class Tonner
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tonner));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.bunifuCustomDataGrid1 = new ns1.BunifuCustomDataGrid();
            this.btn_cancelar = new ns1.BunifuThinButton2();
            this.btn_guardar = new ns1.BunifuThinButton2();
            this.btn_borrar = new ns1.BunifuThinButton2();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.cbx_Marcas = new MetroFramework.Controls.MetroComboBox();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.txt_Modelo = new ns1.BunifuMaterialTextbox();
            this.txt_buscar = new ns1.BunifuTextbox();
            this.bunifuThinButton23 = new ns1.BunifuThinButton2();
            this.gtb_datos = new ns1.BunifuCustomDataGrid();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gtb_datos)).BeginInit();
            this.metroPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.bunifuCustomDataGrid1);
            this.metroPanel2.Controls.Add(this.btn_cancelar);
            this.metroPanel2.Controls.Add(this.btn_guardar);
            this.metroPanel2.Controls.Add(this.btn_borrar);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(77, 384);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(418, 54);
            this.metroPanel2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroPanel2.TabIndex = 10;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // bunifuCustomDataGrid1
            // 
            this.bunifuCustomDataGrid1.AllowUserToAddRows = false;
            this.bunifuCustomDataGrid1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.bunifuCustomDataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomDataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.bunifuCustomDataGrid1.ColumnHeadersHeight = 29;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.GridColor = System.Drawing.Color.Silver;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.DarkCyan;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(-3, -140);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.ReadOnly = true;
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.RowHeadersWidth = 51;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(418, 122);
            this.bunifuCustomDataGrid1.TabIndex = 2;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.ActiveBorderThickness = 1;
            this.btn_cancelar.ActiveCornerRadius = 20;
            this.btn_cancelar.ActiveFillColor = System.Drawing.Color.Yellow;
            this.btn_cancelar.ActiveForecolor = System.Drawing.Color.Black;
            this.btn_cancelar.ActiveLineColor = System.Drawing.Color.Green;
            this.btn_cancelar.BackColor = System.Drawing.SystemColors.Control;
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
            this.btn_cancelar.Location = new System.Drawing.Point(309, 5);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(90, 37);
            this.btn_cancelar.TabIndex = 7;
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_guardar
            // 
            this.btn_guardar.ActiveBorderThickness = 1;
            this.btn_guardar.ActiveCornerRadius = 20;
            this.btn_guardar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_guardar.ActiveForecolor = System.Drawing.Color.Black;
            this.btn_guardar.ActiveLineColor = System.Drawing.Color.Green;
            this.btn_guardar.BackColor = System.Drawing.SystemColors.Control;
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
            this.btn_guardar.Location = new System.Drawing.Point(20, 5);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(104, 36);
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
            this.btn_borrar.BackColor = System.Drawing.SystemColors.Control;
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
            this.btn_borrar.Location = new System.Drawing.Point(171, 5);
            this.btn_borrar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(104, 37);
            this.btn_borrar.TabIndex = 5;
            this.btn_borrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_borrar.Click += new System.EventHandler(this.Btn_borrar_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.metroPanel1.Controls.Add(this.cbx_Marcas);
            this.metroPanel1.Controls.Add(this.bunifuCustomLabel2);
            this.metroPanel1.Controls.Add(this.bunifuCustomLabel1);
            this.metroPanel1.Controls.Add(this.txt_Modelo);
            this.metroPanel1.Controls.Add(this.txt_buscar);
            this.metroPanel1.Controls.Add(this.bunifuThinButton23);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 90);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(569, 90);
            this.metroPanel1.TabIndex = 9;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // cbx_Marcas
            // 
            this.cbx_Marcas.FormattingEnabled = true;
            this.cbx_Marcas.ItemHeight = 23;
            this.cbx_Marcas.Location = new System.Drawing.Point(228, 52);
            this.cbx_Marcas.Name = "cbx_Marcas";
            this.cbx_Marcas.Size = new System.Drawing.Size(154, 29);
            this.cbx_Marcas.TabIndex = 12;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(244, 25);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(121, 23);
            this.bunifuCustomLabel2.TabIndex = 11;
            this.bunifuCustomLabel2.Text = "Marca";
            this.bunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(31, 25);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(121, 23);
            this.bunifuCustomLabel1.TabIndex = 9;
            this.bunifuCustomLabel1.Text = "Modelo";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Modelo
            // 
            this.txt_Modelo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Modelo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Modelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Modelo.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Modelo.HintText = "";
            this.txt_Modelo.isPassword = false;
            this.txt_Modelo.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_Modelo.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_Modelo.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_Modelo.LineThickness = 3;
            this.txt_Modelo.Location = new System.Drawing.Point(6, 47);
            this.txt_Modelo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Modelo.Name = "txt_Modelo";
            this.txt_Modelo.Size = new System.Drawing.Size(175, 34);
            this.txt_Modelo.TabIndex = 8;
            this.txt_Modelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_buscar
            // 
            this.txt_buscar.BackColor = System.Drawing.Color.Silver;
            this.txt_buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_buscar.BackgroundImage")));
            this.txt_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txt_buscar.ForeColor = System.Drawing.Color.SeaGreen;
            this.txt_buscar.Icon = ((System.Drawing.Image)(resources.GetObject("txt_buscar.Icon")));
            this.txt_buscar.Location = new System.Drawing.Point(409, 52);
            this.txt_buscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(156, 34);
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
            this.bunifuThinButton23.Location = new System.Drawing.Point(466, 5);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(81, 43);
            this.bunifuThinButton23.TabIndex = 6;
            this.bunifuThinButton23.Tag = "";
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gtb_datos
            // 
            this.gtb_datos.AllowUserToAddRows = false;
            this.gtb_datos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gtb_datos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.gtb_datos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gtb_datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gtb_datos.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.gtb_datos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gtb_datos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.gtb_datos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gtb_datos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.gtb_datos.ColumnHeadersHeight = 29;
            this.gtb_datos.DoubleBuffered = true;
            this.gtb_datos.EnableHeadersVisualStyles = false;
            this.gtb_datos.GridColor = System.Drawing.Color.Silver;
            this.gtb_datos.HeaderBgColor = System.Drawing.Color.DarkCyan;
            this.gtb_datos.HeaderForeColor = System.Drawing.Color.DarkSlateGray;
            this.gtb_datos.Location = new System.Drawing.Point(6, 14);
            this.gtb_datos.Name = "gtb_datos";
            this.gtb_datos.ReadOnly = true;
            this.gtb_datos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gtb_datos.RowHeadersWidth = 51;
            this.gtb_datos.Size = new System.Drawing.Size(412, 149);
            this.gtb_datos.TabIndex = 11;
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.gtb_datos);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(77, 183);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(421, 181);
            this.metroPanel3.TabIndex = 12;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // Tonner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 450);
            this.Controls.Add(this.metroPanel3);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.MaximizeBox = false;
            this.Name = "Tonner";
            this.Text = " Tonner";
            this.Load += new System.EventHandler(this.Tonner_Load);
            this.metroPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gtb_datos)).EndInit();
            this.metroPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel2;
        private ns1.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private ns1.BunifuThinButton2 btn_cancelar;
        private ns1.BunifuThinButton2 btn_guardar;
        private ns1.BunifuThinButton2 btn_borrar;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private ns1.BunifuMaterialTextbox txt_Modelo;
        private ns1.BunifuTextbox txt_buscar;
        private ns1.BunifuThinButton2 bunifuThinButton23;
        private ns1.BunifuCustomDataGrid gtb_datos;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private MetroFramework.Controls.MetroComboBox cbx_Marcas;
    }
}