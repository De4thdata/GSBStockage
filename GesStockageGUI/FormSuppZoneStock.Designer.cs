namespace GesStockageGUI
{
    partial class FormSuppZoneStock
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
            this.lblSuppNomZone = new System.Windows.Forms.Label();
            this.cbxSuppNomZone = new System.Windows.Forms.ComboBox();
            this.btnSuppZoneStock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSuppNomZone
            // 
            this.lblSuppNomZone.AutoSize = true;
            this.lblSuppNomZone.Location = new System.Drawing.Point(243, 100);
            this.lblSuppNomZone.Name = "lblSuppNomZone";
            this.lblSuppNomZone.Size = new System.Drawing.Size(206, 13);
            this.lblSuppNomZone.TabIndex = 0;
            this.lblSuppNomZone.Text = "Nom de la zone de stockage à supprimer :";
            // 
            // cbxSuppNomZone
            // 
            this.cbxSuppNomZone.FormattingEnabled = true;
            this.cbxSuppNomZone.Location = new System.Drawing.Point(200, 128);
            this.cbxSuppNomZone.Name = "cbxSuppNomZone";
            this.cbxSuppNomZone.Size = new System.Drawing.Size(301, 21);
            this.cbxSuppNomZone.TabIndex = 1;
            // 
            // btnSuppZoneStock
            // 
            this.btnSuppZoneStock.Location = new System.Drawing.Point(258, 203);
            this.btnSuppZoneStock.Name = "btnSuppZoneStock";
            this.btnSuppZoneStock.Size = new System.Drawing.Size(191, 48);
            this.btnSuppZoneStock.TabIndex = 2;
            this.btnSuppZoneStock.Text = "Supprimer";
            this.btnSuppZoneStock.UseVisualStyleBackColor = true;
            // 
            // FormSuppZoneStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSuppZoneStock);
            this.Controls.Add(this.cbxSuppNomZone);
            this.Controls.Add(this.lblSuppNomZone);
            this.Name = "FormSuppZoneStock";
            this.Text = "FormSuppZoneStock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSuppNomZone;
        private System.Windows.Forms.ComboBox cbxSuppNomZone;
        private System.Windows.Forms.Button btnSuppZoneStock;
    }
}