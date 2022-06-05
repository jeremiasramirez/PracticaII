namespace PracticaII
{
    partial class FrmSimuladorPrestamo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSimuladorPrestamo));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CmdCalcular = new System.Windows.Forms.Button();
            this.NudNoCuotas = new System.Windows.Forms.NumericUpDown();
            this.TxtTasaPrestamo = new System.Windows.Forms.TextBox();
            this.TxtMontoPrestamo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVResultados = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudNoCuotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.DGVResultados);
            this.panel2.Location = new System.Drawing.Point(12, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(748, 410);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.CmdCalcular);
            this.panel1.Controls.Add(this.NudNoCuotas);
            this.panel1.Controls.Add(this.TxtTasaPrestamo);
            this.panel1.Controls.Add(this.TxtMontoPrestamo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 113);
            this.panel1.TabIndex = 2;
            // 
            // CmdCalcular
            // 
            this.CmdCalcular.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CmdCalcular.BackgroundImage")));
            this.CmdCalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CmdCalcular.Location = new System.Drawing.Point(354, 23);
            this.CmdCalcular.Name = "CmdCalcular";
            this.CmdCalcular.Size = new System.Drawing.Size(75, 63);
            this.CmdCalcular.TabIndex = 6;
            this.CmdCalcular.UseVisualStyleBackColor = true;
            this.CmdCalcular.Click += new System.EventHandler(this.CmdCalcular_Click);
            // 
            // NudNoCuotas
            // 
            this.NudNoCuotas.Location = new System.Drawing.Point(163, 75);
            this.NudNoCuotas.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.NudNoCuotas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudNoCuotas.Name = "NudNoCuotas";
            this.NudNoCuotas.Size = new System.Drawing.Size(120, 20);
            this.NudNoCuotas.TabIndex = 5;
            this.NudNoCuotas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TxtTasaPrestamo
            // 
            this.TxtTasaPrestamo.Location = new System.Drawing.Point(163, 45);
            this.TxtTasaPrestamo.Name = "TxtTasaPrestamo";
            this.TxtTasaPrestamo.Size = new System.Drawing.Size(116, 20);
            this.TxtTasaPrestamo.TabIndex = 4;
            // 
            // TxtMontoPrestamo
            // 
            this.TxtMontoPrestamo.Location = new System.Drawing.Point(163, 15);
            this.TxtMontoPrestamo.Name = "TxtMontoPrestamo";
            this.TxtMontoPrestamo.Size = new System.Drawing.Size(116, 20);
            this.TxtMontoPrestamo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "No. Cuotas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tasa Prestamo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monto Prestamo";
            // 
            // DGVResultados
            // 
            this.DGVResultados.AllowUserToAddRows = false;
            this.DGVResultados.AllowUserToDeleteRows = false;
            this.DGVResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVResultados.Location = new System.Drawing.Point(3, 14);
            this.DGVResultados.Name = "DGVResultados";
            this.DGVResultados.ReadOnly = true;
            this.DGVResultados.Size = new System.Drawing.Size(740, 391);
            this.DGVResultados.TabIndex = 0;
            // 
            // FrmSimuladorPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 565);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmSimuladorPrestamo";
            this.Text = "FrmSimuladorPrestamo";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudNoCuotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVResultados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CmdCalcular;
        private System.Windows.Forms.NumericUpDown NudNoCuotas;
        private System.Windows.Forms.TextBox TxtTasaPrestamo;
        private System.Windows.Forms.TextBox TxtMontoPrestamo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVResultados;
    }
}