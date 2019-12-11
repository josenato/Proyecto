namespace SistemaInventario
{
    partial class ImpresoraReporte
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRporte = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RptImpresora = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnRporte);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnRporte
            // 
            this.btnRporte.Location = new System.Drawing.Point(259, 22);
            this.btnRporte.Name = "btnRporte";
            this.btnRporte.Size = new System.Drawing.Size(119, 48);
            this.btnRporte.TabIndex = 0;
            this.btnRporte.Text = "Informe";
            this.btnRporte.UseVisualStyleBackColor = true;
            this.btnRporte.Click += new System.EventHandler(this.btnRporte_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mostrar Resguardo";
            // 
            // RptImpresora
            // 
            this.RptImpresora.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RptImpresora.Location = new System.Drawing.Point(0, 100);
            this.RptImpresora.Name = "RptImpresora";
            this.RptImpresora.ServerReport.BearerToken = null;
            this.RptImpresora.Size = new System.Drawing.Size(764, 470);
            this.RptImpresora.TabIndex = 1;
            // 
            // ImpresoraReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 570);
            this.Controls.Add(this.RptImpresora);
            this.Controls.Add(this.panel1);
            this.Name = "ImpresoraReporte";
            this.Text = "ImpresoraReporte";
            this.Load += new System.EventHandler(this.ImpresoraReporte_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRporte;
        private Microsoft.Reporting.WinForms.ReportViewer RptImpresora;
    }
}