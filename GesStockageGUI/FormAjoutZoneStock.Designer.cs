namespace GesStockageGUI
{
    partial class FormAjoutZoneStock
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
            this.lblNomZone = new System.Windows.Forms.Label();
            this.txtNomZone = new System.Windows.Forms.TextBox();
            this.lblBatiment = new System.Windows.Forms.Label();
            this.cbxBatiment = new System.Windows.Forms.ComboBox();
            this.lblCategProduit = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnEnreg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNomZone
            // 
            this.lblNomZone.AutoSize = true;
            this.lblNomZone.Location = new System.Drawing.Point(111, 80);
            this.lblNomZone.Name = "lblNomZone";
            this.lblNomZone.Size = new System.Drawing.Size(87, 13);
            this.lblNomZone.TabIndex = 0;
            this.lblNomZone.Text = "Nom de la zone :";
            // 
            // txtNomZone
            // 
            this.txtNomZone.Location = new System.Drawing.Point(223, 77);
            this.txtNomZone.Name = "txtNomZone";
            this.txtNomZone.Size = new System.Drawing.Size(301, 20);
            this.txtNomZone.TabIndex = 1;
            // 
            // lblBatiment
            // 
            this.lblBatiment.AutoSize = true;
            this.lblBatiment.Location = new System.Drawing.Point(69, 142);
            this.lblBatiment.Name = "lblBatiment";
            this.lblBatiment.Size = new System.Drawing.Size(129, 13);
            this.lblBatiment.TabIndex = 0;
            this.lblBatiment.Text = "Emplacement de la zone :";
            // 
            // cbxBatiment
            // 
            this.cbxBatiment.FormattingEnabled = true;
            this.cbxBatiment.Location = new System.Drawing.Point(223, 139);
            this.cbxBatiment.Name = "cbxBatiment";
            this.cbxBatiment.Size = new System.Drawing.Size(301, 21);
            this.cbxBatiment.TabIndex = 1;
            // 
            // lblCategProduit
            // 
            this.lblCategProduit.AutoSize = true;
            this.lblCategProduit.Location = new System.Drawing.Point(16, 201);
            this.lblCategProduit.Name = "lblCategProduit";
            this.lblCategProduit.Size = new System.Drawing.Size(182, 13);
            this.lblCategProduit.TabIndex = 2;
            this.lblCategProduit.Text = "Catégorie de produit qu\'elle contient :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(223, 198);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(301, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // btnEnreg
            // 
            this.btnEnreg.Location = new System.Drawing.Point(293, 260);
            this.btnEnreg.Name = "btnEnreg";
            this.btnEnreg.Size = new System.Drawing.Size(148, 48);
            this.btnEnreg.TabIndex = 4;
            this.btnEnreg.Text = "Enregistrer";
            this.btnEnreg.UseVisualStyleBackColor = true;
            // 
            // FormAjoutZoneStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEnreg);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblCategProduit);
            this.Controls.Add(this.lblBatiment);
            this.Controls.Add(this.cbxBatiment);
            this.Controls.Add(this.txtNomZone);
            this.Controls.Add(this.lblNomZone);
            this.Name = "FormAjoutZoneStock";
            this.Text = "FormAjoutZoneStock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomZone;
        private System.Windows.Forms.TextBox txtNomZone;
        private System.Windows.Forms.ComboBox cbxBatiment;
        private System.Windows.Forms.Label lblBatiment;
        private System.Windows.Forms.Label lblCategProduit;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnEnreg;
    }
}