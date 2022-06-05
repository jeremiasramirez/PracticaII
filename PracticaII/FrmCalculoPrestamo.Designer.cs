namespace PracticaII
{
    partial class FrmCalculoPrestamo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalculoPrestamo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtMontoPrestamo = new System.Windows.Forms.TextBox();
            this.TxtTasaPrestamo = new System.Windows.Forms.TextBox();
            this.NudNoCuotas = new System.Windows.Forms.NumericUpDown();
            this.CmdCalcular = new System.Windows.Forms.Button();
            this.LstNoCuota = new System.Windows.Forms.ListBox();
            this.LstCapitalCuota = new System.Windows.Forms.ListBox();
            this.LstInteresCuota = new System.Windows.Forms.ListBox();
            this.LstTotalCuota = new System.Windows.Forms.ListBox();
            this.LstCapitalPagado = new System.Windows.Forms.ListBox();
            this.LstCapitalRestante = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudNoCuotas)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(23, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 113);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.LstCapitalRestante);
            this.panel2.Controls.Add(this.LstCapitalPagado);
            this.panel2.Controls.Add(this.LstTotalCuota);
            this.panel2.Controls.Add(this.LstInteresCuota);
            this.panel2.Controls.Add(this.LstCapitalCuota);
            this.panel2.Controls.Add(this.LstNoCuota);
            this.panel2.Location = new System.Drawing.Point(23, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(748, 410);
            this.panel2.TabIndex = 1;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tasa Prestamo";
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
            // TxtMontoPrestamo
            // 
            this.TxtMontoPrestamo.Location = new System.Drawing.Point(163, 15);
            this.TxtMontoPrestamo.Name = "TxtMontoPrestamo";
            this.TxtMontoPrestamo.Size = new System.Drawing.Size(116, 20);
            this.TxtMontoPrestamo.TabIndex = 3;
            // 
            // TxtTasaPrestamo
            // 
            this.TxtTasaPrestamo.Location = new System.Drawing.Point(163, 45);
            this.TxtTasaPrestamo.Name = "TxtTasaPrestamo";
            this.TxtTasaPrestamo.Size = new System.Drawing.Size(116, 20);
            this.TxtTasaPrestamo.TabIndex = 4;
            // 
            // NudNoCuotas
            // 
            this.NudNoCuotas.Location = new System.Drawing.Point(163, 75);
            this.NudNoCuotas.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NudNoCuotas.Name = "NudNoCuotas";
            this.NudNoCuotas.Size = new System.Drawing.Size(120, 20);
            this.NudNoCuotas.TabIndex = 5;
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
            // LstNoCuota
            // 
            this.LstNoCuota.FormattingEnabled = true;
            this.LstNoCuota.Location = new System.Drawing.Point(15, 27);
            this.LstNoCuota.Name = "LstNoCuota";
            this.LstNoCuota.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LstNoCuota.Size = new System.Drawing.Size(104, 355);
            this.LstNoCuota.TabIndex = 0;
            // 
            // LstCapitalCuota
            // 
            this.LstCapitalCuota.FormattingEnabled = true;
            this.LstCapitalCuota.Location = new System.Drawing.Point(125, 27);
            this.LstCapitalCuota.Name = "LstCapitalCuota";
            this.LstCapitalCuota.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LstCapitalCuota.Size = new System.Drawing.Size(115, 355);
            this.LstCapitalCuota.TabIndex = 1;
            // 
            // LstInteresCuota
            // 
            this.LstInteresCuota.FormattingEnabled = true;
            this.LstInteresCuota.Location = new System.Drawing.Point(246, 27);
            this.LstInteresCuota.Name = "LstInteresCuota";
            this.LstInteresCuota.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LstInteresCuota.Size = new System.Drawing.Size(115, 355);
            this.LstInteresCuota.TabIndex = 2;
            // 
            // LstTotalCuota
            // 
            this.LstTotalCuota.FormattingEnabled = true;
            this.LstTotalCuota.Location = new System.Drawing.Point(367, 27);
            this.LstTotalCuota.Name = "LstTotalCuota";
            this.LstTotalCuota.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LstTotalCuota.Size = new System.Drawing.Size(115, 355);
            this.LstTotalCuota.TabIndex = 3;
            // 
            // LstCapitalPagado
            // 
            this.LstCapitalPagado.FormattingEnabled = true;
            this.LstCapitalPagado.Location = new System.Drawing.Point(488, 27);
            this.LstCapitalPagado.Name = "LstCapitalPagado";
            this.LstCapitalPagado.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LstCapitalPagado.Size = new System.Drawing.Size(115, 355);
            this.LstCapitalPagado.TabIndex = 4;
            // 
            // LstCapitalRestante
            // 
            this.LstCapitalRestante.FormattingEnabled = true;
            this.LstCapitalRestante.Location = new System.Drawing.Point(609, 27);
            this.LstCapitalRestante.Name = "LstCapitalRestante";
            this.LstCapitalRestante.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LstCapitalRestante.Size = new System.Drawing.Size(115, 355);
            this.LstCapitalRestante.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "No. Cuota";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Capital Cuota";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(291, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Interes Cuota";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(420, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Total Cuota";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(524, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Capital Pagado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(639, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Capital Restante";
            // 
            // FrmCalculoPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 554);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmCalculoPrestamo";
            this.Text = "Calculadora de Prestamos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudNoCuotas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CmdCalcular;
        private System.Windows.Forms.NumericUpDown NudNoCuotas;
        private System.Windows.Forms.TextBox TxtTasaPrestamo;
        private System.Windows.Forms.TextBox TxtMontoPrestamo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox LstCapitalRestante;
        private System.Windows.Forms.ListBox LstCapitalPagado;
        private System.Windows.Forms.ListBox LstTotalCuota;
        private System.Windows.Forms.ListBox LstInteresCuota;
        private System.Windows.Forms.ListBox LstCapitalCuota;
        private System.Windows.Forms.ListBox LstNoCuota;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

