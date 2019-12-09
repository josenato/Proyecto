namespace SistemaInventario
{
    partial class SolicitudTonner
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SolicitudTonner));
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.gtb_datos = new ns1.BunifuCustomDataGrid();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btn_Cancelar = new ns1.BunifuThinButton2();
            this.btn_Eliminar = new ns1.BunifuThinButton2();
            this.btn_Guardar = new ns1.BunifuThinButton2();
            this.cbx_Tonner = new MetroFramework.Controls.MetroComboBox();
            this.Dtp_Fecha = new ns1.BunifuDatepicker();
            this.cbx_Marcas = new MetroFramework.Controls.MetroComboBox();
            this.cbxColor = new MetroFramework.Controls.MetroComboBox();
            this.jl = new MetroFramework.Controls.MetroLabel();
            this.lbl_ttt = new MetroFramework.Controls.MetroLabel();
            this.lbl_lv = new MetroFramework.Controls.MetroLabel();
            this.nudSoli = new System.Windows.Forms.NumericUpDown();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.lbl = new MetroFramework.Controls.MetroLabel();
            this.metroPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gtb_datos)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoli)).BeginInit();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.gtb_datos);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(12, 72);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(601, 336);
            this.metroPanel3.TabIndex = 23;
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
            this.gtb_datos.Size = new System.Drawing.Size(571, 291);
            this.gtb_datos.TabIndex = 11;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btn_Cancelar);
            this.metroPanel1.Controls.Add(this.btn_Eliminar);
            this.metroPanel1.Controls.Add(this.btn_Guardar);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(12, 429);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(601, 67);
            this.metroPanel1.TabIndex = 29;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.ActiveBorderThickness = 1;
            this.btn_Cancelar.ActiveCornerRadius = 20;
            this.btn_Cancelar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_Cancelar.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Cancelar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Cancelar.BackColor = System.Drawing.SystemColors.Control;
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
            this.btn_Cancelar.Location = new System.Drawing.Point(249, 8);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(105, 41);
            this.btn_Cancelar.TabIndex = 4;
            this.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.ActiveBorderThickness = 1;
            this.btn_Eliminar.ActiveCornerRadius = 20;
            this.btn_Eliminar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_Eliminar.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Eliminar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Eliminar.BackColor = System.Drawing.SystemColors.Control;
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
            this.btn_Eliminar.Location = new System.Drawing.Point(375, 5);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(119, 41);
            this.btn_Eliminar.TabIndex = 3;
            this.btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.ActiveBorderThickness = 1;
            this.btn_Guardar.ActiveCornerRadius = 20;
            this.btn_Guardar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_Guardar.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Guardar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Guardar.BackColor = System.Drawing.SystemColors.Control;
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
            this.btn_Guardar.Location = new System.Drawing.Point(120, 8);
            this.btn_Guardar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(119, 41);
            this.btn_Guardar.TabIndex = 2;
            this.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // cbx_Tonner
            // 
            this.cbx_Tonner.FormattingEnabled = true;
            this.cbx_Tonner.ItemHeight = 23;
            this.cbx_Tonner.Location = new System.Drawing.Point(14, 325);
            this.cbx_Tonner.Name = "cbx_Tonner";
            this.cbx_Tonner.Size = new System.Drawing.Size(193, 29);
            this.cbx_Tonner.TabIndex = 30;
            // 
            // Dtp_Fecha
            // 
            this.Dtp_Fecha.BackColor = System.Drawing.Color.SeaGreen;
            this.Dtp_Fecha.BorderRadius = 0;
            this.Dtp_Fecha.ForeColor = System.Drawing.Color.White;
            this.Dtp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.Dtp_Fecha.FormatCustom = null;
            this.Dtp_Fecha.Location = new System.Drawing.Point(14, 51);
            this.Dtp_Fecha.Name = "Dtp_Fecha";
            this.Dtp_Fecha.Size = new System.Drawing.Size(245, 35);
            this.Dtp_Fecha.TabIndex = 31;
            this.Dtp_Fecha.Value = new System.DateTime(2019, 9, 27, 17, 59, 25, 948);
            // 
            // cbx_Marcas
            // 
            this.cbx_Marcas.FormattingEnabled = true;
            this.cbx_Marcas.ItemHeight = 23;
            this.cbx_Marcas.Location = new System.Drawing.Point(14, 143);
            this.cbx_Marcas.Name = "cbx_Marcas";
            this.cbx_Marcas.Size = new System.Drawing.Size(193, 29);
            this.cbx_Marcas.TabIndex = 33;
            // 
            // cbxColor
            // 
            this.cbxColor.FormattingEnabled = true;
            this.cbxColor.ItemHeight = 23;
            this.cbxColor.Location = new System.Drawing.Point(14, 227);
            this.cbxColor.Name = "cbxColor";
            this.cbxColor.Size = new System.Drawing.Size(193, 29);
            this.cbxColor.TabIndex = 34;
            // 
            // jl
            // 
            this.jl.AutoSize = true;
            this.jl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.jl.Location = new System.Drawing.Point(14, 115);
            this.jl.Name = "jl";
            this.jl.Size = new System.Drawing.Size(66, 25);
            this.jl.TabIndex = 38;
            this.jl.Text = "Marcas";
            // 
            // lbl_ttt
            // 
            this.lbl_ttt.AutoSize = true;
            this.lbl_ttt.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_ttt.Location = new System.Drawing.Point(14, 287);
            this.lbl_ttt.Name = "lbl_ttt";
            this.lbl_ttt.Size = new System.Drawing.Size(70, 25);
            this.lbl_ttt.TabIndex = 39;
            this.lbl_ttt.Text = "Modelo";
            // 
            // lbl_lv
            // 
            this.lbl_lv.AutoSize = true;
            this.lbl_lv.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_lv.Location = new System.Drawing.Point(14, 199);
            this.lbl_lv.Name = "lbl_lv";
            this.lbl_lv.Size = new System.Drawing.Size(53, 25);
            this.lbl_lv.TabIndex = 40;
            this.lbl_lv.Text = "Color";
            // 
            // nudSoli
            // 
            this.nudSoli.Location = new System.Drawing.Point(14, 421);
            this.nudSoli.Name = "nudSoli";
            this.nudSoli.Size = new System.Drawing.Size(193, 20);
            this.nudSoli.TabIndex = 41;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.lbl);
            this.metroPanel2.Controls.Add(this.metroLabel4);
            this.metroPanel2.Controls.Add(this.lbl_ttt);
            this.metroPanel2.Controls.Add(this.lbl_lv);
            this.metroPanel2.Controls.Add(this.nudSoli);
            this.metroPanel2.Controls.Add(this.jl);
            this.metroPanel2.Controls.Add(this.Dtp_Fecha);
            this.metroPanel2.Controls.Add(this.cbxColor);
            this.metroPanel2.Controls.Add(this.cbx_Marcas);
            this.metroPanel2.Controls.Add(this.cbx_Tonner);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(634, 72);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(321, 456);
            this.metroPanel2.TabIndex = 42;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(14, 13);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(141, 25);
            this.metroLabel4.TabIndex = 42;
            this.metroLabel4.Text = "Fecha de Ingreso";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl.Location = new System.Drawing.Point(14, 381);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(119, 25);
            this.lbl.TabIndex = 43;
            this.lbl.Text = "Ingresar Toner";
            // 
            // SolicitudTonner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 534);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroPanel3);
            this.Name = "SolicitudTonner";
            this.Text = "SolicitudTonner";
            this.Load += new System.EventHandler(this.SolicitudTonner_Load);
            this.metroPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gtb_datos)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudSoli)).EndInit();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel3;
        private ns1.BunifuCustomDataGrid gtb_datos;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private ns1.BunifuThinButton2 btn_Cancelar;
        private ns1.BunifuThinButton2 btn_Eliminar;
        private ns1.BunifuThinButton2 btn_Guardar;
        private MetroFramework.Controls.MetroComboBox cbx_Tonner;
        private ns1.BunifuDatepicker Dtp_Fecha;
        private MetroFramework.Controls.MetroComboBox cbx_Marcas;
        private MetroFramework.Controls.MetroComboBox cbxColor;
        private MetroFramework.Controls.MetroLabel jl;
        private MetroFramework.Controls.MetroLabel lbl_ttt;
        private MetroFramework.Controls.MetroLabel lbl_lv;
        private System.Windows.Forms.NumericUpDown nudSoli;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel lbl;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}