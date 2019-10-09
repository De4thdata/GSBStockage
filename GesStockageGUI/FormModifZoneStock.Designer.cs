namespace GesStockageGUI
{
    partial class FormModifZoneStock
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
            this.lblNomZoneModif = new System.Windows.Forms.Label();
            this.cbxNomZoneModif = new System.Windows.Forms.ComboBox();
            this.lblModifEmpla = new System.Windows.Forms.Label();
            this.cbxModifEmpla = new System.Windows.Forms.ComboBox();
            this.lblModifCategProd = new System.Windows.Forms.Label();
            this.cbxModifCategProd = new System.Windows.Forms.ComboBox();
            this.btnModifZoneStock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNomZoneModif
            // 
            this.lblNomZoneModif.AutoSize = true;
            this.lblNomZoneModif.Location = new System.Drawing.Point(73, 59);
            this.lblNomZoneModif.Name = "lblNomZoneModif";
            this.lblNomZoneModif.Size = new System.Drawing.Size(197, 13);
            this.lblNomZoneModif.TabIndex = 0;
            this.lblNomZoneModif.Text = "Nom de la zone de stockage à modifier :";
            // 
            // cbxNomZoneModif
            // 
            this.cbxNomZoneModif.FormattingEnabled = true;
            this.cbxNomZoneModif.Location = new System.Drawing.Point(297, 56);
            this.cbxNomZoneModif.Name = "cbxNomZoneModif";
            this.cbxNomZoneModif.Size = new System.Drawing.Size(263, 21);
            this.cbxNomZoneModif.TabIndex = 1;
            // 
            // lblModifEmpla
            // 
            this.lblModifEmpla.AutoSize = true;
            this.lblModifEmpla.Location = new System.Drawing.Point(157, 114);
            this.lblModifEmpla.Name = "lblModifEmpla";
            this.lblModifEmpla.Size = new System.Drawing.Size(113, 13);
            this.lblModifEmpla.TabIndex = 2;
            this.lblModifEmpla.Text = "Nouvel emplacement :";
            // 
            // cbxModifEmpla
            // 
            this.cbxModifEmpla.FormattingEnabled = true;
            this.cbxModifEmpla.Location = new System.Drawing.Point(297, 111);
            this.cbxModifEmpla.Name = "cbxModifEmpla";
            this.cbxModifEmpla.Size = new System.Drawing.Size(263, 21);
            this.cbxModifEmpla.TabIndex = 3;
            // 
            // lblModifCategProd
            // 
            this.lblModifCategProd.AutoSize = true;
            this.lblModifCategProd.Location = new System.Drawing.Point(118, 171);
            this.lblModifCategProd.Name = "lblModifCategProd";
            this.lblModifCategProd.Size = new System.Drawing.Size(152, 13);
            this.lblModifCategProd.TabIndex = 4;
            this.lblModifCategProd.Text = "Nouvelle catégorie de produit :";
            // 
            // cbxModifCategProd
            // 
            this.cbxModifCategProd.FormattingEnabled = true;
            this.cbxModifCategProd.Location = new System.Drawing.Point(297, 168);
            this.cbxModifCategProd.Name = "cbxModifCategProd";
            this.cbxModifCategProd.Size = new System.Drawing.Size(263, 21);
            this.cbxModifCategProd.TabIndex = 5;
            // 
            // btnModifZoneStock
            // 
            this.btnModifZoneStock.Location = new System.Drawing.Point(350, 227);
            this.btnModifZoneStock.Name = "btnModifZoneStock";
            this.btnModifZoneStock.Size = new System.Drawing.Size(135, 57);
            this.btnModifZoneStock.TabIndex = 6;
            this.btnModifZoneStock.Text = "Modifier";
            this.btnModifZoneStock.UseVisualStyleBackColor = true;
            // 
            // FormModifZoneStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnModifZoneStock);
            this.Controls.Add(this.cbxModifCategProd);
            this.Controls.Add(this.lblModifCategProd);
            this.Controls.Add(this.cbxModifEmpla);
            this.Controls.Add(this.lblModifEmpla);
            this.Controls.Add(this.cbxNomZoneModif);
            this.Controls.Add(this.lblNomZoneModif);
            this.Name = "FormModifZoneStock";
            this.Text = "FormModifZoneStock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomZoneModif;
        private System.Windows.Forms.ComboBox cbxNomZoneModif;
        private System.Windows.Forms.Label lblModifEmpla;
        private System.Windows.Forms.ComboBox cbxModifEmpla;
        private System.Windows.Forms.Label lblModifCategProd;
        private System.Windows.Forms.ComboBox cbxModifCategProd;
        private System.Windows.Forms.Button btnModifZoneStock;
    }
}