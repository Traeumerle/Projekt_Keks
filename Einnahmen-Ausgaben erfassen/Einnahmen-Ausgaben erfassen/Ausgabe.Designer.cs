namespace Einnahmen_Ausgaben_erfassen
{
    partial class Ausgabe
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
            this.closeBTN = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Einnamen_Ausgaben = new System.Windows.Forms.TabPage();
            this.ausgabenRTB = new System.Windows.Forms.RichTextBox();
            this.summe_saldoLBL = new System.Windows.Forms.Label();
            this.saldo_ausgabenLBL = new System.Windows.Forms.Label();
            this.saldo_einnahmenLBL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.einnahmenRTB = new System.Windows.Forms.RichTextBox();
            this.Salden_aller_Monate = new System.Windows.Forms.TabPage();
            this.salden = new System.Windows.Forms.Label();
            this.saldenRTB = new System.Windows.Forms.RichTextBox();
            this.Jahresvergleich = new System.Windows.Forms.TabPage();
            this.salden_jahr2RTB = new System.Windows.Forms.RichTextBox();
            this.summe_saldojahr2LBL = new System.Windows.Forms.Label();
            this.summe_saldojahrLBL = new System.Windows.Forms.Label();
            this.salden_jahr2LBL = new System.Windows.Forms.Label();
            this.salden_jahr1LBL = new System.Windows.Forms.Label();
            this.salden_jahr1RTB = new System.Windows.Forms.RichTextBox();
            this.jahr1TB = new System.Windows.Forms.ComboBox();
            this.jahr2TB = new System.Windows.Forms.ComboBox();
            this.monatsTB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Einnamen_Ausgaben.SuspendLayout();
            this.Salden_aller_Monate.SuspendLayout();
            this.Jahresvergleich.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeBTN
            // 
            this.closeBTN.Location = new System.Drawing.Point(470, 394);
            this.closeBTN.Name = "closeBTN";
            this.closeBTN.Size = new System.Drawing.Size(75, 23);
            this.closeBTN.TabIndex = 19;
            this.closeBTN.Text = "Beenden";
            this.closeBTN.UseVisualStyleBackColor = true;
            this.closeBTN.Click += new System.EventHandler(this.closeBTN_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Einnamen_Ausgaben);
            this.tabControl1.Controls.Add(this.Salden_aller_Monate);
            this.tabControl1.Controls.Add(this.Jahresvergleich);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(533, 334);
            this.tabControl1.TabIndex = 20;
            // 
            // Einnamen_Ausgaben
            // 
            this.Einnamen_Ausgaben.AccessibleRole = System.Windows.Forms.AccessibleRole.Table;
            this.Einnamen_Ausgaben.Controls.Add(this.ausgabenRTB);
            this.Einnamen_Ausgaben.Controls.Add(this.summe_saldoLBL);
            this.Einnamen_Ausgaben.Controls.Add(this.saldo_ausgabenLBL);
            this.Einnamen_Ausgaben.Controls.Add(this.saldo_einnahmenLBL);
            this.Einnamen_Ausgaben.Controls.Add(this.label2);
            this.Einnamen_Ausgaben.Controls.Add(this.label1);
            this.Einnamen_Ausgaben.Controls.Add(this.einnahmenRTB);
            this.Einnamen_Ausgaben.Location = new System.Drawing.Point(4, 22);
            this.Einnamen_Ausgaben.Name = "Einnamen_Ausgaben";
            this.Einnamen_Ausgaben.Size = new System.Drawing.Size(525, 308);
            this.Einnamen_Ausgaben.TabIndex = 0;
            this.Einnamen_Ausgaben.Text = "Einnahmen/Ausgaben";
            this.Einnamen_Ausgaben.UseVisualStyleBackColor = true;
            // 
            // ausgabenRTB
            // 
            this.ausgabenRTB.Location = new System.Drawing.Point(297, 25);
            this.ausgabenRTB.Name = "ausgabenRTB";
            this.ausgabenRTB.ReadOnly = true;
            this.ausgabenRTB.Size = new System.Drawing.Size(210, 220);
            this.ausgabenRTB.TabIndex = 7;
            this.ausgabenRTB.Text = "";
            // 
            // summe_saldoLBL
            // 
            this.summe_saldoLBL.AutoSize = true;
            this.summe_saldoLBL.Location = new System.Drawing.Point(15, 284);
            this.summe_saldoLBL.Name = "summe_saldoLBL";
            this.summe_saldoLBL.Size = new System.Drawing.Size(93, 13);
            this.summe_saldoLBL.TabIndex = 6;
            this.summe_saldoLBL.Text = "Saldo Placeholder";
            // 
            // saldo_ausgabenLBL
            // 
            this.saldo_ausgabenLBL.AutoSize = true;
            this.saldo_ausgabenLBL.Location = new System.Drawing.Point(294, 248);
            this.saldo_ausgabenLBL.Name = "saldo_ausgabenLBL";
            this.saldo_ausgabenLBL.Size = new System.Drawing.Size(63, 13);
            this.saldo_ausgabenLBL.TabIndex = 5;
            this.saldo_ausgabenLBL.Text = "Placeholder";
            // 
            // saldo_einnahmenLBL
            // 
            this.saldo_einnahmenLBL.AutoSize = true;
            this.saldo_einnahmenLBL.Location = new System.Drawing.Point(15, 248);
            this.saldo_einnahmenLBL.Name = "saldo_einnahmenLBL";
            this.saldo_einnahmenLBL.Size = new System.Drawing.Size(63, 13);
            this.saldo_einnahmenLBL.TabIndex = 4;
            this.saldo_einnahmenLBL.Text = "Placeholder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ausgaben";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Einnahmen";
            // 
            // einnahmenRTB
            // 
            this.einnahmenRTB.Location = new System.Drawing.Point(18, 25);
            this.einnahmenRTB.Name = "einnahmenRTB";
            this.einnahmenRTB.ReadOnly = true;
            this.einnahmenRTB.Size = new System.Drawing.Size(210, 220);
            this.einnahmenRTB.TabIndex = 0;
            this.einnahmenRTB.Text = "";
            // 
            // Salden_aller_Monate
            // 
            this.Salden_aller_Monate.Controls.Add(this.salden);
            this.Salden_aller_Monate.Controls.Add(this.saldenRTB);
            this.Salden_aller_Monate.Location = new System.Drawing.Point(4, 22);
            this.Salden_aller_Monate.Name = "Salden_aller_Monate";
            this.Salden_aller_Monate.Size = new System.Drawing.Size(525, 308);
            this.Salden_aller_Monate.TabIndex = 1;
            this.Salden_aller_Monate.Text = "Salden";
            this.Salden_aller_Monate.UseVisualStyleBackColor = true;
            // 
            // salden
            // 
            this.salden.AutoSize = true;
            this.salden.Location = new System.Drawing.Point(25, 9);
            this.salden.Name = "salden";
            this.salden.Size = new System.Drawing.Size(101, 13);
            this.salden.TabIndex = 3;
            this.salden.Text = "Salden aller Monate";
            // 
            // saldenRTB
            // 
            this.saldenRTB.Location = new System.Drawing.Point(28, 25);
            this.saldenRTB.Name = "saldenRTB";
            this.saldenRTB.Size = new System.Drawing.Size(163, 220);
            this.saldenRTB.TabIndex = 1;
            this.saldenRTB.Text = "";
            // 
            // Jahresvergleich
            // 
            this.Jahresvergleich.Controls.Add(this.salden_jahr2RTB);
            this.Jahresvergleich.Controls.Add(this.summe_saldojahr2LBL);
            this.Jahresvergleich.Controls.Add(this.summe_saldojahrLBL);
            this.Jahresvergleich.Controls.Add(this.salden_jahr2LBL);
            this.Jahresvergleich.Controls.Add(this.salden_jahr1LBL);
            this.Jahresvergleich.Controls.Add(this.salden_jahr1RTB);
            this.Jahresvergleich.Location = new System.Drawing.Point(4, 22);
            this.Jahresvergleich.Name = "Jahresvergleich";
            this.Jahresvergleich.Size = new System.Drawing.Size(525, 308);
            this.Jahresvergleich.TabIndex = 2;
            this.Jahresvergleich.Text = "Jahresvergleich";
            this.Jahresvergleich.UseVisualStyleBackColor = true;
            // 
            // salden_jahr2RTB
            // 
            this.salden_jahr2RTB.Location = new System.Drawing.Point(334, 27);
            this.salden_jahr2RTB.Name = "salden_jahr2RTB";
            this.salden_jahr2RTB.Size = new System.Drawing.Size(163, 218);
            this.salden_jahr2RTB.TabIndex = 13;
            this.salden_jahr2RTB.Text = "";
            // 
            // summe_saldojahr2LBL
            // 
            this.summe_saldojahr2LBL.AutoSize = true;
            this.summe_saldojahr2LBL.Location = new System.Drawing.Point(331, 247);
            this.summe_saldojahr2LBL.Name = "summe_saldojahr2LBL";
            this.summe_saldojahr2LBL.Size = new System.Drawing.Size(63, 13);
            this.summe_saldojahr2LBL.TabIndex = 12;
            this.summe_saldojahr2LBL.Text = "Placeholder";
            // 
            // summe_saldojahrLBL
            // 
            this.summe_saldojahrLBL.AutoSize = true;
            this.summe_saldojahrLBL.Location = new System.Drawing.Point(25, 248);
            this.summe_saldojahrLBL.Name = "summe_saldojahrLBL";
            this.summe_saldojahrLBL.Size = new System.Drawing.Size(63, 13);
            this.summe_saldojahrLBL.TabIndex = 11;
            this.summe_saldojahrLBL.Text = "Placeholder";
            // 
            // salden_jahr2LBL
            // 
            this.salden_jahr2LBL.AutoSize = true;
            this.salden_jahr2LBL.Location = new System.Drawing.Point(331, 9);
            this.salden_jahr2LBL.Name = "salden_jahr2LBL";
            this.salden_jahr2LBL.Size = new System.Drawing.Size(104, 13);
            this.salden_jahr2LBL.TabIndex = 10;
            this.salden_jahr2LBL.Text = "Salden des Jahres X";
            // 
            // salden_jahr1LBL
            // 
            this.salden_jahr1LBL.AutoSize = true;
            this.salden_jahr1LBL.Location = new System.Drawing.Point(25, 9);
            this.salden_jahr1LBL.Name = "salden_jahr1LBL";
            this.salden_jahr1LBL.Size = new System.Drawing.Size(104, 13);
            this.salden_jahr1LBL.TabIndex = 9;
            this.salden_jahr1LBL.Text = "Salden des Jahres X";
            // 
            // salden_jahr1RTB
            // 
            this.salden_jahr1RTB.Location = new System.Drawing.Point(28, 25);
            this.salden_jahr1RTB.Name = "salden_jahr1RTB";
            this.salden_jahr1RTB.Size = new System.Drawing.Size(163, 220);
            this.salden_jahr1RTB.TabIndex = 8;
            this.salden_jahr1RTB.Text = "";
            // 
            // jahr1TB
            // 
            this.jahr1TB.FormattingEnabled = true;
            this.jahr1TB.Location = new System.Drawing.Point(73, 352);
            this.jahr1TB.Name = "jahr1TB";
            this.jahr1TB.Size = new System.Drawing.Size(121, 21);
            this.jahr1TB.TabIndex = 21;
            // 
            // jahr2TB
            // 
            this.jahr2TB.FormattingEnabled = true;
            this.jahr2TB.Location = new System.Drawing.Point(320, 351);
            this.jahr2TB.Name = "jahr2TB";
            this.jahr2TB.Size = new System.Drawing.Size(121, 21);
            this.jahr2TB.TabIndex = 22;
            // 
            // monatsTB
            // 
            this.monatsTB.FormattingEnabled = true;
            this.monatsTB.Location = new System.Drawing.Point(73, 396);
            this.monatsTB.Name = "monatsTB";
            this.monatsTB.Size = new System.Drawing.Size(121, 21);
            this.monatsTB.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Jahr";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(268, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Jahr";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 399);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Monat";
            // 
            // Ausgabe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 429);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.monatsTB);
            this.Controls.Add(this.jahr2TB);
            this.Controls.Add(this.jahr1TB);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.closeBTN);
            this.Name = "Ausgabe";
            this.Text = "Ausgabe";
            this.Load += new System.EventHandler(this.Ausgabe_Load);
            this.tabControl1.ResumeLayout(false);
            this.Einnamen_Ausgaben.ResumeLayout(false);
            this.Einnamen_Ausgaben.PerformLayout();
            this.Salden_aller_Monate.ResumeLayout(false);
            this.Salden_aller_Monate.PerformLayout();
            this.Jahresvergleich.ResumeLayout(false);
            this.Jahresvergleich.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeBTN;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Einnamen_Ausgaben;
        private System.Windows.Forms.TabPage Salden_aller_Monate;
        private System.Windows.Forms.TabPage Jahresvergleich;
        private System.Windows.Forms.RichTextBox einnahmenRTB;
        private System.Windows.Forms.RichTextBox ausgabenRTB;
        private System.Windows.Forms.Label summe_saldoLBL;
        private System.Windows.Forms.Label saldo_ausgabenLBL;
        private System.Windows.Forms.Label saldo_einnahmenLBL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox jahr1TB;
        private System.Windows.Forms.ComboBox jahr2TB;
        private System.Windows.Forms.ComboBox monatsTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label salden;
        private System.Windows.Forms.RichTextBox saldenRTB;
        private System.Windows.Forms.RichTextBox salden_jahr2RTB;
        private System.Windows.Forms.Label summe_saldojahr2LBL;
        private System.Windows.Forms.Label summe_saldojahrLBL;
        private System.Windows.Forms.Label salden_jahr2LBL;
        private System.Windows.Forms.Label salden_jahr1LBL;
        private System.Windows.Forms.RichTextBox salden_jahr1RTB;
    }
}