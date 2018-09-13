namespace Einnahmen_Ausgaben_erfassen
{
    partial class Eingabe
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.saveBTN = new System.Windows.Forms.Button();
            this.einnahmenRBTN = new System.Windows.Forms.RadioButton();
            this.ausgabenRBTN = new System.Windows.Forms.RadioButton();
            this.grundTB = new System.Windows.Forms.TextBox();
            this.datumjahrTB = new System.Windows.Forms.TextBox();
            this.wertTB = new System.Windows.Forms.TextBox();
            this.closeBTN = new System.Windows.Forms.Button();
            this.datummonatTB = new System.Windows.Forms.TextBox();
            this.datumtagTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grund";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Wert";
            // 
            // saveBTN
            // 
            this.saveBTN.Location = new System.Drawing.Point(29, 171);
            this.saveBTN.Name = "saveBTN";
            this.saveBTN.Size = new System.Drawing.Size(75, 23);
            this.saveBTN.TabIndex = 13;
            this.saveBTN.Text = "Speichern";
            this.saveBTN.UseVisualStyleBackColor = true;
            this.saveBTN.Click += new System.EventHandler(this.saveBTN_Click_1);
            // 
            // einnahmenRBTN
            // 
            this.einnahmenRBTN.AutoSize = true;
            this.einnahmenRBTN.Location = new System.Drawing.Point(29, 123);
            this.einnahmenRBTN.Name = "einnahmenRBTN";
            this.einnahmenRBTN.Size = new System.Drawing.Size(78, 17);
            this.einnahmenRBTN.TabIndex = 11;
            this.einnahmenRBTN.TabStop = true;
            this.einnahmenRBTN.Text = "Einnahmen";
            this.einnahmenRBTN.UseVisualStyleBackColor = true;
            // 
            // ausgabenRBTN
            // 
            this.ausgabenRBTN.AutoSize = true;
            this.ausgabenRBTN.Location = new System.Drawing.Point(29, 144);
            this.ausgabenRBTN.Name = "ausgabenRBTN";
            this.ausgabenRBTN.Size = new System.Drawing.Size(73, 17);
            this.ausgabenRBTN.TabIndex = 12;
            this.ausgabenRBTN.TabStop = true;
            this.ausgabenRBTN.Text = "Ausgaben";
            this.ausgabenRBTN.UseVisualStyleBackColor = true;
            // 
            // grundTB
            // 
            this.grundTB.Location = new System.Drawing.Point(68, 40);
            this.grundTB.Name = "grundTB";
            this.grundTB.Size = new System.Drawing.Size(100, 20);
            this.grundTB.TabIndex = 6;
            // 
            // datumjahrTB
            // 
            this.datumjahrTB.Location = new System.Drawing.Point(68, 66);
            this.datumjahrTB.Name = "datumjahrTB";
            this.datumjahrTB.Size = new System.Drawing.Size(34, 20);
            this.datumjahrTB.TabIndex = 7;
            this.datumjahrTB.Text = "JJJJ";
            // 
            // wertTB
            // 
            this.wertTB.Location = new System.Drawing.Point(68, 92);
            this.wertTB.Name = "wertTB";
            this.wertTB.Size = new System.Drawing.Size(100, 20);
            this.wertTB.TabIndex = 10;
            // 
            // closeBTN
            // 
            this.closeBTN.Location = new System.Drawing.Point(171, 171);
            this.closeBTN.Name = "closeBTN";
            this.closeBTN.Size = new System.Drawing.Size(75, 23);
            this.closeBTN.TabIndex = 14;
            this.closeBTN.Text = "Beenden";
            this.closeBTN.UseVisualStyleBackColor = true;
            this.closeBTN.Click += new System.EventHandler(this.closeBTN_Click);
            // 
            // datummonatTB
            // 
            this.datummonatTB.Location = new System.Drawing.Point(108, 66);
            this.datummonatTB.Name = "datummonatTB";
            this.datummonatTB.Size = new System.Drawing.Size(25, 20);
            this.datummonatTB.TabIndex = 8;
            this.datummonatTB.Text = "MM";
            // 
            // datumtagTB
            // 
            this.datumtagTB.Location = new System.Drawing.Point(139, 66);
            this.datumtagTB.Name = "datumtagTB";
            this.datumtagTB.Size = new System.Drawing.Size(29, 20);
            this.datumtagTB.TabIndex = 9;
            this.datumtagTB.Text = "TT";
            // 
            // Eingabe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.datumtagTB);
            this.Controls.Add(this.datummonatTB);
            this.Controls.Add(this.closeBTN);
            this.Controls.Add(this.wertTB);
            this.Controls.Add(this.datumjahrTB);
            this.Controls.Add(this.grundTB);
            this.Controls.Add(this.ausgabenRBTN);
            this.Controls.Add(this.einnahmenRBTN);
            this.Controls.Add(this.saveBTN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Eingabe";
            this.Text = "Eingabe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveBTN;
        private System.Windows.Forms.RadioButton einnahmenRBTN;
        private System.Windows.Forms.RadioButton ausgabenRBTN;
        private System.Windows.Forms.TextBox grundTB;
        private System.Windows.Forms.TextBox datumjahrTB;
        private System.Windows.Forms.TextBox wertTB;
        private System.Windows.Forms.Button closeBTN;
        private System.Windows.Forms.TextBox datummonatTB;
        private System.Windows.Forms.TextBox datumtagTB;
    }
}