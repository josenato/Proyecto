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
            this.tbx_Marcas = new MetroFramework.Controls.MetroTextBox();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.btn_Guardar = new ns1.BunifuThinButton2();
            this.btn_Eliminar = new ns1.BunifuThinButton2();
            this.btn_Cancelar = new ns1.BunifuThinButton2();
            this.gtb_datos = new ns1.BunifuCustomDataGrid();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gtb_datos)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbx_Marcas
            // 
            this.tbx_Marcas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbx_Marcas.Location = new System.Drawing.Point(106, 63);
            this.tbx_Marcas.Name = "tbx_Marcas";
            this.tbx_Marcas.Size = new System.Drawing.Size(171, 23);
            this.tbx_Marcas.TabIndex = 2;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(18, 63);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(75, 26);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "Marcas";
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.ActiveBorderThickness = 1;
            this.btn_Guardar.ActiveCornerRadius = 20;
            this.btn_Guardar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_Guardar.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Guardar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Guardar.BackColor = System.Drawing.Color.Purple;
            this.btn_Guardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Guardar.BackgroundImage")));
            this.btn_Guardar.ButtonText = "Guardar";
            this.btn_Guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Guardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Guardar.IdleBorderThickness = 1;
            this.btn_Guardar.IdleCornerRadius = 20;
            this.btn_Guardar.IdleFillColor = System.Drawing.Color.White;
            this.btn_Guardar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_Guardar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Guardar.Location = new System.Drawing.Point(5, 5);
            this.btn_Guardar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(85, 41);
            this.btn_Guardar.TabIndex = 4;
            this.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.ActiveBorderThickness = 1;
            this.btn_Eliminar.ActiveCornerRadius = 20;
            this.btn_Eliminar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_Eliminar.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Eliminar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Eliminar.BackColor = System.Drawing.Color.Purple;
            this.btn_Eliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Eliminar.BackgroundImage")));
            this.btn_Eliminar.ButtonText = "Eliminar";
            this.btn_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Eliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Eliminar.IdleBorderThickness = 1;
            this.btn_Eliminar.IdleCornerRadius = 20;
            this.btn_Eliminar.IdleFillColor = System.Drawing.Color.White;
            this.btn_Eliminar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_Eliminar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Eliminar.Location = new System.Drawing.Point(100, 5);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(85, 41);
            this.btn_Eliminar.TabIndex = 5;
            this.btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.ActiveBorderThickness = 1;
            this.btn_Cancelar.ActiveCornerRadius = 20;
            this.btn_Cancelar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_Cancelar.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Cancelar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Cancelar.BackColor = System.Drawing.Color.Purple;
            this.btn_Cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cancelar.BackgroundImage")));
            this.btn_Cancelar.ButtonText = "Cancelar";
            this.btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Cancelar.IdleBorderThickness = 1;
            this.btn_Cancelar.IdleCornerRadius = 20;
            this.btn_Cancelar.IdleFillColor = System.Drawing.Color.White;
            this.btn_Cancelar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_Cancelar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Cancelar.Location = new System.Drawing.Point(195, 5);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(85, 41);
            this.btn_Cancelar.TabIndex = 6;
            this.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // gtb_datos
            // 
            this.gtb_datos.AllowUserToAddRows = false;
            this.gtb_datos.AllowUserToDeleteRows = false;
            this.gtb_datos.AllowUserToResizeRows = false;
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
            this.gtb_datos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gtb_datos.DoubleBuffered = true;
            this.gtb_datos.EnableHeadersVisualStyles = false;
            this.gtb_datos.GridColor = System.Drawing.Color.Silver;
            this.gtb_datos.HeaderBgColor = System.Drawing.Color.DarkCyan;
            this.gtb_datos.HeaderForeColor = System.Drawing.Color.DarkSlateGray;
            this.gtb_datos.Location = new System.Drawing.Point(23, 92);
            this.gtb_datos.MultiSelect = false;
            this.gtb_datos.Name = "gtb_datos";
            this.gtb_datos.ReadOnly = true;
            this.gtb_datos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gtb_datos.RowHeadersWidth = 51;
            this.gtb_datos.Size = new System.Drawing.Size(762, 385);
            this.gtb_datos.TabIndex = 10;
            this.gtb_datos.DoubleClick += new System.EventHandler(this.Gtb_datos_DoubleClick);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Purple;
            this.metroPanel1.Controls.Add(this.btn_Cancelar);
            this.metroPanel1.Controls.Add(this.btn_Guardar);
            this.metroPanel1.Controls.Add(this.btn_Eliminar);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(296, 34);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(288, 52);
            this.metroPanel1.TabIndex = 13;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnAtras
            // 
            this.btnAtras.Image = global::SistemaInventario.Properties.Resources.atras21;
            this.btnAtras.Location = new System.Drawing.Point(23, 21);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(61, 39);
            this.btnAtras.TabIndex = 29;
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            // 
            // Marcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 500);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.gtb_datos);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.tbx_Marcas);
            this.MaximizeBox = false;
            this.Name = "Marcas";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Marcas";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Right;
            this.Load += new System.EventHandler(this.Marcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gtb_datos)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox tbx_Marcas;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private ns1.BunifuThinButton2 btn_Guardar;
        private ns1.BunifuThinButton2 btn_Eliminar;
        private ns1.BunifuThinButton2 btn_Cancelar;
        private ns1.BunifuCustomDataGrid gtb_datos;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Button btnAtras;
    }
}