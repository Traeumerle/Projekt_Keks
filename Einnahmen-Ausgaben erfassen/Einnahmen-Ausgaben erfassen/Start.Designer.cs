namespace Einnahmen_Ausgaben_erfassen
{
    partial class Start
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
            this.eingabeBTN = new System.Windows.Forms.Button();
            this.ausgabeBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // eingabeBTN
            // 
            this.eingabeBTN.Location = new System.Drawing.Point(144, 94);
            this.eingabeBTN.Name = "eingabeBTN";
            this.eingabeBTN.Size = new System.Drawing.Size(193, 23);
            this.eingabeBTN.TabIndex = 0;
            this.eingabeBTN.Text = "Eingabe";
            this.eingabeBTN.UseVisualStyleBackColor = true;
            this.eingabeBTN.Click += new System.EventHandler(this.eingabeBTN_Click);
            // 
            // ausgabeBTN
            // 
            this.ausgabeBTN.Location = new System.Drawing.Point(144, 171);
            this.ausgabeBTN.Name = "ausgabeBTN";
            this.ausgabeBTN.Size = new System.Drawing.Size(193, 23);
            this.ausgabeBTN.TabIndex = 1;
            this.ausgabeBTN.Text = "Ausgabe";
            this.ausgabeBTN.UseVisualStyleBackColor = true;
            this.ausgabeBTN.Click += new System.EventHandler(this.ausgabeBTN_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 345);
            this.Controls.Add(this.ausgabeBTN);
            this.Controls.Add(this.eingabeBTN);
            this.Name = "Start";
            this.Text = "Einnahmen - Ausgaben erfassen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button eingabeBTN;
        private System.Windows.Forms.Button ausgabeBTN;
    }
}

