namespace ABC_Analyse_Tool
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.speichernBTN = new System.Windows.Forms.Button();
            this.ausgabedGV = new System.Windows.Forms.DataGridView();
            this.datentabellenCB = new System.Windows.Forms.ComboBox();
            this.WerttrB1 = new System.Windows.Forms.TrackBar();
            this.Werttrb2 = new System.Windows.Forms.TrackBar();
            this.filepathTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.güterALBL = new System.Windows.Forms.Label();
            this.güterBLBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ausgabedGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WerttrB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Werttrb2)).BeginInit();
            this.SuspendLayout();
            // 
            // speichernBTN
            // 
            this.speichernBTN.Location = new System.Drawing.Point(434, 427);
            this.speichernBTN.Name = "speichernBTN";
            this.speichernBTN.Size = new System.Drawing.Size(174, 23);
            this.speichernBTN.TabIndex = 1;
            this.speichernBTN.Text = "speichern als PDF";
            this.speichernBTN.UseVisualStyleBackColor = true;
            this.speichernBTN.Click += new System.EventHandler(this.speichernBTN_Click);
            // 
            // ausgabedGV
            // 
            this.ausgabedGV.AllowUserToAddRows = false;
            this.ausgabedGV.AllowUserToOrderColumns = true;
            this.ausgabedGV.AllowUserToResizeColumns = false;
            this.ausgabedGV.AllowUserToResizeRows = false;
            this.ausgabedGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ausgabedGV.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.ausgabedGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ausgabedGV.Location = new System.Drawing.Point(12, 12);
            this.ausgabedGV.Name = "ausgabedGV";
            this.ausgabedGV.Size = new System.Drawing.Size(786, 364);
            this.ausgabedGV.TabIndex = 4;
            this.ausgabedGV.Sorted += new System.EventHandler(this.ausgabedGV_Sorted);
            // 
            // datentabellenCB
            // 
            this.datentabellenCB.FormattingEnabled = true;
            this.datentabellenCB.Location = new System.Drawing.Point(281, 427);
            this.datentabellenCB.Name = "datentabellenCB";
            this.datentabellenCB.Size = new System.Drawing.Size(132, 21);
            this.datentabellenCB.TabIndex = 5;
            // 
            // WerttrB1
            // 
            this.WerttrB1.Location = new System.Drawing.Point(12, 416);
            this.WerttrB1.Maximum = 100;
            this.WerttrB1.Name = "WerttrB1";
            this.WerttrB1.Size = new System.Drawing.Size(108, 45);
            this.WerttrB1.TabIndex = 6;
            this.WerttrB1.Value = 1;
            this.WerttrB1.Scroll += new System.EventHandler(this.WerttrB1_Scroll);
            // 
            // Werttrb2
            // 
            this.Werttrb2.Location = new System.Drawing.Point(126, 416);
            this.Werttrb2.Maximum = 100;
            this.Werttrb2.Name = "Werttrb2";
            this.Werttrb2.Size = new System.Drawing.Size(104, 45);
            this.Werttrb2.TabIndex = 7;
            this.Werttrb2.Value = 1;
            this.Werttrb2.Scroll += new System.EventHandler(this.Werttrb2_Scroll);
            // 
            // filepathTB
            // 
            this.filepathTB.Location = new System.Drawing.Point(645, 430);
            this.filepathTB.Name = "filepathTB";
            this.filepathTB.Size = new System.Drawing.Size(153, 20);
            this.filepathTB.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(645, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Dateinamen angeben:";
            // 
            // güterALBL
            // 
            this.güterALBL.AutoSize = true;
            this.güterALBL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.güterALBL.Location = new System.Drawing.Point(12, 400);
            this.güterALBL.Name = "güterALBL";
            this.güterALBL.Size = new System.Drawing.Size(76, 13);
            this.güterALBL.TabIndex = 10;
            this.güterALBL.Text = "Güterklasse C:";
            // 
            // güterBLBL
            // 
            this.güterBLBL.AutoSize = true;
            this.güterBLBL.BackColor = System.Drawing.SystemColors.ControlText;
            this.güterBLBL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.güterBLBL.Location = new System.Drawing.Point(130, 400);
            this.güterBLBL.Name = "güterBLBL";
            this.güterBLBL.Size = new System.Drawing.Size(76, 13);
            this.güterBLBL.TabIndex = 11;
            this.güterBLBL.Text = "Güterklasse A:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(810, 462);
            this.Controls.Add(this.güterBLBL);
            this.Controls.Add(this.güterALBL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filepathTB);
            this.Controls.Add(this.Werttrb2);
            this.Controls.Add(this.WerttrB1);
            this.Controls.Add(this.datentabellenCB);
            this.Controls.Add(this.ausgabedGV);
            this.Controls.Add(this.speichernBTN);
            this.Name = "Form1";
            this.Text = "ABC-Analyse-Tool";
            ((System.ComponentModel.ISupportInitialize)(this.ausgabedGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WerttrB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Werttrb2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button speichernBTN;
        private System.Windows.Forms.DataGridView ausgabedGV;
        private System.Windows.Forms.ComboBox datentabellenCB;
        private System.Windows.Forms.TrackBar WerttrB1;
        private System.Windows.Forms.TrackBar Werttrb2;
        private System.Windows.Forms.TextBox filepathTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label güterALBL;
        private System.Windows.Forms.Label güterBLBL;
    }
}

